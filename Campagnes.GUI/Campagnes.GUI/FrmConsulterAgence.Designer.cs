
namespace Campagnes.GUI
{
    partial class FrmConsulterAgence
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
            this.dgvConsulter = new System.Windows.Forms.DataGridView();
            this.btnFermer = new System.Windows.Forms.Button();
            this.chkBoxComm = new System.Windows.Forms.CheckBox();
            this.chkBoxArt = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulter)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Liste agence";
            // 
            // dgvConsulter
            // 
            this.dgvConsulter.BackgroundColor = System.Drawing.Color.White;
            this.dgvConsulter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulter.Location = new System.Drawing.Point(57, 96);
            this.dgvConsulter.Name = "dgvConsulter";
            this.dgvConsulter.Size = new System.Drawing.Size(865, 273);
            this.dgvConsulter.TabIndex = 1;
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(620, 380);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(75, 23);
            this.btnFermer.TabIndex = 2;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // chkBoxComm
            // 
            this.chkBoxComm.AutoSize = true;
            this.chkBoxComm.Location = new System.Drawing.Point(361, 65);
            this.chkBoxComm.Name = "chkBoxComm";
            this.chkBoxComm.Size = new System.Drawing.Size(98, 17);
            this.chkBoxComm.TabIndex = 3;
            this.chkBoxComm.Text = "Communication";
            this.chkBoxComm.UseVisualStyleBackColor = true;
            this.chkBoxComm.CheckedChanged += new System.EventHandler(this.chkBoxComm_CheckedChanged);
            // 
            // chkBoxArt
            // 
            this.chkBoxArt.AutoSize = true;
            this.chkBoxArt.Location = new System.Drawing.Point(465, 65);
            this.chkBoxArt.Name = "chkBoxArt";
            this.chkBoxArt.Size = new System.Drawing.Size(69, 17);
            this.chkBoxArt.TabIndex = 4;
            this.chkBoxArt.Text = "Artistique";
            this.chkBoxArt.UseVisualStyleBackColor = true;
            this.chkBoxArt.CheckedChanged += new System.EventHandler(this.chkBoxArt_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Spécialité :";
            // 
            // FrmConsulterAgence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 588);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkBoxArt);
            this.Controls.Add(this.chkBoxComm);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.dgvConsulter);
            this.Controls.Add(this.label1);
            this.Name = "FrmConsulterAgence";
            this.Text = "Liste des agences";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvConsulter;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.CheckBox chkBoxComm;
        private System.Windows.Forms.CheckBox chkBoxArt;
        private System.Windows.Forms.Label label2;
    }
}