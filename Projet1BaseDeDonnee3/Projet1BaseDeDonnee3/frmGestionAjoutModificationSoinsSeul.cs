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
    public partial class frmGestionAjoutModificationSoinsSeul : Form
    {

        public String strValeur;
        public BDTP1Guelleh_MarreroDataSet.SoinRow unSoinsSeul;
        public DateTime dtDate;
        public String strDescription;
      //  public int intNoSoin;
        public int intNoTypeSoin;
        public int intPrix;

        public frmGestionAjoutModificationSoinsSeul()
        {
            InitializeComponent();
        }

       

        private void frmGestionAjoutModificationSoinsSeul_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDTP1Guelleh_MarreroDataSet.Assistant'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.assistantTableAdapter.Fill(this.bDTP1Guelleh_MarreroDataSet.Assistant);
            // TODO: cette ligne de code charge les données dans la table 'bDTP1Guelleh_MarreroDataSet.TypeSoin'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.typeSoinTableAdapter.Fill(this.bDTP1Guelleh_MarreroDataSet.TypeSoin);
            // TODO: cette ligne de code charge les données dans la table 'bDTP1Guelleh_MarreroDataSet.TypeSoin'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.typeSoinTableAdapter.Fill(this.bDTP1Guelleh_MarreroDataSet.TypeSoin);
            // TODO: cette ligne de code charge les données dans la table 'bDTP1Guelleh_MarreroDataSet.Soin'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.soinTableAdapter.Fill(this.bDTP1Guelleh_MarreroDataSet.Soin);
            // TODO: cette ligne de code charge les données dans la table 'bDTP1Guelleh_MarreroDataSet.TypeSoin'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.typeSoinTableAdapter.Fill(this.bDTP1Guelleh_MarreroDataSet.TypeSoin);
            // TODO: cette ligne de code charge les données dans la table 'bDTP1Guelleh_MarreroDataSet.TypeUtilisateur'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.typeUtilisateurTableAdapter.Fill(this.bDTP1Guelleh_MarreroDataSet.TypeUtilisateur);
            if (strValeur.Equals("a"))//Lorque le form ajout affiche 
            {
                this.Text = "Ajout des soins";
                lblAjoutModif.Text = "Ajout des soins";
                tbSoin.Enabled = false;
            }else if (strValeur.Equals("b")) //Lorque le form modifier affiche
            {
                this.Text = "Modification des soins";
                lblAjoutModif.Text = "Modification des soins";

               // tbSoin.Text = intNoSoin.ToString();
                tbDescription.Text = strDescription;
                tbDuree.Text = Convert.ToString(dtDate);
               
                tbPrix.Text = intPrix.ToString("#.##") + " $";
                //cbTypeSoin.Text = Convert.ToString(intNoTypeSoin);
                 if(intNoTypeSoin == 1)
                 {
                     cbTypeSoin.Text = 1.ToString();

                 }
                 else if (intNoTypeSoin == 2)
                 {
                     //cbTypeSoin.Text = "2";
                     cbTypeSoin.Text = 1.ToString();
                 }


                //  MessageBox.Show(cbTypeSoin.Text);

               tbDuree.Enabled = false;
                tbSoin.Enabled = false;

            }
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {


              
            if (strValeur.Equals("a"))// ajout  traitement
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

                                   // unSoinsSeul.NoSoin = Convert.ToInt32(tbSoin.Text);
                                    unSoinsSeul.NoTypeSoin = Convert.ToInt32(cbTypeSoin.SelectedValue.ToString());
                                    unSoinsSeul.Description = tbDescription.Text;
                                    unSoinsSeul.Duree =Convert.ToInt32(tbDuree.Text);
                                    unSoinsSeul.Prix = Convert.ToInt32(tbPrix.Text);

                                    DialogResult = DialogResult.OK;
                                    this.Close();
                                }
                            }
                        }
                    
                }





            }
            else if (strValeur.Equals("b")) //Modification tratement
            {
              
                //Gestion des messages derreurs

             

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
                                strDescription = tbDescription.Text;
                                intPrix = Convert.ToInt32(tbPrix.Text);
                                intNoTypeSoin = Convert.ToInt32(cbTypeSoin.Text);

                                    DialogResult = DialogResult.OK;
                                    this.Close();
                                }
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
