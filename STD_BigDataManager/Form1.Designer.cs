namespace STD_BigDataManager
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnImportData = new System.Windows.Forms.Button();
            this.ofdImportFile = new System.Windows.Forms.OpenFileDialog();
            this.lbPassword = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BtnImportData
            // 
            this.BtnImportData.Location = new System.Drawing.Point(12, 12);
            this.BtnImportData.Name = "BtnImportData";
            this.BtnImportData.Size = new System.Drawing.Size(776, 23);
            this.BtnImportData.TabIndex = 0;
            this.BtnImportData.Text = "Import data";
            this.BtnImportData.UseVisualStyleBackColor = true;
            this.BtnImportData.Click += new System.EventHandler(this.BtnImportData_Click);
            // 
            // ofdImportFile
            // 
            this.ofdImportFile.FileName = "ofdImportFile";
            // 
            // lbPassword
            // 
            this.lbPassword.FormattingEnabled = true;
            this.lbPassword.Location = new System.Drawing.Point(12, 41);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(394, 238);
            this.lbPassword.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.BtnImportData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnImportData;
        private System.Windows.Forms.OpenFileDialog ofdImportFile;
        private System.Windows.Forms.ListBox lbPassword;
    }
}

