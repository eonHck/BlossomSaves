namespace BlossomSaves
{
    partial class ConfigForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigForm));
            this.lblOrigSave = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.OrigSave = new System.Windows.Forms.TextBox();
            this.OrigSaveBrowse = new System.Windows.Forms.Button();
            this.ManagedSave = new System.Windows.Forms.TextBox();
            this.ManagedSaveBrowse = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOrigSave
            // 
            this.lblOrigSave.AutoSize = true;
            this.lblOrigSave.Location = new System.Drawing.Point(12, 9);
            this.lblOrigSave.Name = "lblOrigSave";
            this.lblOrigSave.Size = new System.Drawing.Size(148, 13);
            this.lblOrigSave.TabIndex = 0;
            this.lblOrigSave.Text = "Blossom Tales Save Directory";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Backup Save Directory";
            // 
            // OrigSave
            // 
            this.OrigSave.Location = new System.Drawing.Point(166, 6);
            this.OrigSave.Name = "OrigSave";
            this.OrigSave.Size = new System.Drawing.Size(287, 20);
            this.OrigSave.TabIndex = 2;
            // 
            // OrigSaveBrowse
            // 
            this.OrigSaveBrowse.Location = new System.Drawing.Point(459, 4);
            this.OrigSaveBrowse.Name = "OrigSaveBrowse";
            this.OrigSaveBrowse.Size = new System.Drawing.Size(75, 23);
            this.OrigSaveBrowse.TabIndex = 3;
            this.OrigSaveBrowse.Text = "Browse";
            this.OrigSaveBrowse.UseVisualStyleBackColor = true;
            this.OrigSaveBrowse.Click += new System.EventHandler(this.OrigSaveBrowse_Click);
            // 
            // ManagedSave
            // 
            this.ManagedSave.Location = new System.Drawing.Point(166, 34);
            this.ManagedSave.Name = "ManagedSave";
            this.ManagedSave.Size = new System.Drawing.Size(287, 20);
            this.ManagedSave.TabIndex = 4;
            // 
            // ManagedSaveBrowse
            // 
            this.ManagedSaveBrowse.Location = new System.Drawing.Point(459, 32);
            this.ManagedSaveBrowse.Name = "ManagedSaveBrowse";
            this.ManagedSaveBrowse.Size = new System.Drawing.Size(75, 23);
            this.ManagedSaveBrowse.TabIndex = 5;
            this.ManagedSaveBrowse.Text = "Browse";
            this.ManagedSaveBrowse.UseVisualStyleBackColor = true;
            this.ManagedSaveBrowse.Click += new System.EventHandler(this.ManagedSaveBrowse_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(166, 74);
            this.Cancel.MaximumSize = new System.Drawing.Size(75, 23);
            this.Cancel.MinimumSize = new System.Drawing.Size(75, 23);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 6;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(283, 74);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 7;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 107);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.ManagedSaveBrowse);
            this.Controls.Add(this.ManagedSave);
            this.Controls.Add(this.OrigSaveBrowse);
            this.Controls.Add(this.OrigSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOrigSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(556, 145);
            this.MinimumSize = new System.Drawing.Size(556, 145);
            this.Name = "ConfigForm";
            this.Text = "Blossom Saves Config";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrigSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog fbd;
        private System.Windows.Forms.TextBox OrigSave;
        private System.Windows.Forms.Button OrigSaveBrowse;
        private System.Windows.Forms.TextBox ManagedSave;
        private System.Windows.Forms.Button ManagedSaveBrowse;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Save;
    }
}