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
    public partial class frmGestionReservationChambre : Form
    {
        public frmGestionReservationChambre()
        {
            InitializeComponent();
        }

        private void reservationChambreBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.reservationChambreBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDTP1Guelleh_MarreroDataSet);

        }

        private void frmReservationChambre_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDTP1Guelleh_MarreroDataSet.ReservationChambre'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.reservationChambreTableAdapter.Fill(this.bDTP1Guelleh_MarreroDataSet.ReservationChambre);

        }

        private void DisplayData()
        {
            String maChaineDeConnexion = Projet1BaseDeDonnee3.Properties.Settings.Default.BDTP1Guelleh_MarreroConnectionString;
            SqlConnection maConnexion = new SqlConnection(maChaineDeConnexion);
            maConnexion.Open();

            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from ReservationChambre", maConnexion);

            sqlDataAdapter.Fill(dataTable);
            reservationChambreDataGridView.DataSource = dataTable;

            maConnexion.Close();
        }

        private void btnAjouterReservation_Click(object sender, EventArgs e)
        {
            frmAjoutReservationChambre frmAjoutReservationChambre = new frmAjoutReservationChambre();

            frmAjoutReservationChambre.ShowDialog();

            DisplayData();
        }

        private void btnSupprimerReservation_Click(object sender, EventArgs e)
        {
            string strMsgBox = "Voulez-vous vraiement supprimer la réservation de chambre dont le numéro du client est le " + reservationChambreDataGridView.CurrentRow.Cells[0].Value.ToString() + 
                                ", le numéro de chambre est le " + reservationChambreDataGridView.CurrentRow.Cells[1].Value.ToString() +
                                " et la date d'arrivée est le " + Convert.ToDateTime(reservationChambreDataGridView.CurrentRow.Cells[2].Value.ToString()).ToString("dd/MM/yyyy") +
                                " ?\n\n!!! Cette opération est irréversible !!!";
            DialogResult dialogResult = MessageBox.Show(strMsgBox, "ATTENTION", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.OK) // suppression du client
            {
                reservationChambreBindingSource.RemoveCurrent();

                this.Validate();
                this.reservationChambreBindingSource.EndEdit();
                //this.tableAdapterManager.UpdateAll(this.bDTP1Guelleh_MarreroDataSet);
                this.reservationChambreTableAdapter.Update(this.bDTP1Guelleh_MarreroDataSet);

                //this.clientTableAdapter.Update()
            }
        }
    }
}
