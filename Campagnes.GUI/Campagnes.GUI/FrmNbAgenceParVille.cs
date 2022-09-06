using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Campagnes.BLL;
using Campagnes.BO;

namespace Campagnes.GUI
{
    public partial class FrmNbAgenceParVille : Form
    {
        private AgenceManager agenceManager = new AgenceManager();
        public FrmNbAgenceParVille()
        {
            InitializeComponent();
            dgv();
        }
        private void dgv()
        {
            dgvAffichage.DataSource = agenceManager.GetNombreAgenceParVille();
            dgvAffichage.Columns["NomVille"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAffichage.Columns["Nbagence"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAffichage.Columns["Nbagence"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvAffichage.RowHeadersVisible = false;
            dgvAffichage.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAffichage.BackgroundColor = Color.White;
        }
    }
}
