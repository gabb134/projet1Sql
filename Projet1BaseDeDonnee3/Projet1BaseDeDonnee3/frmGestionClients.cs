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
            frmClientAjoutModification frmClientAjout = new frmClientAjoutModification();

            frmClientAjout.intChoix = 1;

            frmClientAjout.ShowDialog();
        }

        private void btnModifierClient_Click(object sender, EventArgs e)
        {
            frmClientAjoutModification frmClientAjout = new frmClientAjoutModification();

            frmClientAjout.intChoix = 2;

            frmClientAjout.ShowDialog();
        }
    }
}
