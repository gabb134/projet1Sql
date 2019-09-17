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
    public partial class frmGestionUtilisateurs : Form
    {
        public frmGestionUtilisateurs()
        {
            InitializeComponent();
        }

        private void utilisateurBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.utilisateurBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDTP1Guelleh_MarreroDataSet);

        }

        private void frmGestionUtilisateurs_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDTP1Guelleh_MarreroDataSet.Utilisateur'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.utilisateurTableAdapter.Fill(this.bDTP1Guelleh_MarreroDataSet.Utilisateur);

        }
    }
}
