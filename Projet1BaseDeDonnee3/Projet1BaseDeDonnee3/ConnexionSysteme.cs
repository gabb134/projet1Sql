using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1BaseDeDonnee3
{
    public partial class ConnexionSysteme : Form
    {
        public ConnexionSysteme()
        {
            InitializeComponent();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            SqlConnection maConnexion = new SqlConnection();
            SqlCommand maCommande;

            maConnexion.ConnectionString = Projet1BaseDeDonnee3.Properties.Settings.Default.BDVoyagesGuellehConnectionString; //maChaineDeConnexion;
            maConnexion.Open();
            
            string strRequeteNoTypeUSer = "select NoTypeUtilisteur from Utilisateur where NomUtilisateur='" + tbUtilisateur.Text + "' and MotDePasse ='" + tbMotDePasse.Text + "'";

            maCommande = new SqlCommand(strRequeteNoTypeUSer, maConnexion);

            dynamic dynNoTypeUser = maCommande.ExecuteScalar();

            string strNoTypeUser = Convert.ToString(dynNoTypeUser);

            if (strNoTypeUser == null)
            {
                MessageBox.Show("");
            }
            else
            {

            }

            maConnexion.Close();
        }
    }
}
