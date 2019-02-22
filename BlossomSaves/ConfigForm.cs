using System;
using System.Windows.Forms;

namespace BlossomSaves
{
    public partial class ConfigForm : Form
    {
        private BlossomConfig _config;


        public ConfigForm()
        {
            InitializeComponent();
            BlossomConfig.LoadConfig();
            _config = BlossomConfig.GetBlossomConfig();
            UpdateTextBoxes();
        }

        private void OrigSaveBrowse_Click(object sender, EventArgs e)
        {
            fbd.RootFolder = Environment.SpecialFolder.MyComputer;
            fbd.SelectedPath = _config.OriginalSaveDirectory;
            var result = fbd.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                OrigSave.Text = fbd.SelectedPath;
            }
        }

        private void ManagedSaveBrowse_Click(object sender, EventArgs e)
        {
            fbd.RootFolder = Environment.SpecialFolder.MyComputer;
            fbd.SelectedPath = _config.ManagedSaveDirectory;
            var result = fbd.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                ManagedSave.Text = fbd.SelectedPath;
            }
        }

        private void UpdateTextBoxes()
        {
            OrigSave.Text = _config.OriginalSaveDirectory;
            ManagedSave.Text = _config.ManagedSaveDirectory;
        }

        private void UpdateConifgObject()
        {
            _config.OriginalSaveDirectory = OrigSave.Text;
            _config.ManagedSaveDirectory = ManagedSave.Text;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            UpdateConifgObject();
            BlossomConfig.SaveConfig(_config);
            Close();
        }
    }
}
