using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BlossomSaves
{
    public partial class NewCategory : Form
    {
        public string CategoryName;
        private DialogAction _action;
        private List<string> _catNames;

        private const string NEWTITLE = "New Category/Group";
        private const string RENAMETITLE = "Rename Category/Group";

        private NewCategory()
        {
            InitializeComponent();
            CategoryName = string.Empty;
        }

        public NewCategory(DialogAction action, List<string> catNames) : this()
        {
            _catNames = catNames;
            _action = action;
            if (action == DialogAction.New)
            {
                Text = NEWTITLE;
            }
            else
            {
                Text = RENAMETITLE;
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            CategoryName = string.Empty;
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            HandleOK();
        }

        private void NewCategory_Load(object sender, EventArgs e)
        {
            txtCategoryName.Text = CategoryName;
        }

        private void EnterKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                HandleOK();
            }
        }

        private void HandleOK()
        {
            if (string.IsNullOrWhiteSpace(txtCategoryName.Text)) return;

            var newName = txtCategoryName.Text.Trim();

            foreach (var name in _catNames)
            {
                if (name.Equals(newName, StringComparison.InvariantCulture))
                {
                    MessageBox.Show("Please enter a unique Category/Group name.", "Category/Group Name Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            if (CategoryName.Equals(newName, StringComparison.InvariantCulture))
            {
                MessageBox.Show("Please enter a new Category/Group name.", "Category/Group Name Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            CategoryName = newName;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
