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
    public partial class frmAjoutModificationClient : Form
    {
        public int intChoix;

        public string strNo, strNom, strPrenom, strVille, strPays, strAdresse, strCodePostal, strDate;

        public frmAjoutModificationClient()
        {
            InitializeComponent();
        }

        private void frmClientAjoutModification_Load(object sender, EventArgs e)
        {
            if (intChoix == 1)
            {
                this.Text = "Ajout d'un nouveau client";

                label1.Text = "Ajout d'un nouveau client";

                gbPlaceholder.Text = "Ajouter le nouveau client";

                btnPlaceholderEnregistrer.Text = "Ajouter le client";

                tbNo.Text = strNo;
                //tbNo.Text = "10";

                tbDate.Text = DateTime.Today.ToString("yyyy-MM-dd");
            }
            else if (intChoix == 2)
            {
                this.Text = "Modification du client";

                label1.Text = "Modification du client";

                gbPlaceholder.Text = "Modifier ce client";

                btnPlaceholderEnregistrer.Text = "Modifier ce client";

                tbNo.Text = strNo;
                tbNom.Text = strNom;
                tbPrenom.Text = strPrenom;
                tbVille.Text = strVille;
                tbPays.Text = strPays;
                tbAdresse.Text = strAdresse;
                tbCodePostal.Text = strCodePostal;
                tbDate.Text = strDate;
            }
        }

        private void btnPlaceholderEnregistrer_Click(object sender, EventArgs e)
        {
            /*string strClientNo = tbNo.Text.Trim(),
                    strClientNom = tbNom.Text.Trim(), 
                    strClientPrenom = tbPrenom.Text.Trim(), 
                    strClientVille = tbVille.Text.Trim(), 
                    strClientPays = tbPays.Text.Trim(), 
                    strClientAdresse = tbAdresse.Text.Trim(), 
                    strClientCodePostal = tbCodePostal.Text.Trim(),
                    strClientDate = tbDate.Text.Trim();

            List<string> lstStrings = new List<string>();

            lstStrings.Add(strClientNo);
            lstStrings.Add(strClientNom);
            lstStrings.Add(strClientPrenom);
            lstStrings.Add(strClientVille);
            lstStrings.Add(strClientPays);
            lstStrings.Add(strClientAdresse);
            lstStrings.Add(strClientCodePostal);
            lstStrings.Add(strClientDate);

            for (int i = 0; i < lstStrings.Count; i++)
            {
                if (lstStrings[i] == "")
                {
                    errMsgClient.SetError(lstStrings[i], "Le mot de passe ne peut pas être vide");
                }
            }*/

            errMsgClient.Clear();

            bool blnError = false;

            List<TextBox> lstTextBox = new List<TextBox>();
            lstTextBox.Add(tbNo);
            lstTextBox.Add(tbNom);
            lstTextBox.Add(tbPrenom);
            lstTextBox.Add(tbVille);
            lstTextBox.Add(tbPays);
            lstTextBox.Add(tbAdresse);
            //lstTextBox.Add(tbCodePostal); // Il n’est pas nécessaire de valider le code postal (varie d’un pays à un autre)
            lstTextBox.Add(tbDate);

            for (int i = 0; i < lstTextBox.Count; i++)
            {
                if (lstTextBox[i].Text.Trim() == "")
                {
                    errMsgClient.SetError(lstTextBox[i], "Ce champ ne peut pas être vide");

                    blnError = true;
                }
            }

            // aucune erreur
            if (!blnError)
            {
                //MessageBox.Show("Aucune erreur");

                if (intChoix == 1)
                {
                    String maChaineDeConnexion = Projet1BaseDeDonnee3.Properties.Settings.Default.BDTP1Guelleh_MarreroConnectionString;
                    SqlConnection maConnexion = new SqlConnection(maChaineDeConnexion);
                    maConnexion.Open();

                    SqlTransaction maTransaction = maConnexion.BeginTransaction();

                    try
                    {
                        String maRequeteSQL = "insert into client values (" + 
                                                tbNo.Text.Trim() + ", '" +
                                                tbNom.Text.Trim() + "', '" +
                                                tbPrenom.Text.Trim() + "', '" +
                                                tbVille.Text.Trim() + "', '" +
                                                tbPays.Text.Trim() + "', '" +
                                                tbAdresse.Text.Trim() + "', '" +
                                                tbCodePostal.Text.Trim() + "', ' " +
                                                tbDate.Text.Trim() + "')";

                        SqlCommand maCommande = new SqlCommand(maRequeteSQL, maConnexion);
                        maCommande.Transaction = maTransaction;

                        maCommande.ExecuteNonQuery();
                        maTransaction.Commit();
                    }
                    catch
                    {
                        maTransaction.Rollback();
                        MessageBox.Show("Transaction échouée");
                    }
                    
                    maConnexion.Close(); // Fermer la connexion

                    DialogResult = DialogResult.OK;

                    this.Close();
                }
                else if (intChoix == 2)
                {
                    String maChaineDeConnexion = Projet1BaseDeDonnee3.Properties.Settings.Default.BDTP1Guelleh_MarreroConnectionString;
                    SqlConnection maConnexion = new SqlConnection(maChaineDeConnexion);
                    maConnexion.Open();

                    SqlTransaction maTransaction = maConnexion.BeginTransaction();

                    try
                    {
                        // "update client set Nom='retest',Prenom='retest',Ville='',Pays='',Adresse='',CodePostal='',DateInscription='' where NoCLient=40";
                        String maRequeteSQL = "update client set Nom='" + tbNom.Text.Trim() + 
                                                "',Prenom='" + tbPrenom.Text.Trim() + 
                                                "',Ville='" + tbVille.Text.Trim() + 
                                                "',Pays='" + tbPays.Text.Trim() + 
                                                "',Adresse='" + tbAdresse.Text.Trim() + 
                                                "',CodePostal='" + tbCodePostal.Text.Trim() + 
                                                "',DateInscription='" + tbDate.Text.Trim() + 
                                                "' where NoCLient='" + tbNo.Text.Trim() + "'";

                        SqlCommand maCommande = new SqlCommand(maRequeteSQL, maConnexion);
                        maCommande.Transaction = maTransaction;

                        maCommande.ExecuteNonQuery();
                        maTransaction.Commit();
                    }
                    catch
                    {
                        maTransaction.Rollback();
                        MessageBox.Show("Transaction échouée");
                    }

                    maConnexion.Close(); // Fermer la connexion

                    DialogResult = DialogResult.OK;

                    this.Close();
                }
            }
        }

        private void tbDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

            this.Close();
        }
    }
}
