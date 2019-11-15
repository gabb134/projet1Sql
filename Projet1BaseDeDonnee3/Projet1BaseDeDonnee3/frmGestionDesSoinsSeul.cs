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
    public partial class frmGestionDesSoinsSeul : Form
    {
        frmGestionAjoutModificationSoinsSeul frmAjoutModifSoinsSeul;
        public frmGestionDesSoinsSeul()
        {
            InitializeComponent();
        }

        private void soinBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.soinBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDTP1Guelleh_MarreroDataSet);

        }

        private void GestionDesSoinsSeul_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDTP1Guelleh_MarreroDataSet.PlanifSoin'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.planifSoinTableAdapter.Fill(this.bDTP1Guelleh_MarreroDataSet.PlanifSoin);
            // TODO: cette ligne de code charge les données dans la table 'bDTP1Guelleh_MarreroDataSet.Assistant'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.assistantTableAdapter.Fill(this.bDTP1Guelleh_MarreroDataSet.Assistant);
            // TODO: cette ligne de code charge les données dans la table 'bDTP1Guelleh_MarreroDataSet.Soin'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.soinTableAdapter1.Fill(this.bDTP1Guelleh_MarreroDataSet.Soin);

        }

        private void btnAjouterSoin_Click(object sender, EventArgs e)
        {

            frmAjoutModifSoinsSeul = new frmGestionAjoutModificationSoinsSeul();


            BDTP1Guelleh_MarreroDataSet.SoinRow unSoinsSeul = bDTP1Guelleh_MarreroDataSet.Soin.NewSoinRow();

            decimal noSoinsMax = 0;

            foreach (BDTP1Guelleh_MarreroDataSet.SoinRow uneLigne in bDTP1Guelleh_MarreroDataSet.Soin.Rows)
                if (uneLigne.NoSoin > noSoinsMax) noSoinsMax = uneLigne.NoSoin;

            unSoinsSeul.NoSoin = Convert.ToInt32(noSoinsMax + 1);

            frmAjoutModifSoinsSeul.strValeur = "a";
            frmAjoutModifSoinsSeul.unSoinsSeul = unSoinsSeul;

            if(frmAjoutModifSoinsSeul.ShowDialog() == DialogResult.OK)//Lorsque l'ajout est effectué
            {

                if(unSoinsSeul.NoSoin!= -1)
                {
                    bDTP1Guelleh_MarreroDataSet.Soin.AddSoinRow(unSoinsSeul);

                    soinBindingSource.MoveLast();
                  //  try
                   // {
                        this.soinTableAdapter1.Update(this.bDTP1Guelleh_MarreroDataSet.Soin);
                  //  }
                   // catch(Exception e1)
                   //MessageBox.Show(e1.ToString());
                  //  }
                

                    MessageBox.Show("Le soin " + unSoinsSeul.NoSoin.ToString() + " a été ajouté", "Ajout d'un soin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

               
            }




        }

        private void btnModifierSoin_Click(object sender, EventArgs e)
        {
            frmAjoutModifSoinsSeul = new frmGestionAjoutModificationSoinsSeul();
            frmAjoutModifSoinsSeul.strValeur = "b";

            int noSoins = soinBindingSource.Position;
            int nbSoins = soinBindingSource.Count;

            if (noSoins >= 0 && noSoins < nbSoins)
            {
                dynamic SoinSelectionne = soinBindingSource.Current;

               frmAjoutModifSoinsSeul.intNoSoin = SoinSelectionne["NoSoin"];
                frmAjoutModifSoinsSeul.intNoTypeSoin = SoinSelectionne["NoTypeSoin"];
                frmAjoutModifSoinsSeul.intDate = Convert.ToInt32(SoinSelectionne["Duree"]);
                frmAjoutModifSoinsSeul.strDescription = SoinSelectionne["Description"];
                frmAjoutModifSoinsSeul.intPrix =Convert.ToInt32( SoinSelectionne["Prix"]);


            }




            if (frmAjoutModifSoinsSeul.ShowDialog() == DialogResult.OK)//Lorsque la modification est effectuée
            {
                // MessageBox.Show("modification effectue");

                soinDataGridView.CurrentRow.Cells[1].Value = frmAjoutModifSoinsSeul.strDescription;
                soinDataGridView.CurrentRow.Cells[3].Value = frmAjoutModifSoinsSeul.intNoTypeSoin;
                soinDataGridView.CurrentRow.Cells[4].Value = frmAjoutModifSoinsSeul.intPrix;

               // MessageBox.Show("gab");
                this.Validate();
                this.soinBindingSource.EndEdit();

                this.soinTableAdapter1.Update(this.bDTP1Guelleh_MarreroDataSet.Soin);
                //this.tableAdapterManager.UpdateAll(this.bDTP1Guelleh_MarreroDataSet);

                MessageBox.Show("Champ modifié", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void btnSupprimerSoin_Click(object sender, EventArgs e)
        {
          
        //  MessageBox.Show(bDTP1Guelleh_MarreroDataSet.Assistant.Rows.Count.ToString());
         // MessageBox.Show(bDTP1Guelleh_MarreroDataSet.PlanifSoin.Rows.Count.ToString());

         // Boolean booSupprimer = false;

         int intNoSoin = Convert.ToInt32( soinDataGridView.CurrentRow.Cells[0].Value);

         //MessageBox.Show("Dans la table  planif ? " +planifSoinTableAdapter.getSoinDansPlanifSoin(intNoSoin).ToString());
          //MessageBox.Show("Dans la table  assitantsoin ? " + assistantSoinTableAdapter1.getSoinDansAssistantSoin(intNoSoin).ToString());




          // MessageBox.Show("Utilisateur courant : " + intNoSoin.ToString());

          /*  foreach (DataTable dataTable in bDTP1Guelleh_MarreroDataSet.Tables)
            {
                if (dataTable.TableName.ToString() != "Soin" && !booSupprimer)
                {
                    dataTable.Load(dataTable.CreateDataReader());
                    foreach (DataRow dataRow in dataTable.Rows)
                    {
                        foreach (DataColumn dataColumn in dataTable.Columns)
                        {
                            if ((dataColumn.ColumnName.ToString() == "NoSoin" || dataColumn.ColumnName.ToString() == "NoSoin") && !booSupprimer)
                            {
                                if (dataRow[dataColumn].ToString().Equals(intNoSoin.ToString()))
                                {
                                    booSupprimer = true;
                                }
                            }
                        }
                    }
                }

            }*/

         
           Boolean booDansPlanifSoin = (Boolean)planifSoinTableAdapter.getSoinDansPlanifSoin(intNoSoin);
            Boolean booDansAssistantSoin = (Boolean)assistantSoinTableAdapter1.getSoinDansAssistantSoin(intNoSoin);


            


                if (booDansPlanifSoin==true || booDansAssistantSoin==true)
                {
              
                    MessageBox.Show("Vous ne pouvez pas supprimer ces données, car elle fait partie de la table Assistant pou de la table Planifié", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else //Suppression
                {
                    soinBindingSource.RemoveCurrent();

                    this.Validate();
                    this.soinBindingSource.EndEdit();
                    this.soinTableAdapter1.Update(this.bDTP1Guelleh_MarreroDataSet);

                MessageBox.Show("Vous venez de supprimer!");
                }

              
            }

        private void assistantDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
