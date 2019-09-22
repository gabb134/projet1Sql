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
    public partial class frmGestionClients_Invites : Form
    {
        public frmGestionClients_Invites()
        {
            InitializeComponent();
        }

        private void ClientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDTP1Guelleh_MarreroDataSet);

        }

        private void FrmGestionClients_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDTP1Guelleh_MarreroDataSet.Invite' table. You can move, or remove it, as needed.
            this.inviteTableAdapter.Fill(this.bDTP1Guelleh_MarreroDataSet.Invite);
            // TODO: This line of code loads data into the 'bDTP1Guelleh_MarreroDataSet.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.bDTP1Guelleh_MarreroDataSet.Client);

        }


        // gestion client
        private void btnAjouterClient_Click(object sender, EventArgs e)
        {

        }

        private void btnModifierClient_Click(object sender, EventArgs e)
        {

        }

        private void btnSupprimerClient_Click(object sender, EventArgs e)
        {

        }


        // gestion invite
        private void btnAjouterInvite_Click(object sender, EventArgs e)
        {

        }

        private void btnModifierInvite_Click(object sender, EventArgs e)
        {

        }

        private void btnSupprimerInvite_Click(object sender, EventArgs e)
        {

        }
    }
}
