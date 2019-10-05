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
    public partial class frmGestionClients : Form
    {
        public frmGestionClients()
        {
            InitializeComponent();
        }

        private void clientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDTP1Guelleh_MarreroDataSet);

        }

        private void frmGestionClients_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDTP1Guelleh_MarreroDataSet.Client'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.clientTableAdapter.Fill(this.bDTP1Guelleh_MarreroDataSet.Client);

        }

        private void btnAjouterClient_Click(object sender, EventArgs e)
        {
            int intNoClient = 0;
            bool blnIntNoClientTrouve = true;
            List<Int32> lstIntNoClient = new List<Int32>();

            // requete sql
            String maChaineDeConnexion = Projet1BaseDeDonnee3.Properties.Settings.Default.BDTP1Guelleh_MarreroConnectionString;
            SqlConnection maConnexion = new SqlConnection(maChaineDeConnexion);
            maConnexion.Open();

            String maRequeteSQL = "select NoCLient from client";
            SqlCommand maCommande = new SqlCommand(maRequeteSQL, maConnexion);
            SqlDataReader monReader = maCommande.ExecuteReader();

            if (monReader.HasRows) // monreader n'est pas vide
            {
                while (monReader.Read()) // Lire le prochain enregistrement (la prochaine ligne)
                {
                    // L'index peut être un numéro de colonne ou le nom d'une colonne
                    //Console.WriteLine(monReader["empNo"] + ", " + monReader["empNom"] + ", " + monReader[2]);

                    lstIntNoClient.Add(monReader.GetInt32(0));
                }
            }
            else // monreader est vide
            {
                blnIntNoClientTrouve = false;
            }
            monReader.Close();   // IMPORTANT: Libérer les ressources  

            maConnexion.Close();
            // fin de la requete sql

            if (blnIntNoClientTrouve)
            {
                lstIntNoClient.Sort();

                int intStartingValue = 10,
                    intEndingValue = lstIntNoClient[lstIntNoClient.Count - 1], 
                    intIncrement = 10;

                var intMissing = Enumerable.
                                    Range(0, (intEndingValue - intStartingValue) / intIncrement + 1).
                                    Select(i => i * intIncrement + intStartingValue).
                                    Except(lstIntNoClient);

                if (intMissing.Count() != 0) // get le premier nb qui manque
                    intNoClient = intMissing.First();
                else // aucun nombre ne manque, so get le dernier nb + 10
                    intNoClient = lstIntNoClient[lstIntNoClient.Count - 1] + 10;
            }
            else
                intNoClient = 10;

            frmClientAjoutModification frmClientAjout = new frmClientAjoutModification();

            frmClientAjout.intChoix = 1;

            frmClientAjout.strNo = intNoClient.ToString();

            if (frmClientAjout.ShowDialog() == DialogResult.OK)
            {
                DisplayData();
            }
        }

        private void btnModifierClient_Click(object sender, EventArgs e)
        {
            frmClientAjoutModification frmClientAjout = new frmClientAjoutModification();

            frmClientAjout.intChoix = 2;

            dynamic clientSelectionne = clientBindingSource.Current;

            //MessageBox.Show(Convert.ToString(clientSelectionne["NoClient"]));

            frmClientAjout.strNo = Convert.ToString(clientSelectionne["NoClient"]);
            frmClientAjout.strNom = Convert.ToString(clientSelectionne["Nom"]);
            frmClientAjout.strPrenom = Convert.ToString(clientSelectionne["Prenom"]);
            frmClientAjout.strVille = Convert.ToString(clientSelectionne["Ville"]);
            frmClientAjout.strPays = Convert.ToString(clientSelectionne["Pays"]);
            frmClientAjout.strAdresse = Convert.ToString(clientSelectionne["Adresse"]);
            frmClientAjout.strCodePostal = Convert.ToString(clientSelectionne["CodePostal"]);
            frmClientAjout.strDate = Convert.ToString(clientSelectionne["DateInscription"]);

            if (frmClientAjout.ShowDialog() == DialogResult.OK)
            {
                DisplayData();
            }
        }

        //Display Data in DataGridView  
        private void DisplayData()
        {
            String maChaineDeConnexion = Projet1BaseDeDonnee3.Properties.Settings.Default.BDTP1Guelleh_MarreroConnectionString;
            SqlConnection maConnexion = new SqlConnection(maChaineDeConnexion);
            maConnexion.Open();

            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from client", maConnexion);

            sqlDataAdapter.Fill(dataTable);
            clientDataGridView.DataSource = dataTable;

            maConnexion.Close();
        }

        private void btnSupprimerClient_Click(object sender, EventArgs e)
        {
            bool blnClientHasInvite = Convert.ToBoolean(inviteTableAdapter1.getClientHasInvite(int.Parse(clientDataGridView.CurrentRow.Cells[0].Value.ToString()))),
                    blnClientHasReservationChambre = Convert.ToBoolean(reservationChambreTableAdapter1.getClientHasReservationChambre(int.Parse(clientDataGridView.CurrentRow.Cells[0].Value.ToString())));

            if (!blnClientHasInvite && !blnClientHasReservationChambre)
            {
                dynamic clientSelectionne = clientBindingSource.Current;

                DialogResult dialogResult = MessageBox.Show("Voulez-vous vraiement supprimer le client " + Convert.ToString(clientSelectionne["NoClient"]) + " ?\n\n!!! Cette opération est irréversible !!!", "ATTENTION", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.OK) // suppression du client
                {
                    clientBindingSource.RemoveCurrent();

                    this.Validate();
                    this.clientBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.bDTP1Guelleh_MarreroDataSet);

                    //this.clientTableAdapter.Update()
                }
            }

            if (blnClientHasInvite && blnClientHasReservationChambre)
            {
                dynamic clientSelectionne = clientBindingSource.Current;

                MessageBox.Show("!!! Vous ne pouvez pas supprimer le client " + Convert.ToString(clientSelectionne["NoClient"]) + " qui a des invités et des reservations de chambre !!!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (blnClientHasInvite)
            {
                dynamic clientSelectionne = clientBindingSource.Current;

                MessageBox.Show("!!! Vous ne pouvez pas supprimer le client " + Convert.ToString(clientSelectionne["NoClient"]) + " qui a des invités !!!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (blnClientHasReservationChambre)
            {
                dynamic clientSelectionne = clientBindingSource.Current;

                MessageBox.Show("!!! Vous ne pouvez pas supprimer le client " + Convert.ToString(clientSelectionne["NoClient"]) + " qui a des reservations de chambre !!!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
