namespace BlossomSaves
{
    partial class BlossomSaves
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlossomSaves));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listCategories = new System.Windows.Forms.ListBox();
            this.grpCategory = new System.Windows.Forms.GroupBox();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnCategoryDown = new System.Windows.Forms.Button();
            this.btnCategoryUp = new System.Windows.Forms.Button();
            this.btnRenameCategory = new System.Windows.Forms.Button();
            this.btnNewCategory = new System.Windows.Forms.Button();
            this.grpSaveStates = new System.Windows.Forms.GroupBox();
            this.MoveToCategory = new System.Windows.Forms.Button();
            this.CopyToCategory = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LoadSelectedSave = new System.Windows.Forms.Button();
            this.Load3 = new System.Windows.Forms.RadioButton();
            this.Load2 = new System.Windows.Forms.RadioButton();
            this.Load1 = new System.Windows.Forms.RadioButton();
            this.DeleteSave = new System.Windows.Forms.Button();
            this.MoveDownSave = new System.Windows.Forms.Button();
            this.MoveUpSave = new System.Windows.Forms.Button();
            this.RenameSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ImportExistingSave = new System.Windows.Forms.Button();
            this.SaveCurrentGameState = new System.Windows.Forms.Button();
            this.Save3 = new System.Windows.Forms.RadioButton();
            this.Save2 = new System.Windows.Forms.RadioButton();
            this.Save1 = new System.Windows.Forms.RadioButton();
            this.listSaveStates = new System.Windows.Forms.ListBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exportSavesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importSavesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutBlossomSavesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.grpCategory.SuspendLayout();
            this.grpSaveStates.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(873, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configToolStripMenuItem,
            this.toolStripSeparator1,
            this.exportSavesToolStripMenuItem,
            this.importSavesToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.Name = "configToolStripMenuItem";
            this.configToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.configToolStripMenuItem.Text = "Config";
            this.configToolStripMenuItem.Click += new System.EventHandler(this.ConfigToolStripMenuItem_Click);
            // 
            // listCategories
            // 
            this.listCategories.FormattingEnabled = true;
            this.listCategories.Location = new System.Drawing.Point(6, 19);
            this.listCategories.Name = "listCategories";
            this.listCategories.Size = new System.Drawing.Size(208, 368);
            this.listCategories.TabIndex = 1;
            this.listCategories.SelectedIndexChanged += new System.EventHandler(this.listCategories_SelectedIndexChanged);
            // 
            // grpCategory
            // 
            this.grpCategory.Controls.Add(this.btnDeleteCategory);
            this.grpCategory.Controls.Add(this.btnCategoryDown);
            this.grpCategory.Controls.Add(this.btnCategoryUp);
            this.grpCategory.Controls.Add(this.btnRenameCategory);
            this.grpCategory.Controls.Add(this.btnNewCategory);
            this.grpCategory.Controls.Add(this.listCategories);
            this.grpCategory.Location = new System.Drawing.Point(12, 27);
            this.grpCategory.Name = "grpCategory";
            this.grpCategory.Size = new System.Drawing.Size(347, 396);
            this.grpCategory.TabIndex = 12;
            this.grpCategory.TabStop = false;
            this.grpCategory.Text = "Category/Group";
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Location = new System.Drawing.Point(221, 140);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(118, 23);
            this.btnDeleteCategory.TabIndex = 6;
            this.btnDeleteCategory.Text = "Delete";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // btnCategoryDown
            // 
            this.btnCategoryDown.Location = new System.Drawing.Point(221, 110);
            this.btnCategoryDown.Name = "btnCategoryDown";
            this.btnCategoryDown.Size = new System.Drawing.Size(118, 23);
            this.btnCategoryDown.TabIndex = 5;
            this.btnCategoryDown.Text = "Move Down";
            this.btnCategoryDown.UseVisualStyleBackColor = true;
            this.btnCategoryDown.Click += new System.EventHandler(this.btnCategoryDown_Click);
            // 
            // btnCategoryUp
            // 
            this.btnCategoryUp.Location = new System.Drawing.Point(221, 80);
            this.btnCategoryUp.Name = "btnCategoryUp";
            this.btnCategoryUp.Size = new System.Drawing.Size(118, 23);
            this.btnCategoryUp.TabIndex = 4;
            this.btnCategoryUp.Text = "Move Up";
            this.btnCategoryUp.UseVisualStyleBackColor = true;
            this.btnCategoryUp.Click += new System.EventHandler(this.btnCategoryUp_Click);
            // 
            // btnRenameCategory
            // 
            this.btnRenameCategory.Location = new System.Drawing.Point(221, 50);
            this.btnRenameCategory.Name = "btnRenameCategory";
            this.btnRenameCategory.Size = new System.Drawing.Size(118, 23);
            this.btnRenameCategory.TabIndex = 3;
            this.btnRenameCategory.Text = "Rename";
            this.btnRenameCategory.UseVisualStyleBackColor = true;
            this.btnRenameCategory.Click += new System.EventHandler(this.btnRenameCategory_Click);
            // 
            // btnNewCategory
            // 
            this.btnNewCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNewCategory.Location = new System.Drawing.Point(221, 20);
            this.btnNewCategory.Name = "btnNewCategory";
            this.btnNewCategory.Size = new System.Drawing.Size(118, 23);
            this.btnNewCategory.TabIndex = 2;
            this.btnNewCategory.Text = "New Category/Group";
            this.btnNewCategory.UseVisualStyleBackColor = true;
            this.btnNewCategory.Click += new System.EventHandler(this.BtnNewCategory_Click);
            // 
            // grpSaveStates
            // 
            this.grpSaveStates.Controls.Add(this.MoveToCategory);
            this.grpSaveStates.Controls.Add(this.CopyToCategory);
            this.grpSaveStates.Controls.Add(this.groupBox2);
            this.grpSaveStates.Controls.Add(this.DeleteSave);
            this.grpSaveStates.Controls.Add(this.MoveDownSave);
            this.grpSaveStates.Controls.Add(this.MoveUpSave);
            this.grpSaveStates.Controls.Add(this.RenameSave);
            this.grpSaveStates.Controls.Add(this.groupBox1);
            this.grpSaveStates.Controls.Add(this.listSaveStates);
            this.grpSaveStates.Location = new System.Drawing.Point(365, 27);
            this.grpSaveStates.Name = "grpSaveStates";
            this.grpSaveStates.Size = new System.Drawing.Size(499, 395);
            this.grpSaveStates.TabIndex = 13;
            this.grpSaveStates.TabStop = false;
            this.grpSaveStates.Text = "Saves";
            // 
            // MoveToCategory
            // 
            this.MoveToCategory.Location = new System.Drawing.Point(329, 245);
            this.MoveToCategory.Name = "MoveToCategory";
            this.MoveToCategory.Size = new System.Drawing.Size(160, 23);
            this.MoveToCategory.TabIndex = 8;
            this.MoveToCategory.Text = "Move to Category";
            this.MoveToCategory.UseVisualStyleBackColor = true;
            this.MoveToCategory.Click += new System.EventHandler(this.MoveToCategory_Click);
            // 
            // CopyToCategory
            // 
            this.CopyToCategory.Location = new System.Drawing.Point(329, 216);
            this.CopyToCategory.Name = "CopyToCategory";
            this.CopyToCategory.Size = new System.Drawing.Size(160, 23);
            this.CopyToCategory.TabIndex = 7;
            this.CopyToCategory.Text = "Copy to Category";
            this.CopyToCategory.UseVisualStyleBackColor = true;
            this.CopyToCategory.Click += new System.EventHandler(this.CopyToCategory_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LoadSelectedSave);
            this.groupBox2.Controls.Add(this.Load3);
            this.groupBox2.Controls.Add(this.Load2);
            this.groupBox2.Controls.Add(this.Load1);
            this.groupBox2.Location = new System.Drawing.Point(330, 301);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(160, 86);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Save Slot";
            // 
            // LoadSelectedSave
            // 
            this.LoadSelectedSave.Location = new System.Drawing.Point(7, 50);
            this.LoadSelectedSave.Name = "LoadSelectedSave";
            this.LoadSelectedSave.Size = new System.Drawing.Size(144, 23);
            this.LoadSelectedSave.TabIndex = 7;
            this.LoadSelectedSave.Text = "Load Selected Save";
            this.LoadSelectedSave.UseVisualStyleBackColor = true;
            this.LoadSelectedSave.Click += new System.EventHandler(this.LoadSelectedSave_Click);
            // 
            // Load3
            // 
            this.Load3.AutoSize = true;
            this.Load3.Location = new System.Drawing.Point(121, 27);
            this.Load3.Name = "Load3";
            this.Load3.Size = new System.Drawing.Size(31, 17);
            this.Load3.TabIndex = 6;
            this.Load3.TabStop = true;
            this.Load3.Text = "3";
            this.Load3.UseVisualStyleBackColor = true;
            this.Load3.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // Load2
            // 
            this.Load2.AutoSize = true;
            this.Load2.Location = new System.Drawing.Point(64, 27);
            this.Load2.Name = "Load2";
            this.Load2.Size = new System.Drawing.Size(31, 17);
            this.Load2.TabIndex = 5;
            this.Load2.TabStop = true;
            this.Load2.Text = "2";
            this.Load2.UseVisualStyleBackColor = true;
            this.Load2.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // Load1
            // 
            this.Load1.AutoSize = true;
            this.Load1.Checked = true;
            this.Load1.Location = new System.Drawing.Point(8, 27);
            this.Load1.Name = "Load1";
            this.Load1.Size = new System.Drawing.Size(31, 17);
            this.Load1.TabIndex = 4;
            this.Load1.TabStop = true;
            this.Load1.Text = "1";
            this.Load1.UseVisualStyleBackColor = true;
            this.Load1.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // DeleteSave
            // 
            this.DeleteSave.Location = new System.Drawing.Point(330, 274);
            this.DeleteSave.Name = "DeleteSave";
            this.DeleteSave.Size = new System.Drawing.Size(160, 23);
            this.DeleteSave.TabIndex = 5;
            this.DeleteSave.Text = "Delete";
            this.DeleteSave.UseVisualStyleBackColor = true;
            this.DeleteSave.Click += new System.EventHandler(this.DeleteSave_Click);
            // 
            // MoveDownSave
            // 
            this.MoveDownSave.Location = new System.Drawing.Point(329, 187);
            this.MoveDownSave.Name = "MoveDownSave";
            this.MoveDownSave.Size = new System.Drawing.Size(160, 23);
            this.MoveDownSave.TabIndex = 4;
            this.MoveDownSave.Text = "Move Down";
            this.MoveDownSave.UseVisualStyleBackColor = true;
            this.MoveDownSave.Click += new System.EventHandler(this.MoveDownSave_Click);
            // 
            // MoveUpSave
            // 
            this.MoveUpSave.Location = new System.Drawing.Point(329, 158);
            this.MoveUpSave.Name = "MoveUpSave";
            this.MoveUpSave.Size = new System.Drawing.Size(160, 23);
            this.MoveUpSave.TabIndex = 3;
            this.MoveUpSave.Text = "Move Up";
            this.MoveUpSave.UseVisualStyleBackColor = true;
            this.MoveUpSave.Click += new System.EventHandler(this.MoveUpSave_Click);
            // 
            // RenameSave
            // 
            this.RenameSave.Location = new System.Drawing.Point(330, 129);
            this.RenameSave.Name = "RenameSave";
            this.RenameSave.Size = new System.Drawing.Size(160, 23);
            this.RenameSave.TabIndex = 2;
            this.RenameSave.Text = "Rename";
            this.RenameSave.UseVisualStyleBackColor = true;
            this.RenameSave.Click += new System.EventHandler(this.RenameSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ImportExistingSave);
            this.groupBox1.Controls.Add(this.SaveCurrentGameState);
            this.groupBox1.Controls.Add(this.Save3);
            this.groupBox1.Controls.Add(this.Save2);
            this.groupBox1.Controls.Add(this.Save1);
            this.groupBox1.Location = new System.Drawing.Point(330, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 103);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Save Slot";
            // 
            // ImportExistingSave
            // 
            this.ImportExistingSave.Location = new System.Drawing.Point(7, 72);
            this.ImportExistingSave.Name = "ImportExistingSave";
            this.ImportExistingSave.Size = new System.Drawing.Size(144, 23);
            this.ImportExistingSave.TabIndex = 4;
            this.ImportExistingSave.Text = "Import Existing Save";
            this.ImportExistingSave.UseVisualStyleBackColor = true;
            this.ImportExistingSave.Click += new System.EventHandler(this.ImportExistingSave_Click);
            // 
            // SaveCurrentGameState
            // 
            this.SaveCurrentGameState.Location = new System.Drawing.Point(7, 44);
            this.SaveCurrentGameState.Name = "SaveCurrentGameState";
            this.SaveCurrentGameState.Size = new System.Drawing.Size(144, 23);
            this.SaveCurrentGameState.TabIndex = 3;
            this.SaveCurrentGameState.Text = "Save Current Game State";
            this.SaveCurrentGameState.UseVisualStyleBackColor = true;
            this.SaveCurrentGameState.Click += new System.EventHandler(this.SaveCurrentGameState_Click);
            // 
            // Save3
            // 
            this.Save3.AutoSize = true;
            this.Save3.Location = new System.Drawing.Point(120, 20);
            this.Save3.Name = "Save3";
            this.Save3.Size = new System.Drawing.Size(31, 17);
            this.Save3.TabIndex = 2;
            this.Save3.Text = "3";
            this.Save3.UseVisualStyleBackColor = true;
            this.Save3.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // Save2
            // 
            this.Save2.AutoSize = true;
            this.Save2.Location = new System.Drawing.Point(63, 20);
            this.Save2.Name = "Save2";
            this.Save2.Size = new System.Drawing.Size(31, 17);
            this.Save2.TabIndex = 1;
            this.Save2.TabStop = true;
            this.Save2.Text = "2";
            this.Save2.UseVisualStyleBackColor = true;
            this.Save2.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // Save1
            // 
            this.Save1.AutoSize = true;
            this.Save1.Checked = true;
            this.Save1.Location = new System.Drawing.Point(7, 20);
            this.Save1.Name = "Save1";
            this.Save1.Size = new System.Drawing.Size(31, 17);
            this.Save1.TabIndex = 0;
            this.Save1.TabStop = true;
            this.Save1.Text = "1";
            this.Save1.UseVisualStyleBackColor = true;
            this.Save1.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // listSaveStates
            // 
            this.listSaveStates.FormattingEnabled = true;
            this.listSaveStates.Location = new System.Drawing.Point(6, 19);
            this.listSaveStates.Name = "listSaveStates";
            this.listSaveStates.Size = new System.Drawing.Size(317, 368);
            this.listSaveStates.TabIndex = 0;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(191, 6);
            // 
            // exportSavesToolStripMenuItem
            // 
            this.exportSavesToolStripMenuItem.Name = "exportSavesToolStripMenuItem";
            this.exportSavesToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.exportSavesToolStripMenuItem.Text = "Export Save Collection";
            this.exportSavesToolStripMenuItem.Click += new System.EventHandler(this.exportSavesToolStripMenuItem_Click);
            // 
            // importSavesToolStripMenuItem
            // 
            this.importSavesToolStripMenuItem.Name = "importSavesToolStripMenuItem";
            this.importSavesToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.importSavesToolStripMenuItem.Text = "Import Save Collection";
            this.importSavesToolStripMenuItem.Click += new System.EventHandler(this.importSavesToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(191, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutBlossomSavesToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutBlossomSavesToolStripMenuItem
            // 
            this.aboutBlossomSavesToolStripMenuItem.Name = "aboutBlossomSavesToolStripMenuItem";
            this.aboutBlossomSavesToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.aboutBlossomSavesToolStripMenuItem.Text = "About Blossom Saves";
            this.aboutBlossomSavesToolStripMenuItem.Click += new System.EventHandler(this.aboutBlossomSavesToolStripMenuItem_Click);
            // 
            // BlossomSaves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 435);
            this.Controls.Add(this.grpSaveStates);
            this.Controls.Add(this.grpCategory);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(889, 473);
            this.MinimumSize = new System.Drawing.Size(889, 473);
            this.Name = "BlossomSaves";
            this.Text = "Blossom Saves";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BlossomSaves_FormClosing);
            this.Load += new System.EventHandler(this.BlossomSaves_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpCategory.ResumeLayout(false);
            this.grpSaveStates.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
        private System.Windows.Forms.ListBox listCategories;
        private System.Windows.Forms.GroupBox grpCategory;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnCategoryDown;
        private System.Windows.Forms.Button btnCategoryUp;
        private System.Windows.Forms.Button btnRenameCategory;
        private System.Windows.Forms.Button btnNewCategory;
        private System.Windows.Forms.GroupBox grpSaveStates;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button LoadSelectedSave;
        private System.Windows.Forms.RadioButton Load3;
        private System.Windows.Forms.RadioButton Load2;
        private System.Windows.Forms.RadioButton Load1;
        private System.Windows.Forms.Button DeleteSave;
        private System.Windows.Forms.Button MoveDownSave;
        private System.Windows.Forms.Button MoveUpSave;
        private System.Windows.Forms.Button RenameSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SaveCurrentGameState;
        private System.Windows.Forms.RadioButton Save3;
        private System.Windows.Forms.RadioButton Save2;
        private System.Windows.Forms.RadioButton Save1;
        private System.Windows.Forms.ListBox listSaveStates;
        private System.Windows.Forms.Button ImportExistingSave;
        private System.Windows.Forms.Button MoveToCategory;
        private System.Windows.Forms.Button CopyToCategory;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exportSavesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importSavesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutBlossomSavesToolStripMenuItem;
    }
}

