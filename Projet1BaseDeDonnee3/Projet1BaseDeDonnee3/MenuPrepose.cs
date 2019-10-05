using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1BaseDeDonnee3
{
    public partial class MenuPrepose : Form
    {
        public MenuPrepose()
        {
            InitializeComponent();
        }

        private void btnQuitterPrepose_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void btnDeconnexionPrepose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GérerLesClientsEtLeursInvitésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGestionClientsInvites frmGestionClientsInvites = new frmGestionClientsInvites();
            frmGestionClientsInvites.ShowDialog();
            this.Show();
        }

        private void MenuPrepose_Load(object sender, EventArgs e)
        {

        }

        private void réserverDesChambresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGestionReservationChambre frmGestionReservationChambre = new frmGestionReservationChambre();
            frmGestionReservationChambre.ShowDialog();
            this.Show();
        }
    }
}
