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
    public partial class frmAjoutReservationChambre : Form
    {
        public frmAjoutReservationChambre()
        {
            InitializeComponent();
        }

        private void chambreBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.chambreBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDTP1Guelleh_MarreroDataSet);

        }

        private void frmAjoutReservationChambre_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDTP1Guelleh_MarreroDataSet.getChambreForReservationChambre' table. You can move, or remove it, as needed.
            this.getChambreForReservationChambreTableAdapter.Fill(this.bDTP1Guelleh_MarreroDataSet.getChambreForReservationChambre);
            // TODO: cette ligne de code charge les données dans la table 'bDTP1Guelleh_MarreroDataSet.Client'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.clientTableAdapter.Fill(this.bDTP1Guelleh_MarreroDataSet.Client);
            // TODO: cette ligne de code charge les données dans la table 'bDTP1Guelleh_MarreroDataSet.Chambre'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.chambreTableAdapter.Fill(this.bDTP1Guelleh_MarreroDataSet.Chambre);

            dtpSejourDebut.MinDate = DateTime.Now;
            dtpSejourFin.MinDate = DateTime.Now;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
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
                // insert into ReservationChambre values (10, 1, '2019-09-15', '2019-09-23', 2)
                String maRequeteSQL = "insert into ReservationChambre values ('" +
                                        cbNoClient.GetItemText(cbNoClient.SelectedItem).ToString().Trim() + "', '" + // cbNoClient.Text.Trim()
                                        getChambreForReservationChambreDataGridView.CurrentRow.Cells[0].Value.ToString() + "', '" +
                                        Convert.ToDateTime(dtpSejourDebut.Value.ToString()).ToString("yyyy-MM-dd hh:mm:ss") + "', '" +
                                        Convert.ToDateTime(dtpSejourFin.Value.ToString()).ToString("yyyy-MM-dd hh:mm:ss") + "', '" + 
                                        numNbPers.Value.ToString() + "')";

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

            this.Close();
        }

        private void dtpSejourFin_ValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(dtpSejourDebut.Value.ToString());
            //dtpSejourFin.MinDate = dtpSejourDebut.Value;
        }

        private void dtpSejourDebut_ValueChanged(object sender, EventArgs e)
        {
            dtpSejourFin.MinDate = dtpSejourDebut.Value;
        }
    }
}
