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
        public int intType;


        public String strNomUtilisateurModifier;
        public String strMotdePasseModifier;
        public int intTypeModier;

        // public String strNomUtilisateurSelectionnee;
        // public String strMotDePasseSelectionnee;
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
                this.Text = "Ajout des utilateurs";
            }
            else if (strValeur.Equals("b")) // Modification
            {
                //Remplir les labels avec les id utilisateur
                //cbModifier.Enabled = true;
                lblAjoutModif.Text = "Modification d'un utilisateur";
                
                tbUtilisateur.Text = strNomUtilisateur;
                tbMotDePasse.Text = strMotdePasse;

             //  MessageBox.Show(intType.ToString());
                if (intType == 1)
                {
                    cbNoTypeUtilisateur.Text = "Admin";

                }
                else if(intType == 2)
                {
                    cbNoTypeUtilisateur.Text = "Préposé";
                }

                //cbNoTypeUtilisateur.Enabled = false;
                // MessageBox.Show(strNomUtilisateur);
                this.Text = "Modification des utilisateurs";
                String strNomUtilisateurConnexion = ConnexionSysteme.strUtilisateurConnexion;

                if(strNomUtilisateurConnexion == tbUtilisateur.Text)
                {
                    cbNoTypeUtilisateur.Enabled = false;
                }


            }
            
        }

   

        private void btnEnregistrer_Click_1(object sender, EventArgs e)
        {
            if (strValeur.Equals("a")) //ajout
            {
                //    MessageBox.Show("Ajout");

                string strNomUtilisateur = tbUtilisateur.Text.Trim();
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
            else if (strValeur.Equals("b")) //modification
            {

               
                int intNoTypeChoisi = 0;
                if(cbNoTypeUtilisateur.Text == "Admin") {
                    intNoTypeChoisi = 1;
                }
                else if(cbNoTypeUtilisateur.Text == "Préposé")
                {
                    intNoTypeChoisi = 2;
                }

                string strNomUtilisateur = tbUtilisateur.Text.Trim();
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
                            
                            
                            // Ouvrir la connexion
                            String maChaineDeConnexion = Projet1BaseDeDonnee3.Properties.Settings.Default.BDTP1Guelleh_MarreroConnectionString;
                            SqlConnection maConnexion = new SqlConnection(maChaineDeConnexion);
                            maConnexion.Open();

                            SqlTransaction maTransaction = maConnexion.BeginTransaction();
                            try
                            {

                                String maRequeteUpdateNom = "update Utilisateur set NomUtilisateur = '" + tbUtilisateur.Text + "'" + ", MotDePasse = '" + tbMotDePasse.Text + "'" + ", NoTypeUtilisteur = '" + intNoTypeChoisi + "'" + "where NomUtilisateur = '" + strNomUtilisateur + "'";
                                //String maRequeteUpdateMotDePasse = "update Utilisateur set MotDePasse = " + "\'" +tbMotDePasse.Text+"\'" + "where NomUtilisateur = " +"'"+ strNomUtilisateur + "'";



                                SqlCommand maCommande1 = new SqlCommand(maRequeteUpdateNom, maConnexion);
                                maCommande1.Transaction = maTransaction;
                                maCommande1.ExecuteNonQuery();

                             
                                maTransaction.Commit();
                                strNomUtilisateurModifier = tbUtilisateur.Text;
                                strMotdePasseModifier = tbMotDePasse.Text;
                                intTypeModier = intNoTypeChoisi;

                            }
                            catch
                            {
                               
                                    maTransaction.Rollback();
                                    MessageBox.Show("Transaction échouée");
                                



                            }
                            // Fermer la connexion
                            maConnexion.Close();
                            DialogResult = DialogResult.OK;
                            this.Close();

                        }
                    }
                }

            








                
            }
            


        }
    }
}
