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
        frmGestionClients MenuClients = new frmGestionClients();

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
            MenuClients.ShowDialog();
            this.Show();
        }
    }
}
