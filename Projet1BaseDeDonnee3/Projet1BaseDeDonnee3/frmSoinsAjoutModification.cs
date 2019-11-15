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
    public partial class frmSoinsAjoutModification : Form
    {
        public BDTP1Guelleh_MarreroDataSet.SoinRow unSoin;
        public BDTP1Guelleh_MarreroDataSet.AssistantSoinRow unAssistantSoin;
        public String strValeur = "";
        public DateTime dtDate;
        public String strDescription;
        public int intNoTypeSoin;
        public int intPrix;

        public int noAssistant;


        public frmSoinsAjoutModification()
        {
            InitializeComponent();
        }

        private void soinBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.soinBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDTP1Guelleh_MarreroDataSet);
        }

        private void frmSoinsAjoutModification_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDTP1Guelleh_MarreroDataSet.Assistant'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.assistantTableAdapter.Fill(this.bDTP1Guelleh_MarreroDataSet.Assistant);
            // TODO: cette ligne de code charge les données dans la table 'bDTP1Guelleh_MarreroDataSet.Soin'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.soinTableAdapter.Fill(this.bDTP1Guelleh_MarreroDataSet.Soin);
            this.typeSoinTableAdapter.Fill(this.bDTP1Guelleh_MarreroDataSet.TypeSoin);
            this.typeSoinTableAdapter.Fill(this.bDTP1Guelleh_MarreroDataSet.TypeSoin);
            if (strValeur == "a")
            {
                this.Text = "Ajout d'un soin à un assistant";
                lblAjoutModif.Text = "Ajout d'un soin à un assitant";
                tbSoin.Enabled = false;

            }

        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {

            if (strValeur.Equals("a")) // Ajout traitement
            {
                if (cbTypeSoin.Text == "")
                {
                    errMessage.SetError(cbTypeSoin, "Le numéro de type soin ne peut pas être vide");
                }
                else
                {
                    errMessage.SetError(cbTypeSoin, "");


                    if (tbDescription.Text == "")
                    {
                        errMessage.SetError(tbDescription, "La description ne peut pas être vide");
                    }
                    else
                    {
                        errMessage.SetError(tbDescription, "");
                        if (tbDuree.Text == "")
                        {
                            errMessage.SetError(tbDuree, "La duree ne peut pas être vide");
                        }
                        else
                        {
                            errMessage.SetError(tbDuree, "");
                            if (tbPrix.Text == "")
                            {
                                errMessage.SetError(tbPrix, "Le prix ne peu pas être vide");
                            }
                            else
                            {
                                errMessage.SetError(tbPrix, "");

                                //Ajout dans la table Soin
                                unSoin.NoTypeSoin = Convert.ToInt32(cbTypeSoin.SelectedValue.ToString());
                                unSoin.Description = tbDescription.Text;
                                unSoin.Duree =Convert.ToInt32(tbDuree.Text);
                                unSoin.Prix = Convert.ToInt32(tbPrix.Text);


                                noAssistant =Convert.ToInt32( cbAssistant.SelectedValue.ToString());

                            


                              




                                DialogResult = DialogResult.OK;
                                this.Close();
                            }


                        }

                    }
                }
            }
        }

       

        private void btnFermer_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
