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
    public partial class frmGestionInvites : Form
    {
        public frmGestionInvites()
        {
            InitializeComponent();
        }

        private void inviteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.inviteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDTP1Guelleh_MarreroDataSet);

        }

        private void frmGestionInvites_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDTP1Guelleh_MarreroDataSet.Invite'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.inviteTableAdapter.Fill(this.bDTP1Guelleh_MarreroDataSet.Invite);
            // TODO: cette ligne de code charge les données dans la table 'bDTP1Guelleh_MarreroDataSet.Invite'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.inviteTableAdapter.Fill(this.bDTP1Guelleh_MarreroDataSet.Invite);
            // TODO: cette ligne de code charge les données dans la table 'bDTP1Guelleh_MarreroDataSet.Invite'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.inviteTableAdapter.Fill(this.bDTP1Guelleh_MarreroDataSet.Invite);
            // TODO: cette ligne de code charge les données dans la table 'bDTP1Guelleh_MarreroDataSet.Invite'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.inviteTableAdapter.Fill(this.bDTP1Guelleh_MarreroDataSet.Invite);

        }

        //Display Data in DataGridView  
        private void DisplayData()
        {
            String maChaineDeConnexion = Projet1BaseDeDonnee3.Properties.Settings.Default.BDTP1Guelleh_MarreroConnectionString;
            SqlConnection maConnexion = new SqlConnection(maChaineDeConnexion);
            maConnexion.Open();

            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from invite", maConnexion);

            sqlDataAdapter.Fill(dataTable);
            inviteDataGridView.DataSource = dataTable;

            maConnexion.Close();
        }

        private void btnAjouterInvite_Click(object sender, EventArgs e)
        {
            /*int intNoInvite = 0;
            bool blnIntNoInviteTrouve = true;
            List<Int32> lstIntNoInvite = new List<Int32>();

            // requete sql
            String maChaineDeConnexion = Projet1BaseDeDonnee3.Properties.Settings.Default.BDTP1Guelleh_MarreroConnectionString;
            SqlConnection maConnexion = new SqlConnection(maChaineDeConnexion);
            maConnexion.Open();

            String maRequeteSQL = "select NoInvite from invite";
            SqlCommand maCommande = new SqlCommand(maRequeteSQL, maConnexion);
            SqlDataReader monReader = maCommande.ExecuteReader();

            if (monReader.HasRows) // monreader n'est pas vide
            {
                while (monReader.Read()) // Lire le prochain enregistrement (la prochaine ligne)
                {
                    // L'index peut être un numéro de colonne ou le nom d'une colonne
                    //Console.WriteLine(monReader["empNo"] + ", " + monReader["empNom"] + ", " + monReader[2]);

                    lstIntNoInvite.Add(monReader.GetInt32(0));
                }
            }
            else // monreader est vide
            {
                blnIntNoInviteTrouve = false;
            }
            monReader.Close();   // IMPORTANT: Libérer les ressources  

            maConnexion.Close();
            // fin de la requete sql

            if (blnIntNoInviteTrouve)
            {
                lstIntNoInvite.Sort();

                int intStartingValue = 1,
                    intEndingValue = lstIntNoInvite[lstIntNoInvite.Count - 1],
                    intIncrement = 1;

                var intMissing = Enumerable.
                                    Range(0, (intEndingValue - intStartingValue) / intIncrement + 1).
                                    Select(i => i * intIncrement + intStartingValue).
                                    Except(lstIntNoInvite);

                if (intMissing.Count() != 0) // get le premier nb qui manque
                    intNoInvite = intMissing.First();
                else // aucun nombre ne manque, so get le dernier nb + 1
                    intNoInvite = lstIntNoInvite[lstIntNoInvite.Count - 1] + 10;
            }
            else
                intNoInvite = 1;*/

            frmInviteAjoutModification frmInviteAjout = new frmInviteAjoutModification();

            frmInviteAjout.intChoix = 1;

            //frmInviteAjout.strNoInvite = intNoInvite.ToString();

            frmInviteAjout.ShowDialog();

            /*if (frmInviteAjout.ShowDialog() == DialogResult.OK)
            {*/
                DisplayData();
            //}
        }

        private void btnModifierInvite_Click(object sender, EventArgs e)
        {
            frmInviteAjoutModification frmInviteAjout = new frmInviteAjoutModification();

            frmInviteAjout.intChoix = 2;

            //dynamic clientSelectionne = inviteBindingSource.Current;

            //MessageBox.Show(Convert.ToString(clientSelectionne["NoClient"]));

            string[] s = Convert.ToString(inviteDataGridView.CurrentRow.Cells[1].Value.ToString()).Split(','); //Convert.ToString(clientSelectionne["NomPrenom"]).Split(',');

            frmInviteAjout.strNoInvite = inviteDataGridView.CurrentRow.Cells[0].Value.ToString(); //Convert.ToString(clientSelectionne["NoInvite"]);
            frmInviteAjout.strNom = s.Length >= 1 ? s[0].Trim() : "";
            frmInviteAjout.strPrenom = s.Length >= 2 ? s[1].Trim() : "";
            frmInviteAjout.strNoClient = inviteDataGridView.CurrentRow.Cells[2].Value.ToString(); //Convert.ToString(clientSelectionne["NoClient"]);

            frmInviteAjout.ShowDialog();

            /*if (frmInviteAjout.ShowDialog() == DialogResult.OK)
            {*/
                DisplayData();
            //}
        }

        private void btnSupprimerInvite_Click(object sender, EventArgs e)
        {
            dynamic inviteSelectionne = inviteBindingSource.Current;

            DialogResult dialogResult = MessageBox.Show("Voulez-vous vraiement supprimer l'invité " + inviteDataGridView.CurrentRow.Cells[0].Value.ToString() + " ?\n\n!!! Cette opération est irréversible !!!", "ATTENTION", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.OK) // suppression du client
            {
                inviteBindingSource.RemoveCurrent();
                //BDTP1Guelleh_MarreroDataSetTableAdapters.InviteTableAdapter lol = new BDTP1Guelleh_MarreroDataSetTableAdapters.InviteTableAdapter();
                //lol.Update
                //this.inviteTableAdapter.Update(this.bDTP1Guelleh_MarreroDataSet);
                //this.inviteTableAdapter.Fill(this.bDTP1Guelleh_MarreroDataSet.Invite);
                //   this.tableAdapterManager.UpdateAll(this.bDTP1Guelleh_MarreroDataSet);

                this.Validate();
                this.inviteBindingSource.EndEdit();
                //this.tableAdapterManager.UpdateAll(this.bDTP1Guelleh_MarreroDataSet);
                this.inviteTableAdapter.Update(this.bDTP1Guelleh_MarreroDataSet);
            }
        }
    }
}
