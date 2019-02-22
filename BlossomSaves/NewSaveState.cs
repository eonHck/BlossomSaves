using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BlossomSaves
{
    public partial class NewSaveState : Form
    {
        public string SaveStateName;
        private DialogAction _action;
        private List<string> _saveNames;

        private const string NEWTITLE = "New Save";
        private const string RENAMETITLE = "Rename Save";

        private NewSaveState()
        {
            InitializeComponent();
            SaveStateName = string.Empty;
        }

        public NewSaveState(DialogAction action, List<string> saveNames) : this()
        {
            _saveNames = saveNames;
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
            SaveStateName = string.Empty;
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            HandleOK();
        }

        private void NewCategory_Load(object sender, EventArgs e)
        {
            txtSaveName.Text = SaveStateName;
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
            if (string.IsNullOrWhiteSpace(txtSaveName.Text)) return;

            var newName = txtSaveName.Text.Trim();

            foreach (var name in _saveNames)
            {
                if (name.Equals(newName, StringComparison.InvariantCulture))
                {
                    MessageBox.Show("Please enter a unique save name.", "Save Name Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            if (SaveStateName.Equals(newName, StringComparison.InvariantCulture))
            {
                MessageBox.Show("Please enter a new save name.", "Save Name Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SaveStateName = newName;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
