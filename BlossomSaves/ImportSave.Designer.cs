namespace BlossomSaves
{
    partial class ImportSave
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportSave));
            this.SaveGroup = new System.Windows.Forms.GroupBox();
            this.Slot3 = new System.Windows.Forms.RadioButton();
            this.Slot2 = new System.Windows.Forms.RadioButton();
            this.Slot1 = new System.Windows.Forms.RadioButton();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.ImportFolderPath = new System.Windows.Forms.TextBox();
            this.FolderBrowse = new System.Windows.Forms.Button();
            this.RefreshData = new System.Windows.Forms.Button();
            this.BaseLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BaseFilePath = new System.Windows.Forms.TextBox();
            this.BaseFileBrowse = new System.Windows.Forms.Button();
            this.BFileBrowse = new System.Windows.Forms.Button();
            this.BFilePath = new System.Windows.Forms.TextBox();
            this.CFileBrowse = new System.Windows.Forms.Button();
            this.CFilePath = new System.Windows.Forms.TextBox();
            this.SaveNameLabel = new System.Windows.Forms.Label();
            this.txtSaveName = new System.Windows.Forms.TextBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.Import = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.SaveGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveGroup
            // 
            this.SaveGroup.Controls.Add(this.Slot3);
            this.SaveGroup.Controls.Add(this.Slot2);
            this.SaveGroup.Controls.Add(this.Slot1);
            this.SaveGroup.Location = new System.Drawing.Point(13, 13);
            this.SaveGroup.Name = "SaveGroup";
            this.SaveGroup.Size = new System.Drawing.Size(117, 46);
            this.SaveGroup.TabIndex = 0;
            this.SaveGroup.TabStop = false;
            this.SaveGroup.Text = "Save Slot";
            // 
            // Slot3
            // 
            this.Slot3.AutoSize = true;
            this.Slot3.Location = new System.Drawing.Point(81, 19);
            this.Slot3.Name = "Slot3";
            this.Slot3.Size = new System.Drawing.Size(31, 17);
            this.Slot3.TabIndex = 2;
            this.Slot3.Text = "3";
            this.Slot3.UseVisualStyleBackColor = true;
            this.Slot3.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // Slot2
            // 
            this.Slot2.AutoSize = true;
            this.Slot2.Location = new System.Drawing.Point(44, 19);
            this.Slot2.Name = "Slot2";
            this.Slot2.Size = new System.Drawing.Size(31, 17);
            this.Slot2.TabIndex = 1;
            this.Slot2.Text = "2";
            this.Slot2.UseVisualStyleBackColor = true;
            this.Slot2.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // Slot1
            // 
            this.Slot1.AutoSize = true;
            this.Slot1.Checked = true;
            this.Slot1.Location = new System.Drawing.Point(7, 20);
            this.Slot1.Name = "Slot1";
            this.Slot1.Size = new System.Drawing.Size(31, 17);
            this.Slot1.TabIndex = 0;
            this.Slot1.TabStop = true;
            this.Slot1.Text = "1";
            this.Slot1.UseVisualStyleBackColor = true;
            this.Slot1.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Import From Folder";
            // 
            // ImportFolderPath
            // 
            this.ImportFolderPath.Location = new System.Drawing.Point(112, 75);
            this.ImportFolderPath.Name = "ImportFolderPath";
            this.ImportFolderPath.Size = new System.Drawing.Size(233, 20);
            this.ImportFolderPath.TabIndex = 2;
            // 
            // FolderBrowse
            // 
            this.FolderBrowse.Location = new System.Drawing.Point(351, 73);
            this.FolderBrowse.Name = "FolderBrowse";
            this.FolderBrowse.Size = new System.Drawing.Size(75, 23);
            this.FolderBrowse.TabIndex = 3;
            this.FolderBrowse.Text = "Browse";
            this.FolderBrowse.UseVisualStyleBackColor = true;
            this.FolderBrowse.Click += new System.EventHandler(this.FolderBrowse_Click);
            // 
            // RefreshData
            // 
            this.RefreshData.Location = new System.Drawing.Point(13, 113);
            this.RefreshData.Name = "RefreshData";
            this.RefreshData.Size = new System.Drawing.Size(414, 23);
            this.RefreshData.TabIndex = 4;
            this.RefreshData.Text = "Refresh Data";
            this.RefreshData.UseVisualStyleBackColor = true;
            this.RefreshData.Click += new System.EventHandler(this.RefreshData_Click);
            // 
            // BaseLabel
            // 
            this.BaseLabel.AutoSize = true;
            this.BaseLabel.Location = new System.Drawing.Point(13, 210);
            this.BaseLabel.Name = "BaseLabel";
            this.BaseLabel.Size = new System.Drawing.Size(50, 13);
            this.BaseLabel.TabIndex = 5;
            this.BaseLabel.Text = "Base File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "B File";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "C File";
            // 
            // BaseFilePath
            // 
            this.BaseFilePath.Location = new System.Drawing.Point(69, 207);
            this.BaseFilePath.Name = "BaseFilePath";
            this.BaseFilePath.Size = new System.Drawing.Size(276, 20);
            this.BaseFilePath.TabIndex = 8;
            // 
            // BaseFileBrowse
            // 
            this.BaseFileBrowse.Location = new System.Drawing.Point(352, 205);
            this.BaseFileBrowse.Name = "BaseFileBrowse";
            this.BaseFileBrowse.Size = new System.Drawing.Size(75, 23);
            this.BaseFileBrowse.TabIndex = 9;
            this.BaseFileBrowse.Text = "Browse";
            this.BaseFileBrowse.UseVisualStyleBackColor = true;
            this.BaseFileBrowse.Click += new System.EventHandler(this.BaseFileBrowse_Click);
            // 
            // BFileBrowse
            // 
            this.BFileBrowse.Location = new System.Drawing.Point(352, 235);
            this.BFileBrowse.Name = "BFileBrowse";
            this.BFileBrowse.Size = new System.Drawing.Size(75, 23);
            this.BFileBrowse.TabIndex = 11;
            this.BFileBrowse.Text = "Browse";
            this.BFileBrowse.UseVisualStyleBackColor = true;
            this.BFileBrowse.Click += new System.EventHandler(this.BFileBrowse_Click);
            // 
            // BFilePath
            // 
            this.BFilePath.Location = new System.Drawing.Point(69, 237);
            this.BFilePath.Name = "BFilePath";
            this.BFilePath.Size = new System.Drawing.Size(276, 20);
            this.BFilePath.TabIndex = 10;
            // 
            // CFileBrowse
            // 
            this.CFileBrowse.Location = new System.Drawing.Point(352, 261);
            this.CFileBrowse.Name = "CFileBrowse";
            this.CFileBrowse.Size = new System.Drawing.Size(75, 23);
            this.CFileBrowse.TabIndex = 13;
            this.CFileBrowse.Text = "Browse";
            this.CFileBrowse.UseVisualStyleBackColor = true;
            this.CFileBrowse.Click += new System.EventHandler(this.CFileBrowse_Click);
            // 
            // CFilePath
            // 
            this.CFilePath.Location = new System.Drawing.Point(69, 263);
            this.CFilePath.Name = "CFilePath";
            this.CFilePath.Size = new System.Drawing.Size(276, 20);
            this.CFilePath.TabIndex = 12;
            // 
            // SaveNameLabel
            // 
            this.SaveNameLabel.AutoSize = true;
            this.SaveNameLabel.Location = new System.Drawing.Point(13, 168);
            this.SaveNameLabel.Name = "SaveNameLabel";
            this.SaveNameLabel.Size = new System.Drawing.Size(63, 13);
            this.SaveNameLabel.TabIndex = 14;
            this.SaveNameLabel.Text = "Save Name";
            // 
            // txtSaveName
            // 
            this.txtSaveName.Location = new System.Drawing.Point(82, 165);
            this.txtSaveName.Name = "txtSaveName";
            this.txtSaveName.Size = new System.Drawing.Size(344, 20);
            this.txtSaveName.TabIndex = 15;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(16, 301);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(200, 23);
            this.Cancel.TabIndex = 16;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Import
            // 
            this.Import.Location = new System.Drawing.Point(227, 301);
            this.Import.Name = "Import";
            this.Import.Size = new System.Drawing.Size(200, 23);
            this.Import.TabIndex = 17;
            this.Import.Text = "Import";
            this.Import.UseVisualStyleBackColor = true;
            this.Import.Click += new System.EventHandler(this.Import_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            this.ofd.Filter = "Blossom Tales Saves|*.txt|All files|*.*";
            // 
            // ImportSaves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 333);
            this.Controls.Add(this.Import);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.txtSaveName);
            this.Controls.Add(this.SaveNameLabel);
            this.Controls.Add(this.CFileBrowse);
            this.Controls.Add(this.CFilePath);
            this.Controls.Add(this.BFileBrowse);
            this.Controls.Add(this.BFilePath);
            this.Controls.Add(this.BaseFileBrowse);
            this.Controls.Add(this.BaseFilePath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BaseLabel);
            this.Controls.Add(this.RefreshData);
            this.Controls.Add(this.FolderBrowse);
            this.Controls.Add(this.ImportFolderPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveGroup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(456, 371);
            this.MinimumSize = new System.Drawing.Size(456, 371);
            this.Name = "ImportSaves";
            this.Text = "Import Existing Save";
            this.Load += new System.EventHandler(this.ImportSaves_Load);
            this.SaveGroup.ResumeLayout(false);
            this.SaveGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox SaveGroup;
        private System.Windows.Forms.RadioButton Slot3;
        private System.Windows.Forms.RadioButton Slot2;
        private System.Windows.Forms.RadioButton Slot1;
        private System.Windows.Forms.FolderBrowserDialog fbd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ImportFolderPath;
        private System.Windows.Forms.Button FolderBrowse;
        private System.Windows.Forms.Button RefreshData;
        private System.Windows.Forms.Label BaseLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BaseFilePath;
        private System.Windows.Forms.Button BaseFileBrowse;
        private System.Windows.Forms.Button BFileBrowse;
        private System.Windows.Forms.TextBox BFilePath;
        private System.Windows.Forms.Button CFileBrowse;
        private System.Windows.Forms.TextBox CFilePath;
        private System.Windows.Forms.Label SaveNameLabel;
        private System.Windows.Forms.TextBox txtSaveName;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Import;
        private System.Windows.Forms.OpenFileDialog ofd;
    }
}