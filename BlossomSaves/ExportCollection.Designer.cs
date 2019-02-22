namespace BlossomSaves
{
    partial class ExportCollection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportCollection));
            this.ExportAllSaves = new System.Windows.Forms.CheckBox();
            this.CategoriesGroup = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listSelectedCats = new System.Windows.Forms.ListBox();
            this.RemoveAllCats = new System.Windows.Forms.Button();
            this.RemoveSelectedCat = new System.Windows.Forms.Button();
            this.AddSelectedCat = new System.Windows.Forms.Button();
            this.AddAllCats = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listAvailableCats = new System.Windows.Forms.ListBox();
            this.SavesGroup = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listSelectedSaves = new System.Windows.Forms.ListBox();
            this.RemoveAllSavesButton = new System.Windows.Forms.Button();
            this.RemoveSelectedSaveButton = new System.Windows.Forms.Button();
            this.AddSelectedSaveButton = new System.Windows.Forms.Button();
            this.AddAllSaveButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.listAvailableSaves = new System.Windows.Forms.ListBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.ExportButton = new System.Windows.Forms.Button();
            this.CategoriesGroup.SuspendLayout();
            this.SavesGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExportAllSaves
            // 
            this.ExportAllSaves.AutoSize = true;
            this.ExportAllSaves.Location = new System.Drawing.Point(13, 13);
            this.ExportAllSaves.Name = "ExportAllSaves";
            this.ExportAllSaves.Size = new System.Drawing.Size(103, 17);
            this.ExportAllSaves.TabIndex = 0;
            this.ExportAllSaves.Text = "Export All Saves";
            this.ExportAllSaves.UseVisualStyleBackColor = true;
            this.ExportAllSaves.CheckedChanged += new System.EventHandler(this.ExportAllSaves_CheckedChanged);
            // 
            // CategoriesGroup
            // 
            this.CategoriesGroup.Controls.Add(this.label2);
            this.CategoriesGroup.Controls.Add(this.listSelectedCats);
            this.CategoriesGroup.Controls.Add(this.RemoveAllCats);
            this.CategoriesGroup.Controls.Add(this.RemoveSelectedCat);
            this.CategoriesGroup.Controls.Add(this.AddSelectedCat);
            this.CategoriesGroup.Controls.Add(this.AddAllCats);
            this.CategoriesGroup.Controls.Add(this.label1);
            this.CategoriesGroup.Controls.Add(this.listAvailableCats);
            this.CategoriesGroup.Location = new System.Drawing.Point(12, 36);
            this.CategoriesGroup.Name = "CategoriesGroup";
            this.CategoriesGroup.Size = new System.Drawing.Size(712, 235);
            this.CategoriesGroup.TabIndex = 1;
            this.CategoriesGroup.TabStop = false;
            this.CategoriesGroup.Text = "Categories/Groups";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(395, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Selected Categories/Groups";
            // 
            // listSelectedCats
            // 
            this.listSelectedCats.FormattingEnabled = true;
            this.listSelectedCats.Location = new System.Drawing.Point(398, 36);
            this.listSelectedCats.Name = "listSelectedCats";
            this.listSelectedCats.Size = new System.Drawing.Size(304, 186);
            this.listSelectedCats.TabIndex = 6;
            // 
            // RemoveAllCats
            // 
            this.RemoveAllCats.Location = new System.Drawing.Point(316, 153);
            this.RemoveAllCats.Name = "RemoveAllCats";
            this.RemoveAllCats.Size = new System.Drawing.Size(75, 23);
            this.RemoveAllCats.TabIndex = 5;
            this.RemoveAllCats.Text = "<<";
            this.RemoveAllCats.UseVisualStyleBackColor = true;
            this.RemoveAllCats.Click += new System.EventHandler(this.RemoveAllCats_Click);
            // 
            // RemoveSelectedCat
            // 
            this.RemoveSelectedCat.Location = new System.Drawing.Point(317, 124);
            this.RemoveSelectedCat.Name = "RemoveSelectedCat";
            this.RemoveSelectedCat.Size = new System.Drawing.Size(75, 23);
            this.RemoveSelectedCat.TabIndex = 4;
            this.RemoveSelectedCat.Text = "<";
            this.RemoveSelectedCat.UseVisualStyleBackColor = true;
            this.RemoveSelectedCat.Click += new System.EventHandler(this.RemoveSelectedCat_Click);
            // 
            // AddSelectedCat
            // 
            this.AddSelectedCat.Location = new System.Drawing.Point(317, 95);
            this.AddSelectedCat.Name = "AddSelectedCat";
            this.AddSelectedCat.Size = new System.Drawing.Size(75, 23);
            this.AddSelectedCat.TabIndex = 3;
            this.AddSelectedCat.Text = ">";
            this.AddSelectedCat.UseVisualStyleBackColor = true;
            this.AddSelectedCat.Click += new System.EventHandler(this.AddSelectedCat_Click);
            // 
            // AddAllCats
            // 
            this.AddAllCats.Location = new System.Drawing.Point(317, 66);
            this.AddAllCats.Name = "AddAllCats";
            this.AddAllCats.Size = new System.Drawing.Size(75, 23);
            this.AddAllCats.TabIndex = 2;
            this.AddAllCats.Text = ">>";
            this.AddAllCats.UseVisualStyleBackColor = true;
            this.AddAllCats.Click += new System.EventHandler(this.AddAllCats_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Available Categories/Groups";
            // 
            // listAvailableCats
            // 
            this.listAvailableCats.FormattingEnabled = true;
            this.listAvailableCats.Location = new System.Drawing.Point(6, 36);
            this.listAvailableCats.Name = "listAvailableCats";
            this.listAvailableCats.Size = new System.Drawing.Size(304, 186);
            this.listAvailableCats.TabIndex = 0;
            // 
            // SavesGroup
            // 
            this.SavesGroup.Controls.Add(this.label3);
            this.SavesGroup.Controls.Add(this.listSelectedSaves);
            this.SavesGroup.Controls.Add(this.RemoveAllSavesButton);
            this.SavesGroup.Controls.Add(this.RemoveSelectedSaveButton);
            this.SavesGroup.Controls.Add(this.AddSelectedSaveButton);
            this.SavesGroup.Controls.Add(this.AddAllSaveButton);
            this.SavesGroup.Controls.Add(this.label4);
            this.SavesGroup.Controls.Add(this.listAvailableSaves);
            this.SavesGroup.Location = new System.Drawing.Point(12, 278);
            this.SavesGroup.Name = "SavesGroup";
            this.SavesGroup.Size = new System.Drawing.Size(712, 343);
            this.SavesGroup.TabIndex = 2;
            this.SavesGroup.TabStop = false;
            this.SavesGroup.Text = "Saves";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(395, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Selected Saves";
            // 
            // listSelectedSaves
            // 
            this.listSelectedSaves.FormattingEnabled = true;
            this.listSelectedSaves.Location = new System.Drawing.Point(398, 40);
            this.listSelectedSaves.Name = "listSelectedSaves";
            this.listSelectedSaves.Size = new System.Drawing.Size(304, 290);
            this.listSelectedSaves.TabIndex = 14;
            // 
            // RemoveAllSavesButton
            // 
            this.RemoveAllSavesButton.Location = new System.Drawing.Point(316, 157);
            this.RemoveAllSavesButton.Name = "RemoveAllSavesButton";
            this.RemoveAllSavesButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveAllSavesButton.TabIndex = 13;
            this.RemoveAllSavesButton.Text = "<<";
            this.RemoveAllSavesButton.UseVisualStyleBackColor = true;
            this.RemoveAllSavesButton.Click += new System.EventHandler(this.RemoveAllSavesButton_Click);
            // 
            // RemoveSelectedSaveButton
            // 
            this.RemoveSelectedSaveButton.Location = new System.Drawing.Point(317, 128);
            this.RemoveSelectedSaveButton.Name = "RemoveSelectedSaveButton";
            this.RemoveSelectedSaveButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveSelectedSaveButton.TabIndex = 12;
            this.RemoveSelectedSaveButton.Text = "<";
            this.RemoveSelectedSaveButton.UseVisualStyleBackColor = true;
            this.RemoveSelectedSaveButton.Click += new System.EventHandler(this.RemoveSelectedSaveButton_Click);
            // 
            // AddSelectedSaveButton
            // 
            this.AddSelectedSaveButton.Location = new System.Drawing.Point(317, 99);
            this.AddSelectedSaveButton.Name = "AddSelectedSaveButton";
            this.AddSelectedSaveButton.Size = new System.Drawing.Size(75, 23);
            this.AddSelectedSaveButton.TabIndex = 11;
            this.AddSelectedSaveButton.Text = ">";
            this.AddSelectedSaveButton.UseVisualStyleBackColor = true;
            this.AddSelectedSaveButton.Click += new System.EventHandler(this.AddSelectedSaveButton_Click);
            // 
            // AddAllSaveButton
            // 
            this.AddAllSaveButton.Location = new System.Drawing.Point(317, 70);
            this.AddAllSaveButton.Name = "AddAllSaveButton";
            this.AddAllSaveButton.Size = new System.Drawing.Size(75, 23);
            this.AddAllSaveButton.TabIndex = 10;
            this.AddAllSaveButton.Text = ">>";
            this.AddAllSaveButton.UseVisualStyleBackColor = true;
            this.AddAllSaveButton.Click += new System.EventHandler(this.AddAllSaveButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Available Saves";
            // 
            // listAvailableSaves
            // 
            this.listAvailableSaves.FormattingEnabled = true;
            this.listAvailableSaves.Location = new System.Drawing.Point(6, 40);
            this.listAvailableSaves.Name = "listAvailableSaves";
            this.listAvailableSaves.Size = new System.Drawing.Size(304, 290);
            this.listAvailableSaves.TabIndex = 8;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(410, 628);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(138, 23);
            this.Cancel.TabIndex = 3;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // ExportButton
            // 
            this.ExportButton.Location = new System.Drawing.Point(576, 628);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(138, 23);
            this.ExportButton.TabIndex = 4;
            this.ExportButton.Text = "Export";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // ExportCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 659);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.SavesGroup);
            this.Controls.Add(this.CategoriesGroup);
            this.Controls.Add(this.ExportAllSaves);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(750, 697);
            this.MinimumSize = new System.Drawing.Size(750, 697);
            this.Name = "ExportCollection";
            this.Text = "Export Save Collection";
            this.CategoriesGroup.ResumeLayout(false);
            this.CategoriesGroup.PerformLayout();
            this.SavesGroup.ResumeLayout(false);
            this.SavesGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ExportAllSaves;
        private System.Windows.Forms.GroupBox CategoriesGroup;
        private System.Windows.Forms.Button AddSelectedCat;
        private System.Windows.Forms.Button AddAllCats;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listAvailableCats;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listSelectedCats;
        private System.Windows.Forms.Button RemoveAllCats;
        private System.Windows.Forms.Button RemoveSelectedCat;
        private System.Windows.Forms.GroupBox SavesGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listSelectedSaves;
        private System.Windows.Forms.Button RemoveAllSavesButton;
        private System.Windows.Forms.Button RemoveSelectedSaveButton;
        private System.Windows.Forms.Button AddSelectedSaveButton;
        private System.Windows.Forms.Button AddAllSaveButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listAvailableSaves;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button ExportButton;
    }
}