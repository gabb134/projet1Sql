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
    public partial class frmAjoutPlanifSoin : Form
    {
        public frmAjoutPlanifSoin()
        {
            InitializeComponent();
        }

        private void frmAjoutPlanifSoin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDTP1Guelleh_MarreroDataSet.Assistant' table. You can move, or remove it, as needed.
            this.assistantTableAdapter.Fill(this.bDTP1Guelleh_MarreroDataSet.Assistant);
            // TODO: This line of code loads data into the 'bDTP1Guelleh_MarreroDataSet.Soin' table. You can move, or remove it, as needed.
            this.soinTableAdapter.Fill(this.bDTP1Guelleh_MarreroDataSet.Soin);
            // TODO: This line of code loads data into the 'bDTP1Guelleh_MarreroDataSet.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.bDTP1Guelleh_MarreroDataSet.Client);


            dtpReservation.MinDate = DateTime.Now;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

            this.Close();
        }

        private void btnAjouterReservationChambre_Click(object sender, EventArgs e)
        {
            String maChaineDeConnexion = Projet1BaseDeDonnee3.Properties.Settings.Default.BDTP1Guelleh_MarreroConnectionString;
            SqlConnection maConnexion = new SqlConnection(maChaineDeConnexion);
            maConnexion.Open();

            SqlTransaction maTransaction = maConnexion.BeginTransaction();

            try
            {
                //MessageBox.Show(dtpReservation.Value.ToString().Substring(0, 11) + " " + numHeureReservation.Value.ToString() + ":00:00");
                // insert into ReservationChambre values (10, 1, '2019-09-15', '2019-09-23', 2)
                String maRequeteSQL = "insert into PlanifSoin values ('" +
                                        cbNoClient.GetItemText(cbNoClient.SelectedItem).ToString().Trim() + "', '" + // cbNoClient.Text.Trim()
                                        cbNoAssist.GetItemText(cbNoAssist.SelectedItem).ToString().Trim() + "', '" +
                                        Convert.ToDateTime(dtpReservation.Value.ToString().Substring(0, 11) + " " + numHeureReservation.Value.ToString() + ":00:00").ToString("yyyy-MM-dd hh:mm:ss") + "', '" +
                                        cbNoSoin.GetItemText(cbNoSoin.SelectedItem).ToString().Trim() + "')";

                //MessageBox.Show(maRequeteSQL);

                SqlCommand maCommande = new SqlCommand(maRequeteSQL, maConnexion);
                maCommande.Transaction = maTransaction;

                maCommande.ExecuteNonQuery();
                maTransaction.Commit();

                DialogResult = DialogResult.OK;
            }
            catch
            {
                maTransaction.Rollback();
                MessageBox.Show("Transaction échouée");
            }

            maConnexion.Close(); // Fermer la connexion

            this.Close();
        }
    }
}
