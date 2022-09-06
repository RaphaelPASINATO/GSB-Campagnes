using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Campagnes.BLL;

namespace Campagnes.GUI
{
    public partial class FrmImporterVille : Form
    {
        private VilleManager villeManager = new VilleManager();

        public FrmImporterVille()
        {
            InitializeComponent();
            ofgImporterFichier.Filter = "fichier csv (*.csv)|*.csv";
            ofgImporterFichier.InitialDirectory = "c:\\";
            ofgImporterFichier.FileName = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ofgImporterFichier.ShowDialog() == DialogResult.OK)
            {
                txtChemin.Text = ofgImporterFichier.FileName;
                //String nomFichier = ofgImporterFichier.FileName;
                //var reader = new StreamReader(File.OpenRead(nomFichier));


            }
        }

        private void btnImporter_Click(object sender, EventArgs e)
        {
            //string leFichier = txtChemin.Text;
            int cpt = 0;
            bool firstLine = true;
            var reader = new StreamReader(File.OpenRead(txtChemin.Text));
            while(!reader.EndOfStream)
            {
                if (firstLine == false)
                {
                    var line = reader.ReadLine();
                    var valeurs = line.Split(';');
                    string codeInsee = valeurs[0];
                    string nom = valeurs[1];
                    string arrondissement = valeurs[2];
                    string codePostal = valeurs[3];
                    int ret = villeManager.AjouterVille(codeInsee, nom, arrondissement, codePostal);
                    if (ret == 0)
                    {
                        cpt++;
                    }
                }
                firstLine = false;
            }
            MessageBox.Show("Importation terminée ("+ cpt+ " villes importées)", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
