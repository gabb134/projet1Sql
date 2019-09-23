using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Globalization;

namespace Projet1BaseDeDonnee3
{
    public partial class frmAjouterUtilisateur : Form
    {

        public BDTP1Guelleh_MarreroDataSet.UtilisateurRow unUtilisateur;
        public frmAjouterUtilisateur()
        {
            InitializeComponent();
        }

       

        private void btnFermer_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void typeUtilisateurBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.typeUtilisateurBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDTP1Guelleh_MarreroDataSet);

        }

        private void frmAjouterUtilisateur_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDTP1Guelleh_MarreroDataSet.TypeUtilisateur'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.typeUtilisateurTableAdapter.Fill(this.bDTP1Guelleh_MarreroDataSet.TypeUtilisateur);

        }

   

        private void btnEnregistrer_Click_1(object sender, EventArgs e)
        {


            string strNomUtilisateur = tbUtilisateur.Text;
            string strMotDePasse = tbMotDePasse.Text.Trim();

            if (tbUtilisateur.Text == "")
            {
                errMessage.SetError(tbUtilisateur, "Le nom de l'utilisateur ne peut pas être vide");
            }
            else
            {
                errMessage.SetError(tbUtilisateur, "");
                if (tbMotDePasse.Text == "")
                {
                    errMessage.SetError(tbMotDePasse, "Le mot de passe ne peut pas être vide");
                }
                else
                {
                    errMessage.SetError(tbMotDePasse, "");
                    if (cbNoTypeUtilisateur.Text == "")
                    {
                        errMessage.SetError(cbNoTypeUtilisateur, "Le no type utilisateur ne peut pas être vide");
                    }
                    else
                    {
                        errMessage.SetError(cbNoTypeUtilisateur, "");
                        unUtilisateur.NomUtilisateur = strNomUtilisateur;
                        unUtilisateur.MotDePasse = strMotDePasse;
                        unUtilisateur.NoTypeUtilisteur = Convert.ToInt32(cbNoTypeUtilisateur.SelectedValue.ToString());
                        DialogResult = DialogResult.OK;

                        this.Close();
                    }
                }
            }
        }
    }
}
