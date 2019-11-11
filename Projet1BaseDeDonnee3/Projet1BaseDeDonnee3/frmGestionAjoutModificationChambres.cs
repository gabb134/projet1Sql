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
       public BDTP1Guelleh_MarreroDataSet.ChambreRow uneChambre;

        public String strvaleur = "";
        public int intEmplacement;
        public String strDecoration;
        public int intNoTypeChambre;

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
                lblAjoutModif.Text = "Ajout d'une chambre";
                tbChambre.Enabled = false;

            }
            else if (strvaleur.Equals("b")) // modification
            {
                this.Text = "Modifications des chambres";

                lblAjoutModif.Text = "Modification d'une chambre";

                tbDecoration.Text = strDecoration;
                tbEmplacement.Text = intEmplacement.ToString();

                if(intNoTypeChambre==1)
                cbNoTypeChambre.Text = 1.ToString();
                else if(intNoTypeChambre==2)
                    cbNoTypeChambre.Text = 2.ToString();


                tbChambre.Enabled = false;
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

                if(tbDecoration.Text == "")
                {
                    errMessage.SetError(tbDecoration, "La décoration ne peut pas être vide");

                }
                else
                {
                    errMessage.SetError(tbDecoration, "");
                    if (tbEmplacement.Text == "")
                    {
                        errMessage.SetError(tbEmplacement, "L'emplacement ne peut pas être vide");
                    }
                    else
                    {
                        
                        errMessage.SetError(tbEmplacement, "");
                        uneChambre.Decorations = tbDecoration.Text;
                        uneChambre.Emplacement = Convert.ToInt32(tbEmplacement.Text);
                        uneChambre.NoTypeChambre = Convert.ToInt32(cbNoTypeChambre.Text);


                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }

               

            }
            else if (strvaleur.Equals("b")) // modification
            {
                //Validation
             
                if (tbDecoration.Text == "")
                {
                    errMessage.SetError(tbDecoration, "La décoration ne peut pas être vide");

                }
                else
                {
                    errMessage.SetError(tbDecoration, "");
                    if (tbEmplacement.Text == "")
                    {
                        errMessage.SetError(tbEmplacement, "L'emplacement ne peut pas être vide");
                    }
                    else
                    {
                        errMessage.SetError(tbEmplacement, "");

                        strDecoration = tbDecoration.Text;
                        intEmplacement = Convert.ToInt32(tbEmplacement.Text);
                        intNoTypeChambre = Convert.ToInt32(cbNoTypeChambre.Text);
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }

            
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
