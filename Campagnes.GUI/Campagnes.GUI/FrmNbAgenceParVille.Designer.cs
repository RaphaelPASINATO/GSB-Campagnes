
namespace Campagnes.GUI
{
    partial class FrmNbAgenceParVille
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
            this.dgvAffichage = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAffichage)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAffichage
            // 
            this.dgvAffichage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAffichage.Location = new System.Drawing.Point(12, 12);
            this.dgvAffichage.Name = "dgvAffichage";
            this.dgvAffichage.Size = new System.Drawing.Size(386, 367);
            this.dgvAffichage.TabIndex = 0;
            // 
            // FrmNbAgenceParVille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 391);
            this.Controls.Add(this.dgvAffichage);
            this.Name = "FrmNbAgenceParVille";
            this.Text = "Nombre d\'agences par ville";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAffichage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAffichage;
    }
}