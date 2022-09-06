
namespace Campagnes.GUI
{
    partial class FrmConsultationEvenementsParCampagne
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboCampagne = new System.Windows.Forms.ComboBox();
            this.dvgEvenement = new System.Windows.Forms.DataGridView();
            this.btnFermer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgEvenement)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Campagne";
            // 
            // cboCampagne
            // 
            this.cboCampagne.FormattingEnabled = true;
            this.cboCampagne.Location = new System.Drawing.Point(150, 24);
            this.cboCampagne.Name = "cboCampagne";
            this.cboCampagne.Size = new System.Drawing.Size(595, 21);
            this.cboCampagne.TabIndex = 2;
            this.cboCampagne.SelectionChangeCommitted += new System.EventHandler(this.cboCampagne_SelectionChangeCommitted);
            // 
            // dvgEvenement
            // 
            this.dvgEvenement.AllowUserToAddRows = false;
            this.dvgEvenement.AllowUserToDeleteRows = false;
            this.dvgEvenement.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvgEvenement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgEvenement.Location = new System.Drawing.Point(12, 66);
            this.dvgEvenement.Name = "dvgEvenement";
            this.dvgEvenement.ReadOnly = true;
            this.dvgEvenement.Size = new System.Drawing.Size(769, 311);
            this.dvgEvenement.TabIndex = 5;
            // 
            // btnFermer
            // 
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.Location = new System.Drawing.Point(229, 383);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(275, 55);
            this.btnFermer.TabIndex = 6;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // FrmConsultationEvenementsParCampagne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.dvgEvenement);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboCampagne);
            this.Name = "FrmConsultationEvenementsParCampagne";
            this.Text = "Liste des évènements d\'une campagne";
            ((System.ComponentModel.ISupportInitialize)(this.dvgEvenement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCampagne;
        private System.Windows.Forms.DataGridView dvgEvenement;
        private System.Windows.Forms.Button btnFermer;
    }
}