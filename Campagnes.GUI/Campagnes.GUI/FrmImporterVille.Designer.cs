
namespace Campagnes.GUI
{
    partial class FrmImporterVille
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
            this.txtChemin = new System.Windows.Forms.TextBox();
            this.btnChemin = new System.Windows.Forms.Button();
            this.ofgImporterFichier = new System.Windows.Forms.OpenFileDialog();
            this.btnImporter = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtChemin
            // 
            this.txtChemin.Location = new System.Drawing.Point(197, 77);
            this.txtChemin.Name = "txtChemin";
            this.txtChemin.Size = new System.Drawing.Size(382, 20);
            this.txtChemin.TabIndex = 0;
            // 
            // btnChemin
            // 
            this.btnChemin.Location = new System.Drawing.Point(594, 74);
            this.btnChemin.Name = "btnChemin";
            this.btnChemin.Size = new System.Drawing.Size(75, 23);
            this.btnChemin.TabIndex = 1;
            this.btnChemin.Text = "...";
            this.btnChemin.UseVisualStyleBackColor = true;
            this.btnChemin.Click += new System.EventHandler(this.button1_Click);
            // 
            // ofgImporterFichier
            // 
            this.ofgImporterFichier.FileName = "openFileDialog1";
            // 
            // btnImporter
            // 
            this.btnImporter.Location = new System.Drawing.Point(356, 155);
            this.btnImporter.Name = "btnImporter";
            this.btnImporter.Size = new System.Drawing.Size(75, 23);
            this.btnImporter.TabIndex = 2;
            this.btnImporter.Text = "Importer";
            this.btnImporter.UseVisualStyleBackColor = true;
            this.btnImporter.Click += new System.EventHandler(this.btnImporter_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(356, 214);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 3;
            this.btnQuitter.Text = "Fermer";
            this.btnQuitter.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Importer le fichier csv contenant les villes";
            // 
            // FrmImporterVille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 276);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnImporter);
            this.Controls.Add(this.btnChemin);
            this.Controls.Add(this.txtChemin);
            this.Name = "FrmImporterVille";
            this.Text = "Importer les villes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtChemin;
        private System.Windows.Forms.Button btnChemin;
        private System.Windows.Forms.OpenFileDialog ofgImporterFichier;
        private System.Windows.Forms.Button btnImporter;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Label label1;
    }
}