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
        MenuAdmin menuAdmin = new MenuAdmin();
        MenuPrepose menuPrepose = new MenuPrepose();

       

        public static String strUtilisateurConnexion = ""; //Pour le recuperer dans frmGestionUtilisateurs
        public ConnexionSysteme()
        {
            InitializeComponent();

            /*tbUtilisateur.Text = "testAdmin";
            tbMotDePasse.Text = "a";
            tbMotDePasse.PasswordChar = '*';*/
            tbUtilisateur.Text = "testAdmin";
            tbMotDePasse.Text = "a";
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            SqlConnection maConnexion = new SqlConnection();
            SqlCommand maCommande;

            maConnexion.ConnectionString = Projet1BaseDeDonnee3.Properties.Settings.Default.BDTP1Guelleh_MarreroConnectionString; //maChaineDeConnexion;
            maConnexion.Open();
            
            string strRequeteNoTypeUSer = "select NoTypeUtilisteur from Utilisateur where NomUtilisateur='" + tbUtilisateur.Text + "' and MotDePasse ='" + tbMotDePasse.Text + "'";

            maCommande = new SqlCommand(strRequeteNoTypeUSer, maConnexion);

            dynamic dynNoTypeUser = maCommande.ExecuteScalar();

            string strNoTypeUser = Convert.ToString(dynNoTypeUser);

          
            
           

            /*    if (tbUtilisateur.Text == "" && tbMotDePasse.Text == "")
                {
                    MessageBox.Show("Vous devez inserer un utilisateur et un mot de passe pour continuer","Attention",MessageBoxButtons.OKCancel,MessageBoxIcon.Error );
                }

                else if (tbUtilisateur.Text == "")
                {
                    MessageBox.Show("Vous devez inserer un utilisateur pour continuer", "Attention", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else if (tbMotDePasse.Text == "")
                {
                    MessageBox.Show("Vous devez inserer un mot de passe pour continuer", "Attention", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else
                {
                    if (strNoTypeUser == null)
                    {
                        MessageBox.Show("Nom d'utilisateur ou mot de passe n'existe pas dans la base de données", "Attention", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        tbUtilisateur.Text = "";
                        tbMotDePasse.Text = "";

                        if (dynNoTypeUser == 1)
                        {
                            this.Hide();
                            menuAdmin.ShowDialog();
                            this.Show();
                        }
                        else if (dynNoTypeUser == 2)
                        {
                            this.Hide();
                            menuPrepose.ShowDialog();
                            this.Show();
                        }
                    }
                }*/


            if (tbUtilisateur.Text == "" && tbMotDePasse.Text == "")
            {
                errMessage.SetError(tbUtilisateur, "Vous devez inserer un nom d'utilisatueur!");
                errMessage.SetError(tbMotDePasse, "Vous devez inserer un mot de passe!");
            }
            else
            {
                errMessage.SetError(tbUtilisateur, "");
                errMessage.SetError(tbMotDePasse, "");
                if (tbUtilisateur.Text == "")
                {
                    errMessage.SetError(tbUtilisateur, "Vous devez inserer un nom d'utilisatueur!");
                }
                else
                {
                    errMessage.SetError(tbUtilisateur, "");
                    if (tbMotDePasse.Text == "")
                    {
                        errMessage.SetError(tbMotDePasse, "Vous devez inserer un mot de passe!");

                    }
                    else
                    {
                        errMessage.SetError(tbMotDePasse, "");
                        if (strNoTypeUser == null)
                        {
                            errMessage.SetError(tbUtilisateur, "Nom d'utilisateur ou mot de passe n'existe pas dans la base de données");
                            errMessage.SetError(tbMotDePasse, "Nom d'utilisateur ou mot de passe n'existe pas dans la base de données");

                        }
                        else
                        {


                            strUtilisateurConnexion = tbUtilisateur.Text; //Pour le recuperer dans frmGestionUtilisateurs
                           

                            tbUtilisateur.Text = "";
                            tbMotDePasse.Text = "";

                            if (dynNoTypeUser == 1)
                            {
                                this.Hide();
                                menuAdmin.ShowDialog();
                                this.Show();
                            }
                            else if (dynNoTypeUser == 2)
                            {
                                this.Hide();
                                menuPrepose.ShowDialog();
                                this.Show();
                            }
                        }
                    }
                }

            }

            


                maConnexion.Close();
        }

        private void ConnexionSysteme_Load(object sender, EventArgs e)
        {
          
        }
    }
}
