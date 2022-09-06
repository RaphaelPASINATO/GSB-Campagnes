
namespace Campagnes.GUI
{
    partial class FrmConsulterCampagneParAgence
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
            this.cboAgence = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCampagne = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCampagne)).BeginInit();
            this.SuspendLayout();
            // 
            // cboAgence
            // 
            this.cboAgence.FormattingEnabled = true;
            this.cboAgence.Location = new System.Drawing.Point(257, 26);
            this.cboAgence.Name = "cboAgence";
            this.cboAgence.Size = new System.Drawing.Size(152, 21);
            this.cboAgence.TabIndex = 0;
            this.cboAgence.SelectionChangeCommitted += new System.EventHandler(this.cboAgence_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Agence";
            // 
            // dgvCampagne
            // 
            this.dgvCampagne.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCampagne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCampagne.Location = new System.Drawing.Point(12, 69);
            this.dgvCampagne.Name = "dgvCampagne";
            this.dgvCampagne.Size = new System.Drawing.Size(1189, 236);
            this.dgvCampagne.TabIndex = 2;
            // 
            // FrmConsulterCampagneParAgence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 336);
            this.Controls.Add(this.dgvCampagne);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboAgence);
            this.Name = "FrmConsulterCampagneParAgence";
            this.Text = "Liste des campagnes d\'une agence";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCampagne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboAgence;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCampagne;
    }
}