using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace BlossomSaves
{
    public partial class BlossomSaves : Form
    {
        private static readonly string _basePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        private static readonly string _saveInfoFile = Path.Combine(_basePath, "saveStateInfo.json");
        private BindingList<Category> _categories;
        private BindingList<SaveState> _saveStates;
        private int _saveSlot;
        private int _loadSlot;



        public BlossomSaves()
        {
            InitializeComponent();
            LoadSaves();
            BindCategories();
            _saveSlot = 1;
            _loadSlot = 1;
        }

        private void ConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var configForm = new ConfigForm();
            configForm.ShowDialog();
        }


        private void LoadSaves()
        {
            if (File.Exists(_saveInfoFile))
            {
                var categories = ReadSaveStateInfo(_saveInfoFile);
                _categories = new BindingList<Category>(categories);
            }
            else
            {
                _categories = new BindingList<Category>();
            }
        }

        private void BindCategories()
        {
            listCategories.DataSource = null;
            listCategories.DataSource = _categories;
            listCategories.DisplayMember = "CategoryName";
            listCategories.Refresh();
        }

        private void BindSaves()
        {
            listSaveStates.DataSource = _saveStates;
            listSaveStates.DisplayMember = "SaveStateName";
            listSaveStates.Refresh();
        }

        private void BtnNewCategory_Click(object sender, EventArgs e)
        {
            var newCategory = new NewCategory(DialogAction.New, GetCategoryNames());
            newCategory.ShowDialog();
            if (newCategory.DialogResult == DialogResult.OK)
            {
                var cat = new Category()
                {
                    CategoryName = newCategory.CategoryName,
                    PositionNumber = _categories.Count,
                    SaveStates = new List<SaveState>()
                };
                _categories.Add(cat);
                BindCategories();
            }
            Helper.WriteSaveInfo(_categories);
        }

        private void btnRenameCategory_Click(object sender, EventArgs e)
        {
            if (listCategories.SelectedIndex < 0 ) return;

            var newCategory = new NewCategory(DialogAction.Rename, GetCategoryNames());
            newCategory.CategoryName = _categories[listCategories.SelectedIndex].CategoryName;

            newCategory.ShowDialog();
            if (newCategory.DialogResult == DialogResult.OK)
            {
                _categories[listCategories.SelectedIndex].CategoryName = newCategory.CategoryName;

                for (int i = 0; i < _categories[listCategories.SelectedIndex].SaveStates.Count; i++)
                {
                    _categories[listCategories.SelectedIndex].SaveStates[i] = Helper.RenameSave(_categories[listCategories.SelectedIndex].SaveStates[i], newCategory.CategoryName, _categories[listCategories.SelectedIndex].SaveStates[i].SaveStateName);
                }

                BindCategories();
            }
            Helper.WriteSaveInfo(_categories);
        }

        private void btnCategoryUp_Click(object sender, EventArgs e)
        {
            var index = listCategories.SelectedIndex;
            if (index <= 0) return;

            _categories[index].PositionNumber--;
            _categories[index-1].PositionNumber++;

            _categories = SortCategories(_categories);
            BindCategories();
            listCategories.SelectedIndex = index - 1;
            Helper.WriteSaveInfo(_categories);
        }

        private void btnCategoryDown_Click(object sender, EventArgs e)
        {
            var index = listCategories.SelectedIndex;
            if (index < 0 || index >= _categories.Count-1) return;

            _categories[index].PositionNumber++;
            _categories[index + 1].PositionNumber--;

            _categories = SortCategories(_categories);
            BindCategories();
            listCategories.SelectedIndex = index + 1;
            Helper.WriteSaveInfo(_categories);
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            var index = listCategories.SelectedIndex;
            if (index < 0 || index > _categories.Count - 1) return;

            if (_categories[index].SaveStates.Count > 0)
            {
                var result = MessageBox.Show(
                        $"Category/Group \"{_categories[index].CategoryName}\" has {_categories[index].SaveStates.Count} save(s) associated with it, do you really want to delete this category?"
                        , $"Delete Cateogry/Group \"{_categories[index].CategoryName}\"?"
                        , MessageBoxButtons.YesNo
                        , MessageBoxIcon.Warning);

                if (result == DialogResult.No) return;
            }

            for (int i = 0; i < _categories[listCategories.SelectedIndex].SaveStates.Count; i++)
            {
                Helper.DeleteSave(_categories[listCategories.SelectedIndex].SaveStates[i]);
            }

            _categories.RemoveAt(index);
            _categories = SortCategories(_categories);
            BindCategories();
            if (index > _categories.Count - 1) listCategories.SelectedIndex = _categories.Count - 1;
            else listCategories.SelectedIndex = index;

            Helper.WriteSaveInfo(_categories);
        }

        private void ResetPositionNumbers()
        {
            for (var i = 0; i < _categories.Count; i++)
            {
                _categories[i].PositionNumber = i;

                for(var j = 0; j < _categories[i].SaveStates.Count; j++)
                {
                    _categories[i].SaveStates[j].PositionNumber = j;
                }
            }
        }

        private BindingList<Category> SortCategories(BindingList<Category> cats)
        {
            var sortedCats = cats.OrderBy(x => x.PositionNumber).ToList();
            var sortedBindingCats = new BindingList<Category>(sortedCats);
            return sortedBindingCats;
        }

        private List<SaveState> SortSaveStates(List<SaveState> saves)
        {
            var sortedSaves = saves.OrderBy(x => x.PositionNumber).ToList();
            return sortedSaves;
        }

        private void BlossomSaves_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(Path.Combine(_basePath, "SaveData")))
            {
                Directory.CreateDirectory(Path.Combine(_basePath, "SaveData"));
            }

            while (!BlossomConfig.BlossomConfigExists())
            {
                var configForm = new ConfigForm();
                configForm.ShowDialog();
            }

            if (listCategories.Items.Count > 0)
            {
                listCategories.SelectedIndex = 0;
            }
        }

        private void BlossomSaves_FormClosing(object sender, FormClosingEventArgs e)
        {
            Helper.WriteSaveInfo(_categories);
        }

        private void listCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = (listCategories.Items.Count > 0 && listCategories.SelectedIndex >= 0 && listCategories.SelectedIndex < listCategories.Items.Count) ? (Category)listCategories.Items[listCategories.SelectedIndex] : null;
            _saveStates = (selected != null) ? new BindingList<SaveState>(selected.SaveStates) : new BindingList<SaveState>();
            BindSaves();
        }

        private void SaveCurrentGameState_Click(object sender, EventArgs e)
        {
            var newSaveState = new NewSaveState(DialogAction.New, GetSaveNames(_categories[listCategories.SelectedIndex]));
            newSaveState.ShowDialog();

            if (newSaveState.DialogResult == DialogResult.OK)
            {
                var selectedCategory = _categories[listCategories.SelectedIndex];

                var save = Helper.CreateSaveState(selectedCategory.CategoryName, newSaveState.SaveStateName, _saveSlot);
                save.PositionNumber = selectedCategory.SaveStates.Count;

                _categories[listCategories.SelectedIndex].SaveStates.Add(save);
                _saveStates = new BindingList<SaveState>(_categories[listCategories.SelectedIndex].SaveStates);
                BindSaves();
            }
            Helper.WriteSaveInfo(_categories);
        }

        private void RenameSave_Click(object sender, EventArgs e)
        {
            if (listSaveStates.SelectedIndex < 0) return;

            var newSaveState = new NewSaveState(DialogAction.Rename, GetSaveNames(_categories[listCategories.SelectedIndex]));
            newSaveState.SaveStateName = _saveStates[listSaveStates.SelectedIndex].SaveStateName;
            newSaveState.ShowDialog();

            if (newSaveState.DialogResult == DialogResult.OK)
            {
                var config = BlossomConfig.GetBlossomConfig();
                var categoryName = _categories[listCategories.SelectedIndex].CategoryName;
                var originalSaveState = _categories[listCategories.SelectedIndex].SaveStates[listSaveStates.SelectedIndex];

                _categories[listCategories.SelectedIndex].SaveStates[listSaveStates.SelectedIndex] = Helper.RenameSave(originalSaveState, categoryName, newSaveState.SaveStateName);

                _saveStates = new BindingList<SaveState>(_categories[listCategories.SelectedIndex].SaveStates);

                BindSaves();
            }

            Helper.WriteSaveInfo(_categories);
        }

        private void MoveUpSave_Click(object sender, EventArgs e)
        {
            var index = listSaveStates.SelectedIndex;
            if (index <= 0) return;

            var categoryIndex = listCategories.SelectedIndex;

            _categories[categoryIndex].SaveStates[index].PositionNumber--;
            _categories[categoryIndex].SaveStates[index - 1].PositionNumber++;

            _categories[categoryIndex].SaveStates = SortSaveStates(_categories[categoryIndex].SaveStates);
            _saveStates = new BindingList<SaveState>(_categories[categoryIndex].SaveStates);
            BindSaves();
            listSaveStates.SelectedIndex = index - 1;

            Helper.WriteSaveInfo(_categories);
        }

        private void MoveDownSave_Click(object sender, EventArgs e)
        {
            var index = listSaveStates.SelectedIndex;
            if (index < 0 || index >= _saveStates.Count) return;

            var categoryIndex = listCategories.SelectedIndex;

            _categories[categoryIndex].SaveStates[index].PositionNumber++;
            _categories[categoryIndex].SaveStates[index + 1].PositionNumber--;

            _categories[categoryIndex].SaveStates = SortSaveStates(_categories[categoryIndex].SaveStates);
            _saveStates = new BindingList<SaveState>(_categories[categoryIndex].SaveStates);
            BindSaves();
            listSaveStates.SelectedIndex = index + 1;

            Helper.WriteSaveInfo(_categories);
        }

        private void DeleteSave_Click(object sender, EventArgs e)
        {
            var index = listSaveStates.SelectedIndex;
            if (index < 0 || index > _saveStates.Count - 1) return;

            var categoryIndex = listCategories.SelectedIndex;

            Helper.DeleteSave(_saveStates[index]);

            _categories[categoryIndex].SaveStates.RemoveAt(index);

            ResetPositionNumbers();
            _saveStates = new BindingList<SaveState>(_categories[categoryIndex].SaveStates);
            BindSaves();
            Helper.WriteSaveInfo(_categories);
        }

        private void ImportExistingSave_Click(object sender, EventArgs e)
        {
            var import = new ImportSave();
            import.SaveSlot = _saveSlot;
            import.CategoryName = _categories[listCategories.SelectedIndex].CategoryName;

            var result = import.ShowDialog();

            if (result == DialogResult.OK && import.ImportedSaveState != null)
            {
                import.ImportedSaveState.PositionNumber = _categories[listCategories.SelectedIndex].SaveStates.Count();
                _categories[listCategories.SelectedIndex].SaveStates.Add(import.ImportedSaveState);
                _saveStates = new BindingList<SaveState>(_categories[listCategories.SelectedIndex].SaveStates);
                BindSaves();
            }
            Helper.WriteSaveInfo(_categories);
        }

        private void LoadSelectedSave_Click(object sender, EventArgs e)
        {
            var config = BlossomConfig.GetBlossomConfig();
            var targetAPath = Path.Combine(config.OriginalSaveDirectory, $"{Helper.SaveFileBaseName}{_loadSlot}{Helper.AFileEnding}");
            var targetBPath = Path.Combine(config.OriginalSaveDirectory, $"{Helper.SaveFileBaseName}{_loadSlot}{Helper.BFileEnding}");
            var targetCPath = Path.Combine(config.OriginalSaveDirectory, $"{Helper.SaveFileBaseName}{_loadSlot}{Helper.CFileEnding}");

            var selectedSave = _saveStates[listSaveStates.SelectedIndex];

            try
            {
                File.Copy(Path.Combine(config.ManagedSaveDirectory, selectedSave.FileAName), targetAPath, true);
                File.Copy(Path.Combine(config.ManagedSaveDirectory, selectedSave.FileBName), targetBPath, true);
                File.Copy(Path.Combine(config.ManagedSaveDirectory, selectedSave.FileCName), targetCPath, true);
            }
            catch (Exception) { }
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            var rb = (RadioButton)sender;
            if (!rb.Checked) return;

            var slotNumber = Int32.Parse(rb.Name.Substring(4, 1));
            if (rb.Name.StartsWith("Save", StringComparison.InvariantCulture))
            {
                _saveSlot = slotNumber;
            }
            else
            {
                _loadSlot = slotNumber;
            }
        }

        private void CopyToCategory_Click(object sender, EventArgs e)
        {
            if (_categories.Count <= 1)
            {
                MessageBox.Show("Please make sure at least 2 categories exist first.","Copy to Category Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (listSaveStates.SelectedIndex < 0) return;

            var copySaveCategory = new MoveSaveCategory(DialogAction.Copy, _categories, _categories[listCategories.SelectedIndex].CategoryName, _saveStates[listSaveStates.SelectedIndex]);
            var result = copySaveCategory.ShowDialog();

            if (result == DialogResult.OK)
            {
                _categories = copySaveCategory.Categories;
                ResetPositionNumbers();
                BindCategories();
            }
            Helper.WriteSaveInfo(_categories);
        }

        private void MoveToCategory_Click(object sender, EventArgs e)
        {
            var categoryIndex = listCategories.SelectedIndex;
            if (_categories.Count <= 1)
            {
                MessageBox.Show("Please make sure at least 2 categories exist first.", "Copy to Category Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (listSaveStates.SelectedIndex < 0) return;

            var moveSaveCategory = new MoveSaveCategory(DialogAction.Move, _categories, _categories[listCategories.SelectedIndex].CategoryName, _saveStates[listSaveStates.SelectedIndex]);
            var result = moveSaveCategory.ShowDialog();

            if (result == DialogResult.OK)
            {
                _categories = moveSaveCategory.Categories;
                ResetPositionNumbers();
                BindCategories();
                _saveStates = new BindingList<SaveState>(_categories[categoryIndex].SaveStates);
                BindSaves();
            }
            Helper.WriteSaveInfo(_categories);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exportSavesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var exportCollection = new ExportCollection(_categories);
            exportCollection.ShowDialog();

        }

        private void importSavesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var outputPath = Path.Combine(_basePath, "temp");
            try
            {
                var ofd = new OpenFileDialog();
                ofd.Filter = "Blossom Save Export files (*.bsav)|*.bsav|All files (*.*)|*.*";
                ofd.InitialDirectory = _basePath;
                var result = ofd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(ofd.FileName.Trim()))
                {
                    ZipFile.ExtractToDirectory(ofd.FileName.Trim(), outputPath);

                    var importCategories = ReadSaveStateInfo(Path.Combine(outputPath, "saveStateInfo.json"));

                    foreach (var cat in importCategories)
                    {
                        var imCat = new Category()
                        {
                            CategoryName = $"[Imported] {cat.CategoryName}",
                            PositionNumber = _categories.Count,
                            SaveStates = new List<SaveState>()
                        };
                        foreach(var save in cat.SaveStates)
                        {
                            imCat.SaveStates.Add(Helper.CreateSaveState(imCat.CategoryName, save.SaveStateName, Path.Combine(outputPath, save.FileAName), Path.Combine(outputPath, save.FileBName), Path.Combine(outputPath, save.FileCName)));
                        }
                        _categories.Add(imCat);
                    }
                    Directory.Delete(outputPath, true);
                }
            }
            catch (Exception) { }

            BindCategories();
        }

        private void aboutBlossomSavesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var about = new About();
            about.ShowDialog();
        }

        private List<string> GetCategoryNames()
        {
            return _categories.Select(o => o.CategoryName).ToList();
        }

        private List<string> GetSaveNames(Category cat)
        {
            return cat.SaveStates.Select(o => o.SaveStateName).ToList();
        }

        private List<Category> ReadSaveStateInfo(string filePath)
        {
            if (File.Exists(filePath))
            {
                var saveInfoText = string.Empty;
                try
                {
                    saveInfoText = File.ReadAllText(filePath);
                }
                catch (Exception) { }
                var categories = JsonConvert.DeserializeObject<List<Category>>(saveInfoText);
                return categories;
            }
            else
            {
                return new List<Category>();
            }
        }
    }
}

