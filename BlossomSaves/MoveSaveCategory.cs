using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BlossomSaves
{
    public partial class MoveSaveCategory : Form
    {
        public BindingList<Category> Categories;
        public string OriginalCategory;
        public string NewCategory;

        private BindingList<string> _categoryNames;
        private DialogAction _action;
        private SaveState _originalSave;
        private const string MOVETITLE = "Move Save to Category";
        private const string COPYTITLE = "Copy Save to Category";
        private const string MOVEBUTTON = "Move";
        private const string COPYBUTTON = "Copy";

        private MoveSaveCategory()
        {
            InitializeComponent();
        }

        public MoveSaveCategory(DialogAction action, BindingList<Category> categories, string originalCategory, SaveState originalSave) : this()
        {
            _action = action;
            Categories = categories;
            OriginalCategory = originalCategory;
            _originalSave = originalSave;

            if (_action == DialogAction.Move)
            {
                Text = MOVETITLE;
                MoveSave.Text = MOVEBUTTON;
            }
            else
            {
                Text = COPYTITLE;
                MoveSave.Text = COPYBUTTON;
            }

            _categoryNames = new BindingList<string>(Categories.Select(o => o.CategoryName).Where(o => !string.Equals(o,originalCategory,StringComparison.InvariantCulture)).ToList());

            BindCategories();
            NewCategory = _categoryNames[0];
        }

        private void BindCategories()
        {
            CategoryCombo.DataSource = _categoryNames;
            CategoryCombo.Refresh();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Categories = null;
            OriginalCategory = string.Empty;

            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void Move_Click(object sender, EventArgs e)
        {
            MoveOrCopySaveState();
        }

        private void CategoryCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            NewCategory = _categoryNames[CategoryCombo.SelectedIndex];
        }

        private void EnterKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                MoveOrCopySaveState();
            }
        }

        private void MoveOrCopySaveState()
        {
            var newSave = Helper.CreateSaveState(NewCategory, _originalSave.SaveStateName, Helper.GetFullManagedSavePath(_originalSave.FileAName), Helper.GetFullManagedSavePath(_originalSave.FileBName), Helper.GetFullManagedSavePath(_originalSave.FileCName));

            for (var i = 0; i < Categories.Count; i++)
            {
                if (!Categories[i].CategoryName.Equals(NewCategory, StringComparison.InvariantCulture)) continue;

                newSave.PositionNumber = Categories[i].SaveStates.Count;
                Categories[i].SaveStates.Add(newSave);
                break;
            }


            if (_action == DialogAction.Move)
            {
                for (var i = 0; i < Categories.Count; i++)
                {
                    if (!Categories[i].CategoryName.Equals(OriginalCategory, StringComparison.InvariantCulture)) continue;

                    for (var j = 0; j < Categories[i].SaveStates.Count; j++)
                    {
                        if (!Categories[i].SaveStates[j].SaveStateName.Equals(_originalSave.SaveStateName, StringComparison.InvariantCulture)) continue;

                        Helper.DeleteSave(Categories[i].SaveStates[j]);
                        Categories[i].SaveStates.RemoveAt(j);
                    }
                }
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
