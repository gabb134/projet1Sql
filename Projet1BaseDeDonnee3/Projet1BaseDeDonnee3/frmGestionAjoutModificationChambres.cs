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
    public partial class frmGestionAjoutModificationChambres : Form
    {

        public String strvaleur = "";
        public String strEmplacement;


        public frmGestionAjoutModificationChambres()
        {
            InitializeComponent();
        }

      

        private void typeChambreBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.typeChambreBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDTP1Guelleh_MarreroDataSet);

        }

        private void frmGestionAjoutModificationChambres_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDTP1Guelleh_MarreroDataSet.TypeChambre'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.typeChambreTableAdapter.Fill(this.bDTP1Guelleh_MarreroDataSet.TypeChambre);


            if (strvaleur.Equals("a"))// Ajout 
            {
                this.Text = "Ajout des chambres";
                
             

            }
            else if (strvaleur.Equals("b")) // modification
            {
                this.Text = "Modifications des chambres";


            }


        }

        private void noTypeChambreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {

            if (strvaleur.Equals("a"))// Ajout 
            {

                //Validation

                DialogResult = DialogResult.OK;
                this.Close();

            }
            else if (strvaleur.Equals("b")) // modification
            {
                //Validation


                DialogResult = DialogResult.OK;
                this.Close();
            }

            
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
