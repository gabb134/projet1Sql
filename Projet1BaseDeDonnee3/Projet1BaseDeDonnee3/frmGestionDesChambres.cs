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
            BDTP1Guelleh_MarreroDataSet.ChambreRow uneChambre = bDTP1Guelleh_MarreroDataSet.Chambre.NewChambreRow();

            decimal noChambreMax = 0;

            foreach (BDTP1Guelleh_MarreroDataSet.ChambreRow uneLigne in bDTP1Guelleh_MarreroDataSet.Chambre.Rows)
                if (uneLigne.NoChambre > noChambreMax) noChambreMax = uneLigne.NoChambre;


            uneChambre.NoChambre = Convert.ToInt32(noChambreMax+1);


            frmGestionAjoutModifChambres.uneChambre = uneChambre;
        
                if (frmGestionAjoutModifChambres.ShowDialog() == DialogResult.OK)
                {
                    if (uneChambre.NoChambre != -1)
                    {
                        bDTP1Guelleh_MarreroDataSet.Chambre.AddChambreRow(uneChambre);
                        chambreBindingSource.MoveLast();
                        this.chambreTableAdapter.Update(this.bDTP1Guelleh_MarreroDataSet.Chambre);
                        MessageBox.Show("La chambre " + uneChambre.NoChambre.ToString() + " a été ajouté", "Ajout d'une chambre", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
         
         
                

            
            
           
        }

        private void btnModifierChambre_Click(object sender, EventArgs e)
        {
            frmGestionAjoutModifChambres = new frmGestionAjoutModificationChambres();
            frmGestionAjoutModifChambres.strvaleur = "b";

            int noChambre = chambreBindingSource.Position;
            int nbChambre = chambreBindingSource.Count;


            if(noChambre >= 0 && noChambre < nbChambre)
            {
                dynamic chambreSelectionne = chambreBindingSource.Current;

              
                    frmGestionAjoutModifChambres.strDecoration = chambreSelectionne["Decorations"];
                    frmGestionAjoutModifChambres.intEmplacement = chambreSelectionne["Emplacement"];
                    frmGestionAjoutModifChambres.intNoTypeChambre = chambreSelectionne["NoTypeChambre"];
                
             
             


            }





            if (frmGestionAjoutModifChambres.ShowDialog() == DialogResult.OK)
            {
              
                    chambreDataGridView.CurrentRow.Cells[1].Value = frmGestionAjoutModifChambres.intEmplacement;
                    chambreDataGridView.CurrentRow.Cells[2].Value = frmGestionAjoutModifChambres.strDecoration;
                    chambreDataGridView.CurrentRow.Cells[3].Value = frmGestionAjoutModifChambres.intNoTypeChambre;
              
               

                this.Validate();
                this.chambreBindingSource.EndEdit();
                this.chambreTableAdapter.Update(this.bDTP1Guelleh_MarreroDataSet);

                MessageBox.Show("La chambre a été modifié.","Modification chambre",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

        }

        private void btnSupprimerChambre_Click(object sender, EventArgs e)
        {//faire en sorte que si les chambre ont des reservation, il faut mettre un message 
            chambreBindingSource.RemoveCurrent();
            this.Validate();
            this.chambreBindingSource.EndEdit();
            this.chambreTableAdapter.Update(this.bDTP1Guelleh_MarreroDataSet);

        }
    }
}
