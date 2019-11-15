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
    public partial class frmGestionPlanificationSoin : Form
    {
        public frmGestionPlanificationSoin()
        {
            InitializeComponent();
        }

        private void frmGestionPlanificationSoin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDTP1Guelleh_MarreroDataSet.PlanifSoin' table. You can move, or remove it, as needed.
            this.planifSoinTableAdapter.Fill(this.bDTP1Guelleh_MarreroDataSet.PlanifSoin);
            // TODO: This line of code loads data into the 'bDTP1Guelleh_MarreroDataSet.Client' table. You can move, or remove it, as needed.
            //this.clientTableAdapter.Fill(this.bDTP1Guelleh_MarreroDataSet.Client);

        }

        private void planifSoinBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.planifSoinBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDTP1Guelleh_MarreroDataSet);

        }

        private void btnSupprimerPlanif_Click(object sender, EventArgs e)
        {
            string strMsgBox = "Voulez-vous vraiement supprimer la planification de soin dont le numéro de la personne est le " + 
                                    planifSoinDataGridView.CurrentRow.Cells[0].Value.ToString() +   
                                    ", le numéro de de l'assistant est le " + planifSoinDataGridView.CurrentRow.Cells[1].Value.ToString() +
                                    " et la date de soin est le " + Convert.ToDateTime(planifSoinDataGridView.CurrentRow.Cells[2].Value.ToString()).ToString("dd/MM/yyyy") +
                                    " ?\n\n!!! Cette opération est irréversible !!!";
            DialogResult dialogResult = MessageBox.Show(strMsgBox, "ATTENTION", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.OK) // suppression du client
            {
                planifSoinBindingSource.RemoveCurrent();

                this.Validate();
                this.planifSoinBindingSource.EndEdit();
                //this.tableAdapterManager.UpdateAll(this.bDTP1Guelleh_MarreroDataSet);
                this.planifSoinTableAdapter.Update(this.bDTP1Guelleh_MarreroDataSet);

                //this.clientTableAdapter.Update()

                DisplayData();
            }
        }

        private void btnAjouterPlanif_Click(object sender, EventArgs e)
        {
            frmAjoutPlanifSoin frmAjoutPlanifSoin = new frmAjoutPlanifSoin();

            if (frmAjoutPlanifSoin.ShowDialog() == DialogResult.OK)
            {

                DisplayData();
            }
        }

        private void DisplayData()
        {
            String maChaineDeConnexion = Projet1BaseDeDonnee3.Properties.Settings.Default.BDTP1Guelleh_MarreroConnectionString;
            SqlConnection maConnexion = new SqlConnection(maChaineDeConnexion);
            maConnexion.Open();

            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from PlanifSoin", maConnexion);

            sqlDataAdapter.Fill(dataTable);
            planifSoinDataGridView.DataSource = dataTable;

            maConnexion.Close();
        }
    }
}
