﻿using System;
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


            if (tbUtilisateur.Text =="" && tbMotDePasse.Text == "")
            {
                MessageBox.Show("Vous devez inserer un utilisateur et un mot de passe pour continuer");
            }
            
            else if(tbUtilisateur.Text == "" )
            {
                MessageBox.Show("Vous devez inserer un utilisateur pour continuer");
            }
            else if(tbMotDePasse.Text == "")
            {
                MessageBox.Show("Vous devez inserer un mot de passe pour continuer");
            if (strNoTypeUser == null)
            {
                MessageBox.Show("");
            }
            else
            {

            }
<<<<<<< HEAD

=======
>>>>>>> 66104c66327e15bc064b75ffce50bb1531505690

            maConnexion.Close();
        }
    }
}
