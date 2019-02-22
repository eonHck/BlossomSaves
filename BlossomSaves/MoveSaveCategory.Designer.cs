namespace BlossomSaves
{
    partial class MoveSaveCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoveSaveCategory));
            this.CategoryCombo = new System.Windows.Forms.ComboBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.MoveSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CategoryCombo
            // 
            this.CategoryCombo.FormattingEnabled = true;
            this.CategoryCombo.Location = new System.Drawing.Point(68, 10);
            this.CategoryCombo.MaximumSize = new System.Drawing.Size(251, 0);
            this.CategoryCombo.MinimumSize = new System.Drawing.Size(251, 0);
            this.CategoryCombo.Name = "CategoryCombo";
            this.CategoryCombo.Size = new System.Drawing.Size(251, 21);
            this.CategoryCombo.TabIndex = 0;
            this.CategoryCombo.SelectedIndexChanged += new System.EventHandler(this.CategoryCombo_SelectedIndexChanged);
            this.CategoryCombo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterKeyPress);
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(13, 13);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(49, 13);
            this.CategoryLabel.TabIndex = 1;
            this.CategoryLabel.Text = "Category";
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(16, 46);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(128, 23);
            this.Cancel.TabIndex = 2;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Move
            // 
            this.MoveSave.Location = new System.Drawing.Point(191, 46);
            this.MoveSave.Name = "Move";
            this.MoveSave.Size = new System.Drawing.Size(128, 23);
            this.MoveSave.TabIndex = 3;
            this.MoveSave.Text = "Move";
            this.MoveSave.UseVisualStyleBackColor = true;
            this.MoveSave.Click += new System.EventHandler(this.Move_Click);
            // 
            // MoveSaveCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 80);
            this.Controls.Add(this.MoveSave);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.CategoryCombo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(347, 118);
            this.MinimumSize = new System.Drawing.Size(347, 118);
            this.Name = "MoveSaveCategory";
            this.Text = "Move Save To Category";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CategoryCombo;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button MoveSave;
    }
}