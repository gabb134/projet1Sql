using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Data.SqlClient;

namespace Projet1BaseDeDonnee3
{
    public partial class frmAjouterUtilisateur : Form
    {

        public BDTP1Guelleh_MarreroDataSet.UtilisateurRow unUtilisateur;
        public String strValeur = "";
        public String strNomUtilisateur;
        public String strMotdePasse;
        public int intidUilisateur = 0;
        public frmAjouterUtilisateur()
        {

     
            InitializeComponent();


        }

       

        private void btnFermer_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void typeUtilisateurBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.typeUtilisateurBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDTP1Guelleh_MarreroDataSet);

        }

        private void frmAjouterUtilisateur_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDTP1Guelleh_MarreroDataSet.TypeUtilisateur'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.typeUtilisateurTableAdapter.Fill(this.bDTP1Guelleh_MarreroDataSet.TypeUtilisateur);

            //MessageBox.Show(strValeur);
            if (strValeur.Equals("a")) // Ajout
            {
                //cbModifier.Enabled = false;
            }
            else if (strValeur.Equals("b")) // Modification
            {
                //Remplir les labels avec les id utilisateur
                //cbModifier.Enabled = true;
                lblAjoutModif.Text = "Modification d'un utilisateur";

                tbUtilisateur.Text = strNomUtilisateur;
                tbMotDePasse.Text = strMotdePasse;
                // MessageBox.Show(strNomUtilisateur);

                // Ouvrir la connexion
               // String maChaineDeConnexion = "Data Source=424-SQL2017,5433;Initial Catalog=BDTP1Guelleh_Marrero;User ID=5B6Guelleh;Password=Amj2ghT7COd1";
               // SqlConnection maConnexion = new SqlConnection(maChaineDeConnexion);
            //    maConnexion.Open();


            }
          

        }

   

        private void btnEnregistrer_Click_1(object sender, EventArgs e)
        {


            string strNomUtilisateur = tbUtilisateur.Text.Trim() ;
            string strMotDePasse = tbMotDePasse.Text.Trim();

            if (tbUtilisateur.Text == "")
            {
                errMessage.SetError(tbUtilisateur, "Le nom de l'utilisateur ne peut pas être vide");
            }
            else
            {
                errMessage.SetError(tbUtilisateur, "");
                if (tbMotDePasse.Text == "")
                {
                    errMessage.SetError(tbMotDePasse, "Le mot de passe ne peut pas être vide");
                }
                else
                {
                    errMessage.SetError(tbMotDePasse, "");
                    if (cbNoTypeUtilisateur.Text == "")
                    {
                        errMessage.SetError(cbNoTypeUtilisateur, "Le no type utilisateur ne peut pas être vide");
                    }
                    else
                    {
                        errMessage.SetError(cbNoTypeUtilisateur, "");
                        unUtilisateur.NomUtilisateur = strNomUtilisateur;
                        unUtilisateur.MotDePasse = strMotDePasse;
                        unUtilisateur.NoTypeUtilisteur = Convert.ToInt32(cbNoTypeUtilisateur.SelectedValue.ToString());
                        DialogResult = DialogResult.OK;

                        this.Close();
                    }
                }
            }
        }
    }
}
