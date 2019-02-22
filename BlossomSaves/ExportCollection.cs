using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Compression;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;

namespace BlossomSaves
{
    public partial class ExportCollection : Form
    {
        private BindingList<Category> _cats;
        private BindingList<Category> _availableCats;
        private BindingList<Category> _selectedCats;
        private BindingList<SaveState> _availableSaves;
        private BindingList<SaveState> _selectedSaves;

        private static readonly string _basePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        private static readonly string _exportBuildPath = Path.Combine(_basePath, "temp");

        private ExportCollection()
        {
            InitializeComponent();
        }

        public ExportCollection(BindingList<Category> cats): this()
        {
            _cats = new BindingList<Category>();
            _availableCats = new BindingList<Category>();
            _selectedCats = new BindingList<Category>();
            _availableSaves = new BindingList<SaveState>();
            _selectedSaves = new BindingList<SaveState>();

            foreach (var cat in cats)
            {
                _cats.Add(cat.Clone());
                _availableCats.Add(cat.Clone());
            }

            BindCats();
        }

        private void BindCats()
        {
            listAvailableCats.DataSource = _availableCats;
            listAvailableCats.DisplayMember = "CategoryName";
            listAvailableCats.Refresh();

            listSelectedCats.DataSource = _selectedCats;
            listSelectedCats.DisplayMember = "CategoryName";
            listSelectedCats.Refresh();
        }

        private void BindSaves()
        {
            listAvailableSaves.DataSource = _availableSaves;
            listAvailableSaves.DisplayMember = "CatAndSaveNames";
            listAvailableSaves.Refresh();

            listSelectedSaves.DataSource = _selectedSaves;
            listSelectedSaves.DisplayMember = "CatAndSaveNames";
            listSelectedSaves.Refresh();
        }

        private void AddSelectedCategory()
        {
            var index = listAvailableCats.SelectedIndex;
            if (index < 0 || index >= _availableCats.Count) return;

            _selectedCats.Add(_availableCats[index]);

            foreach(var save in _availableCats[index].SaveStates)
            {
                _availableSaves.Add(save);
            }

            _availableCats.RemoveAt(index);
            BindCats();
            BindSaves();
        }

        private void RemoveSelectedCategory()
        {
            var index = listSelectedCats.SelectedIndex;
            if (index < 0 || index >= _selectedCats.Count) return;

            var catName = _selectedCats[index].CategoryName;

            _availableCats.Add(_selectedCats[index]);
            
            for (var i = _availableSaves.Count - 1; i >= 0; i--)
            {
                if (_availableSaves[i].CategoryName.Equals(catName, StringComparison.InvariantCulture))
                {
                    _availableSaves.RemoveAt(i);
                }
            }

            for (var i = _selectedSaves.Count - 1; i >= 0 ; i--)
            {
                if (_selectedSaves[i].CategoryName.Equals(catName, StringComparison.InvariantCulture))
                {
                    _selectedSaves.RemoveAt(i);
                }
            }
            
            _selectedCats.RemoveAt(index);
            BindCats();
            BindSaves();
        }

        private void AddAllCategories()
        {
            foreach (var cat in _availableCats)
            {
                _selectedCats.Add(cat);
                foreach (var save in cat.SaveStates)
                {
                    _availableSaves.Add(save);
                }
            }
            _availableCats.Clear();

            BindCats();
            BindSaves();
        }

        private void RemoveAllCategories()
        {
            foreach (var cat in _selectedCats)
            {
                _availableCats.Add(cat);
            }
            _selectedCats.Clear();
            _availableSaves.Clear();
            _selectedSaves.Clear();

            BindCats();
            BindSaves();
        }

        private void AddAllSaves()
        {
            foreach (var save in _availableSaves)
            {
                _selectedSaves.Add(save);
            }
            _availableSaves.Clear();

            BindSaves();
        }

        private void AddSelectedSave()
        {
            var index = listAvailableSaves.SelectedIndex;
            if (index < 0 || index >= _availableSaves.Count) return;

            _selectedSaves.Add(_availableSaves[index]);
            _availableSaves.RemoveAt(index);

            BindSaves();
        }

        private void RemoveSelectedSave()
        {
            var index = listSelectedSaves.SelectedIndex;
            if (index < 0 || index >= _selectedSaves.Count) return;

            _availableSaves.Add(_selectedSaves[index]);
            _selectedSaves.RemoveAt(index);

            BindSaves();
        }

        private void RemoveAllSaves()
        {
            foreach (var save in _selectedSaves)
            {
                _availableSaves.Add(save);
            }
            _selectedSaves.Clear();

            BindSaves();
        }

        private void Export()
        {
            try
            {
                var sfd = new SaveFileDialog();
                sfd.Filter = "Blossom Save Export files (*.bsav)|*.bsav|All files (*.*)|*.*";
                sfd.InitialDirectory = _basePath;
                sfd.FileName = "BlossomSaveExport.bsav";
                var result = sfd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(sfd.FileName.Trim()))
                {
                    
                    var exportCats = GetExportCats();

                    Directory.CreateDirectory(_exportBuildPath);

                    foreach (var cat in exportCats)
                    {
                        foreach (var save in cat.SaveStates)
                        {
                            File.Copy(Helper.GetFullManagedSavePath(save.FileAName), Path.Combine(_exportBuildPath, save.FileAName), true);
                            File.Copy(Helper.GetFullManagedSavePath(save.FileBName), Path.Combine(_exportBuildPath, save.FileBName), true);
                            File.Copy(Helper.GetFullManagedSavePath(save.FileCName), Path.Combine(_exportBuildPath, save.FileCName), true);
                        }
                    }

                    var exportCatsInfo = JsonConvert.SerializeObject(exportCats);
                    File.WriteAllText(Path.Combine(_exportBuildPath, "saveStateInfo.json"), exportCatsInfo);


                    var outputFile = sfd.FileName.Trim();

                    if (File.Exists(outputFile))
                    {
                        File.Delete(outputFile);
                    }

                    ZipFile.CreateFromDirectory(_exportBuildPath, Path.Combine(_basePath, outputFile));

                    Directory.Delete(_exportBuildPath, true);
                }
            }
            catch (Exception) { }

            DialogResult = DialogResult.OK;
            Close();
        }

        public BindingList<Category> GetExportCats()
        {
            var exportCats = new BindingList<Category>();
            if (ExportAllSaves.Checked)
            {
                foreach (var cat in _cats)
                {
                    exportCats.Add(cat.Clone());
                }
            }
            else
            {
                foreach (var cat in _selectedCats)
                {
                    var clonedCat = cat.Clone();
                    clonedCat.SaveStates.Clear();
                    exportCats.Add(clonedCat);
                }

                foreach (var save in _selectedSaves)
                {
                    foreach (var cat in exportCats)
                    {
                        if (!cat.CategoryName.Equals(save.CategoryName, StringComparison.InvariantCulture)) continue;
                        cat.SaveStates.Add(save.Clone());
                    }
                }
            }

            return exportCats;
        }

        private void ExportAllSaves_CheckedChanged(object sender, EventArgs e)
        {
            CategoriesGroup.Enabled = !ExportAllSaves.Checked;
            SavesGroup.Enabled = !ExportAllSaves.Checked;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void AddAllCats_Click(object sender, EventArgs e)
        {
            AddAllCategories();
        }

        private void AddSelectedCat_Click(object sender, EventArgs e)
        {
            AddSelectedCategory();
        }

        private void RemoveSelectedCat_Click(object sender, EventArgs e)
        {
            RemoveSelectedCategory();
        }

        private void RemoveAllCats_Click(object sender, EventArgs e)
        {
            RemoveAllCategories();
        }

        private void AddAllSaveButton_Click(object sender, EventArgs e)
        {
            AddAllSaves();
        }

        private void AddSelectedSaveButton_Click(object sender, EventArgs e)
        {
            AddSelectedSave();
        }

        private void RemoveSelectedSaveButton_Click(object sender, EventArgs e)
        {
            RemoveSelectedSave();
        }

        private void RemoveAllSavesButton_Click(object sender, EventArgs e)
        {
            RemoveAllSaves();
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            Export();
        }
    }
}
