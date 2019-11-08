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
    public partial class frmAssistantsAjoutModification : Form
    {
        public BDTP1Guelleh_MarreroDataSet.AssistantRow unAssistant;
        public String strValeur = "";
        public String strPrenom ;
        public String strNom;
        public String strSpecialites;
        public int intNoAssistant;



        public frmAssistantsAjoutModification()
        {
            InitializeComponent();
        }

        private void assistantBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.assistantBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDTP1Guelleh_MarreroDataSet);

        }

        private void frmAssistantsAjoutModification_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDTP1Guelleh_MarreroDataSet.Assistant'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.assistantTableAdapter.Fill(this.bDTP1Guelleh_MarreroDataSet.Assistant);

            if (strValeur.Equals("a")) // Ajout
            {
               // MessageBox.Show(tbPrenom.Text+" "+tbSpecialites.Text);
                this.Text = "Ajout des assistants";
                lblAjoutModif.Text = "Ajout d'un assistant";
               // tbNoAssistant.Enabled = false;
            }
            else if (strValeur.Equals("b")) //Modification
            {

                lblAjoutModif.Text = "Modification d'un assistant";
                this.Text = "Modification des assistants";
               // tbNoAssistant.Enabled = false;

               // tbNoAssistant.Text = intNoAssistant.ToString();
                tbPrenom.Text = strPrenom;
                tbNom.Text = strNom;
                tbSpecialites.Text = strSpecialites;
            }


        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (strValeur.Equals("a")) // Ajout traitement
            {
              
               
                   
                    if (tbPrenom.Text == "")
                    {
                        errMessage.SetError(tbPrenom, "Le prenom ne peut pas être vide");
                    }
                    else
                    {
                        
                        errMessage.SetError(tbPrenom, "");
                        if(tbNom.Text == "")
                        {
                            errMessage.SetError(tbNom, "Le nom ne peut pas être vide");
                        }
                        else
                        {

                            errMessage.SetError(tbNom, "");
                            if (tbSpecialites.Text == "")
                            {
                                errMessage.SetError(tbSpecialites, "La specialité ne peut pas être vide");
                            }
                            else
                            {
                                errMessage.SetError(tbSpecialites, "");


                                //Ajout 

                                unAssistant.Prenom = tbPrenom.Text;
                                unAssistant.Nom = tbNom.Text;
                                unAssistant.Specialites = tbSpecialites.Text;



                                DialogResult = DialogResult.OK;
                                this.Close();
                            }
                    }
                        
                    }
                
                


             
            }
            else if (strValeur.Equals("b")) //Modification traitement
            {

               
                    //errMessage.SetError(tbNoAssistant, "");
                    if (tbPrenom.Text == "")
                    {
                        errMessage.SetError(tbPrenom, "Le prenom ne peut pas être vide");
                    }
                    else
                    {
                        errMessage.SetError(tbPrenom, "");
                        if(tbNom.Text == "")
                        {
                            errMessage.SetError(tbNom,"Le nom en peut pas être vide");
                        }
                        else
                        {
                            errMessage.SetError(tbNom, "");
                        if (tbSpecialites.Text == "")
                            {
                                errMessage.SetError(tbSpecialites, "La specialité ne peut pas être vide");
                            }
                            else
                            {
                                errMessage.SetError(tbSpecialites, "");


                                //Modification


                                //  intNoAssistant = Convert.ToInt32(tbNoAssistant.Text);
                                strPrenom = tbPrenom.Text;
                                strNom = tbNom.Text;
                                strSpecialites = tbSpecialites.Text;

                                MessageBox.Show("Assistant : " + intNoAssistant.ToString() + "\nprenom: " + strPrenom + "\nNom: " + strNom + "\nSpecialites " + strSpecialites);



                                DialogResult = DialogResult.OK;
                                this.Close();
                            }
                    }
                       
                    }
                
            }
        }
    }
}
