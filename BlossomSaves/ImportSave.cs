using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace BlossomSaves
{
    public partial class ImportSave : Form
    {
        public int SaveSlot;
        public string CategoryName;
        public SaveState ImportedSaveState;

        public ImportSave()
        {
            InitializeComponent();
        }

        private void FolderBrowse_Click(object sender, EventArgs e)
        {
            fbd.RootFolder = Environment.SpecialFolder.MyComputer;
            var result = fbd.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                ImportFolderPath.Text = fbd.SelectedPath;
                RefreshFileData();
            }
        }

        private void ImportSaves_Load(object sender, EventArgs e)
        {
            if (SaveSlot == 1) Slot1.Checked = true;
            else if (SaveSlot == 2) Slot2.Checked = true;
            else Slot3.Checked = true;
        }

        private void RefreshFileData()
        {
            var aFilePath = Path.Combine(ImportFolderPath.Text, $"{Helper.SaveFileBaseName}{SaveSlot}{Helper.AFileEnding}");
            var bFilePath = Path.Combine(ImportFolderPath.Text, $"{Helper.SaveFileBaseName}{SaveSlot}{Helper.BFileEnding}");
            var cFilePath = Path.Combine(ImportFolderPath.Text, $"{Helper.SaveFileBaseName}{SaveSlot}{Helper.CFileEnding}");

            if (File.Exists(aFilePath)) BaseFilePath.Text = aFilePath;
            if (File.Exists(bFilePath)) BFilePath.Text = bFilePath;
            if (File.Exists(cFilePath)) CFilePath.Text = cFilePath;
        }

        private void RefreshData_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ImportFolderPath.Text)) return;

            RefreshFileData();
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            var rb = (RadioButton)sender;
            if (!rb.Checked) return;

            var slotNumber = Int32.Parse(rb.Name.Substring(4, 1));
            SaveSlot = slotNumber;
        }

        private void BaseFileBrowse_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(ImportFolderPath.Text)) ofd.InitialDirectory = ImportFolderPath.Text;

            var result = ofd.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(ofd.FileName))
            {
                BaseFilePath.Text = ofd.FileName;
            }
        }

        private void BFileBrowse_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(ImportFolderPath.Text)) ofd.InitialDirectory = ImportFolderPath.Text;

            var result = ofd.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(ofd.FileName))
            {
                BFilePath.Text = ofd.FileName;
            }
        }

        private void CFileBrowse_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(ImportFolderPath.Text)) ofd.InitialDirectory = ImportFolderPath.Text;

            var result = ofd.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(ofd.FileName))
            {
                CFilePath.Text = ofd.FileName;
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            ImportedSaveState = null;
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void Import_Click(object sender, EventArgs e)
        {
            var invalidFields = new List<string>();
            if (string.IsNullOrWhiteSpace(txtSaveName.Text)) invalidFields.Add("Save Name");
            if (string.IsNullOrWhiteSpace(BaseFilePath.Text)) invalidFields.Add("Base File");
            if (string.IsNullOrWhiteSpace(BFilePath.Text)) invalidFields.Add("B File");
            if (string.IsNullOrWhiteSpace(CFilePath.Text)) invalidFields.Add("C File");

            if (invalidFields.Count > 0)
            {
                var iFields = string.Join(", ", invalidFields);
                MessageBox.Show($"Invalid information in field(s): {iFields}.", "Import Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ImportedSaveState = Helper.CreateSaveState(CategoryName, txtSaveName.Text, BaseFilePath.Text, BFilePath.Text, CFilePath.Text);

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
