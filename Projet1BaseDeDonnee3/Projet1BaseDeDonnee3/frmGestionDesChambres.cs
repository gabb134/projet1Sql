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
    public partial class frmGestionDesChambres : Form
    {


        frmGestionAjoutModificationChambres frmGestionAjoutModifChambres;
        public frmGestionDesChambres()
        {
            InitializeComponent();
        }

        private void chambreBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.chambreBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDTP1Guelleh_MarreroDataSet);

        }

        private void frmGestionDesChambres_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDTP1Guelleh_MarreroDataSet.Chambre'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.chambreTableAdapter.Fill(this.bDTP1Guelleh_MarreroDataSet.Chambre);

        }

        private void btnAjouterChambre_Click(object sender, EventArgs e)
        {
            frmGestionAjoutModifChambres = new frmGestionAjoutModificationChambres();

            frmGestionAjoutModifChambres.strvaleur = "a";

            if(frmGestionAjoutModifChambres.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void btnModifierChambre_Click(object sender, EventArgs e)
        {
            frmGestionAjoutModifChambres = new frmGestionAjoutModificationChambres();
            frmGestionAjoutModifChambres.strvaleur = "b";


            if (frmGestionAjoutModifChambres.ShowDialog() == DialogResult.OK)
            {

            }

        }

        private void btnSupprimerChambre_Click(object sender, EventArgs e)
        {

        }
    }
}
