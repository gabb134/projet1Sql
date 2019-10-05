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
    public partial class frmAjoutModificationInvite : Form
    {
        public int intChoix;
        public string strNoInvite = "", strNom = "", strPrenom = "", strNoClient;

        public frmAjoutModificationInvite()
        {
            InitializeComponent();
        }

        private void fillNoClientByNoInviteToolStripButton_Click(object sender, EventArgs e)
        {
            /*try
            {
                this.inviteTableAdapter.FillNoClientByNoInvite(this.bDTP1Guelleh_MarreroDataSet.Invite, ((int)(System.Convert.ChangeType(noInviteToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }*/
        }

        private void frmInviteAjoutModification_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDTP1Guelleh_MarreroDataSet.Invite'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.inviteTableAdapter.Fill(this.bDTP1Guelleh_MarreroDataSet.Invite);

            // TODO: cette ligne de code charge les données dans la table 'bDTP1Guelleh_MarreroDataSet.Client'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            //this.clientTableAdapter.Fill(bDTP1Guelleh_MarreroDataSet.Client);
            this.clientTableAdapter.Fill(bDTP1Guelleh_MarreroDataSet.Client);

            if (intChoix == 1)
            {
                /*cbClientNo.SelectedText = "";
                cbClientNo.SelectedValue = 0;*/

                //int intNoClientManquant = getIntNoManquant("select NoClient from Client", 10, 10, 10);
                //int intNoClientRechercher = getPremierIntNoRechercher("select NoClient from Client", 10);

                /*MessageBox.Show(intNoClientRechercher.ToString());
                cbClientNo.SelectedText = intNoClientRechercher.ToString(); //intNoClientManquant.ToString();*/

                //MessageBox.Show(cbClientNo.GetItemText(cbClientNo.SelectedItem));
                int intNoClientRechercher = int.Parse(cbClientNo.GetItemText(cbClientNo.SelectedItem));

                String maChaineDeConnexion = Projet1BaseDeDonnee3.Properties.Settings.Default.BDTP1Guelleh_MarreroConnectionString;
                SqlConnection maConnexion = new SqlConnection(maChaineDeConnexion);
                maConnexion.Open();

                String maRequeteSQL = "select Nom, Prenom, Ville, Pays, Adresse, CodePostal, DateInscription from Client where NoCLient='" + intNoClientRechercher + "'";
                SqlCommand maCommande = new SqlCommand(maRequeteSQL, maConnexion);
                SqlDataReader monReader = maCommande.ExecuteReader();

                //MessageBox.Show(intNoClientRechercher.ToString());

                while (monReader.Read())
                {

                    tbClientNom.Text = monReader["Nom"].ToString();
                    tbClientPrenom.Text = monReader["Prenom"].ToString();
                    tbClientVille.Text = monReader["Ville"].ToString();
                    tbClientPays.Text = monReader["Pays"].ToString();
                    tbClientAdresse.Text = monReader["Adresse"].ToString();
                    tbClientCodePostal.Text = monReader["CodePostal"].ToString();
                    tbClientDate.Text = monReader["DateInscription"].ToString();
                }

                monReader.Close();   // IMPORTANT: Libérer les ressources  

                maConnexion.Close();
                // fin de la connexion sql

                int intNoInviteManquant = getIntNoManquant("select NoInvite from Invite where NoCLient=" + intNoClientRechercher, intNoClientRechercher+1, intNoClientRechercher+1, 1);
                strNoInvite = intNoInviteManquant.ToString();
                tbNo.Text = strNoInvite;

                this.Text = "Ajout d'un nouveau invité";

                label1.Text = "Ajout d'un nouveau invité";

                gbPlaceholder.Text = "Ajouter le nouveau invité";

                btnPlaceholderEnregistrer.Text = "Ajouter l'invité";

                cbClientNo.Visible = true;
                tbClientNo.Visible = false;
            }
            else if (intChoix == 2)
            {
                int intNoClientRechercher = int.Parse(strNoClient);

                String maChaineDeConnexion = Projet1BaseDeDonnee3.Properties.Settings.Default.BDTP1Guelleh_MarreroConnectionString;
                SqlConnection maConnexion = new SqlConnection(maChaineDeConnexion);
                maConnexion.Open();

                String maRequeteSQL = "select Nom, Prenom, Ville, Pays, Adresse, CodePostal, DateInscription from Client where NoCLient='" + intNoClientRechercher + "'";
                SqlCommand maCommande = new SqlCommand(maRequeteSQL, maConnexion);
                SqlDataReader monReader = maCommande.ExecuteReader();

                //MessageBox.Show(intNoClientRechercher.ToString());

                while (monReader.Read())
                {

                    tbClientNom.Text = monReader["Nom"].ToString();
                    tbClientPrenom.Text = monReader["Prenom"].ToString();
                    tbClientVille.Text = monReader["Ville"].ToString();
                    tbClientPays.Text = monReader["Pays"].ToString();
                    tbClientAdresse.Text = monReader["Adresse"].ToString();
                    tbClientCodePostal.Text = monReader["CodePostal"].ToString();
                    tbClientDate.Text = monReader["DateInscription"].ToString();
                }

                monReader.Close();   // IMPORTANT: Libérer les ressources  

                maConnexion.Close();
                // fin de la connexion sql

                this.Text = "Modification de l'invité";

                label1.Text = "Modification de l'invité";

                gbPlaceholder.Text = "Modifier cet invité";

                btnPlaceholderEnregistrer.Text = "Modifier cet invité";

                //MessageBox.Show(strNoClient);

                tbNo.Text = strNoInvite;
                tbNom.Text = strNom;
                tbPrenom.Text = strPrenom;
                tbClientNo.Text = strNoClient;

                cbClientNo.Visible = false;
                tbClientNo.Visible = true;
            }
        }

        private void btnPlaceholderEnregistrer_Click(object sender, EventArgs e)
        {
            errMsgInvite.Clear();

            bool blnError = false;

            List<TextBox> lstTextBox = new List<TextBox>();
            lstTextBox.Add(tbNo);
            lstTextBox.Add(tbNom);
            lstTextBox.Add(tbPrenom);

            if (intChoix == 2)
                lstTextBox.Add(tbClientNo);
            else if (cbClientNo.GetItemText(cbClientNo.SelectedItem).ToString().Trim() == "")
            {
                blnError = true;

                ///////////////////////////// FAIRE LA VALIDATION POUR CE COMBOBOX /////////////////////////////
                errMsgInvite.SetError(cbClientNo, "Ce champ ne peut pas être vide");
            }

            for (int i = 0; i < lstTextBox.Count; i++)
            {
                if (lstTextBox[i].Text.Trim() == "")
                {
                    errMsgInvite.SetError(lstTextBox[i], "Ce champ ne peut pas être vide");

                    blnError = true;
                }
            }

            //MessageBox.Show(blnError.ToString());

            if (!blnError)
            {
                if (intChoix == 1)
                {
                    String maChaineDeConnexion = Projet1BaseDeDonnee3.Properties.Settings.Default.BDTP1Guelleh_MarreroConnectionString;
                    SqlConnection maConnexion = new SqlConnection(maChaineDeConnexion);
                    maConnexion.Open();

                    SqlTransaction maTransaction = maConnexion.BeginTransaction();

                    try
                    {
                        // insert into invite values(22, 'test', 20)
                        String maRequeteSQL = "insert into invite values (" +
                                                tbNo.Text.Trim() + ", '" +
                                                tbNom.Text.Trim() + ", " +
                                                tbPrenom.Text.Trim() + "', '" +
                                                cbClientNo.GetItemText(cbClientNo.SelectedItem).ToString().Trim() + "')"; /*tbClientNo.Text.Trim()*/

                        //MessageBox.Show(maRequeteSQL);

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

                    //MessageBox.Show(cbClientNo.GetItemText(cbClientNo.SelectedItem));

                    //DialogResult = DialogResult.OK;
                }
                else if (intChoix == 2)
                {
                    String maChaineDeConnexion = Projet1BaseDeDonnee3.Properties.Settings.Default.BDTP1Guelleh_MarreroConnectionString;
                    SqlConnection maConnexion = new SqlConnection(maChaineDeConnexion);
                    maConnexion.Open();

                    SqlTransaction maTransaction = maConnexion.BeginTransaction();

                    try
                    {
                        // update Invite set NomPrenom='testNom, testPrenom' where NoInvite=51
                        String maRequeteSQL = "update Invite set NomPrenom='" + tbNom.Text.Trim() + ", " + tbPrenom.Text.Trim() +
                                                "' where NoInvite='" + tbNo.Text.Trim() + "'";

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

                    this.Close();

                    //DialogResult = DialogResult.OK;
                }
            }
        }

        private void cbClientNo_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void cbClientNo_TextChanged(object sender, EventArgs e)
        {
            int intNoClientRechercher;
            bool blnParseInt = int.TryParse(cbClientNo.GetItemText(cbClientNo.SelectedItem), out intNoClientRechercher);
            //int intNoClientRechercher = int.Parse(cbClientNo.GetItemText(cbClientNo.SelectedItem));

            if (blnParseInt)
            {
                String maChaineDeConnexion = Projet1BaseDeDonnee3.Properties.Settings.Default.BDTP1Guelleh_MarreroConnectionString;
                SqlConnection maConnexion = new SqlConnection(maChaineDeConnexion);
                maConnexion.Open();

                String maRequeteSQL = "select Nom, Prenom, Ville, Pays, Adresse, CodePostal, DateInscription from Client where NoCLient='" + intNoClientRechercher + "'";
                SqlCommand maCommande = new SqlCommand(maRequeteSQL, maConnexion);
                SqlDataReader monReader = maCommande.ExecuteReader();

                //MessageBox.Show(intNoClientRechercher.ToString());

                while (monReader.Read())
                {

                    tbClientNom.Text = monReader["Nom"].ToString();
                    tbClientPrenom.Text = monReader["Prenom"].ToString();
                    tbClientVille.Text = monReader["Ville"].ToString();
                    tbClientPays.Text = monReader["Pays"].ToString();
                    tbClientAdresse.Text = monReader["Adresse"].ToString();
                    tbClientCodePostal.Text = monReader["CodePostal"].ToString();
                    tbClientDate.Text = monReader["DateInscription"].ToString();
                }

                monReader.Close();   // IMPORTANT: Libérer les ressources  

                maConnexion.Close();
                // fin de la connexion sql

                int intNoInviteManquant = getIntNoManquant("select NoInvite from Invite where NoClient=" + intNoClientRechercher, intNoClientRechercher + 1, intNoClientRechercher + 1, 1);

                //MessageBox.Show(intNoInviteManquant.ToString());

                strNoInvite = intNoInviteManquant.ToString();
                tbNo.Text = strNoInvite;
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            //DialogResult = DialogResult.Cancel;

            this.Close();
        }

        private int getIntNoManquant(string strRequete, int intDefaultValue, int intStartingValue, int intIncrement)
        {
            int intNo = 0;
            bool blnIntNoTrouve = true;
            List<Int32> lstIntNo = new List<Int32>();

            // requete sql
            String maChaineDeConnexion = Projet1BaseDeDonnee3.Properties.Settings.Default.BDTP1Guelleh_MarreroConnectionString;
            SqlConnection maConnexion = new SqlConnection(maChaineDeConnexion);
            maConnexion.Open();

            //MessageBox.Show(strRequete);

            //String maRequeteSQL = "select NoCLient from client";
            SqlCommand maCommande = new SqlCommand(strRequete/*maRequeteSQL*/, maConnexion);
            SqlDataReader monReader = maCommande.ExecuteReader();

            if (monReader.HasRows) // monreader n'est pas vide
            {
                while (monReader.Read()) // Lire le prochain enregistrement (la prochaine ligne)
                {
                    // L'index peut être un numéro de colonne ou le nom d'une colonne
                    //Console.WriteLine(monReader["empNo"] + ", " + monReader["empNom"] + ", " + monReader[2]);

                    lstIntNo.Add(monReader.GetInt32(0));
                }
            }
            else // monreader est vide
            {
                blnIntNoTrouve = false;
            }
            monReader.Close();   // IMPORTANT: Libérer les ressources  

            maConnexion.Close();
            // fin de la requete sql

            if (blnIntNoTrouve)
            {
                lstIntNo.Sort();

                /*int intStartingValue = 10,
                    intEndingValue = lstIntNoClient[lstIntNoClient.Count - 1],
                    intIncrement = 10;*/

                int intEndingValue = lstIntNo[lstIntNo.Count - 1];

                //MessageBox.Show(intEndingValue.ToString());

                var intMissing = Enumerable.
                                    Range(0, (intEndingValue - intStartingValue) / intIncrement + 1).
                                    Select(i => i * intIncrement + intStartingValue).
                                    Except(lstIntNo);

                //MessageBox.Show(intMissing.First().ToString());

                if (intMissing.Count() != 0) // get le premier nb qui manque
                    intNo = intMissing.First();
                else // aucun nombre ne manque, so get le dernier nb + increment
                    intNo = intEndingValue + intIncrement; 
                    //lstIntNoClient[lstIntNoClient.Count - 1] + 10;
            }
            else
                intNo = intDefaultValue;
                //intNoClient = 10;

            return intNo;
        }




































        private int getPremierIntNoRechercher(string strRequete, int intDefaultValue) // retourne 1er no rechercher
        {
            int intNo = 0;
            bool blnIntNoTrouve = true;
            List<Int32> lstIntNo = new List<Int32>();

            // requete sql
            String maChaineDeConnexion = Projet1BaseDeDonnee3.Properties.Settings.Default.BDTP1Guelleh_MarreroConnectionString;
            SqlConnection maConnexion = new SqlConnection(maChaineDeConnexion);
            maConnexion.Open();

            //String maRequeteSQL = "select NoCLient from client";
            SqlCommand maCommande = new SqlCommand(strRequete/*maRequeteSQL*/, maConnexion);
            SqlDataReader monReader = maCommande.ExecuteReader();

            if (monReader.HasRows) // monreader n'est pas vide
            {
                while (monReader.Read()) // Lire le prochain enregistrement (la prochaine ligne)
                {
                    // L'index peut être un numéro de colonne ou le nom d'une colonne
                    //Console.WriteLine(monReader["empNo"] + ", " + monReader["empNom"] + ", " + monReader[2]);

                    lstIntNo.Add(monReader.GetInt32(0));
                }
            }
            else // monreader est vide
            {
                blnIntNoTrouve = false;
            }
            monReader.Close();   // IMPORTANT: Libérer les ressources  

            maConnexion.Close();
            // fin de la requete sql

            if (blnIntNoTrouve)
            {
                lstIntNo.Sort();

                /*int intStartingValue = 10,
                    intEndingValue = lstIntNoClient[lstIntNoClient.Count - 1],
                    intIncrement = 10;*/

                /*int intEndingValue = lstIntNoClient[lstIntNoClient.Count - 1];

                var intMissing = Enumerable.
                                    Range(0, (intEndingValue - intStartingValue) / intIncrement + 1).
                                    Select(i => i * intIncrement + intStartingValue).
                                    Except(lstIntNoClient);

                MessageBox.Show(intMissing.First().ToString());

                if (intMissing.Count() != 0) // get le premier nb qui manque
                    intNoClient = intMissing.First();
                else // aucun nombre ne manque, so get le dernier nb + 10
                    intNoClient = intEndingValue + intIncrement;
                //lstIntNoClient[lstIntNoClient.Count - 1] + 10;*/

                intNo = lstIntNo[0];
            }
            else
                intNo = intDefaultValue;
            //intNoClient = 10;

            return intNo;
        }
    }
}
