
namespace Campagnes.GUI
{
    partial class FrmConsulterArtiste
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
            this.cboListeArtiste = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvArtiste = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtiste)).BeginInit();
            this.SuspendLayout();
            // 
            // cboListeArtiste
            // 
            this.cboListeArtiste.FormattingEnabled = true;
            this.cboListeArtiste.Location = new System.Drawing.Point(343, 92);
            this.cboListeArtiste.Name = "cboListeArtiste";
            this.cboListeArtiste.Size = new System.Drawing.Size(121, 21);
            this.cboListeArtiste.TabIndex = 0;
            this.cboListeArtiste.SelectionChangeCommitted += new System.EventHandler(this.cboListeArtiste_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "liste des courants artistiques";
            // 
            // dgvArtiste
            // 
            this.dgvArtiste.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvArtiste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtiste.GridColor = System.Drawing.SystemColors.Control;
            this.dgvArtiste.Location = new System.Drawing.Point(152, 186);
            this.dgvArtiste.Name = "dgvArtiste";
            this.dgvArtiste.Size = new System.Drawing.Size(487, 224);
            this.dgvArtiste.TabIndex = 2;
            // 
            // FrmConsulterArtiste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 539);
            this.Controls.Add(this.dgvArtiste);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboListeArtiste);
            this.Name = "FrmConsulterArtiste";
            this.Text = "Liste des artistes d\'un courant artistique";
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtiste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboListeArtiste;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvArtiste;
    }
}