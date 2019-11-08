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
    public partial class frmGestionClientsInvites : Form
    {
        public frmGestionClientsInvites()
        {
            InitializeComponent();
        }

        private void clientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDTP1Guelleh_MarreroDataSet);

        }

        private void frmGestionClientsInvites_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDTP1Guelleh_MarreroDataSet.Invite'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.inviteTableAdapter.Fill(this.bDTP1Guelleh_MarreroDataSet.Invite);
            // TODO: cette ligne de code charge les données dans la table 'bDTP1Guelleh_MarreroDataSet.Client'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.clientTableAdapter.Fill(this.bDTP1Guelleh_MarreroDataSet.Client);

        }

        private void btnGestionClients_Click(object sender, EventArgs e)
        {
            frmGestionClients frmGestionClients = new frmGestionClients();

            this.Hide();
            frmGestionClients.ShowDialog();
            this.Show();

            DisplayDataClient();
        }

        private void btnGestionInvites_Click(object sender, EventArgs e)
        {
            frmGestionInvites frmGestionInvites = new frmGestionInvites();

            this.Hide();
            frmGestionInvites.ShowDialog();
            this.Show();

            DisplayDataInvite();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DisplayDataClient()
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
        private void DisplayDataInvite()
        {
            String maChaineDeConnexion = Projet1BaseDeDonnee3.Properties.Settings.Default.BDTP1Guelleh_MarreroConnectionString;
            SqlConnection maConnexion = new SqlConnection(maChaineDeConnexion);
            maConnexion.Open();

            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from invite", maConnexion);

            sqlDataAdapter.Fill(dataTable);
            inviteBindingSource1.DataSource = dataTable;

            maConnexion.Close();
        }
    }
}
