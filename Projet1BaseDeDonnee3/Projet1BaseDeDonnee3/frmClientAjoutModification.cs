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
    public partial class frmClientAjoutModification : Form
    {
        public int intChoix;

        public string strNo, strNom, strPrenom, strVille, strPays, strAdresse, strCodePostal, strDate;

        public frmClientAjoutModification()
        {
            InitializeComponent();
        }

        private void frmClientAjoutModification_Load(object sender, EventArgs e)
        {
            if (intChoix == 1)
            {
                this.Text = "Ajout d'un nouveau client";

                label1.Text = "Ajout d'un nouveau client";

                gbPlaceholder.Text = "Ajout d'un nouveau client";

                btnPlaceholderEnregistrer.Text = "Ajouter le client";

                tbNo.Text = "10";

                tbDate.Text = DateTime.Today.ToString("yyyy-MM-dd");
            }
            else if (intChoix == 2)
            {
                this.Text = "Modification d'un client";

                label1.Text = "Modification d'un client";

                gbPlaceholder.Text = "Modifier ce client";

                btnPlaceholderEnregistrer.Text = "Modifier ce client";

                tbNo.Text = strNo;
                tbNom.Text = strNom;
                tbPrenom.Text = strPrenom;
                tbVille.Text = strVille;
                tbPays.Text = strPays;
                tbAdresse.Text = strAdresse;
                tbCodePostal.Text = strCodePostal;
                tbDate.Text = strDate;
            }
        }

        private void btnPlaceholderEnregistrer_Click(object sender, EventArgs e)
        {
            string strClientNo = tbNo.Text.Trim(),
                    strClientNom = tbNom.Text.Trim(), 
                    strClientPrenom = tbPrenom.Text.Trim(), 
                    strClientVille = tbVille.Text.Trim(), 
                    strClientPays = tbPays.Text.Trim(), 
                    strClientAdresse = tbAdresse.Text.Trim(), 
                    strClientCodePostal = tbCodePostal.Text.Trim(),
                    strClientDate = tbDate.Text.Trim();

            List<string> lstStrings = new List<string>();

            lstStrings.Add(strClientNo);
            lstStrings.Add(strClientNom);
            lstStrings.Add(strClientPrenom);
            lstStrings.Add(strClientVille);
            lstStrings.Add(strClientPays);
            lstStrings.Add(strClientAdresse);
            lstStrings.Add(strClientCodePostal);
            lstStrings.Add(strClientDate);

            for (int i = 0; i < lstStrings.Count; i++)
            {
                if (lstStrings[i] == "")
                {
                    //errMsgClient.SetError(lstStrings[i], "Le mot de passe ne peut pas être vide");
                }
            }

            /*if (intChoix == 1)
            {

            }
            else if (intChoix == 2)
            {

            }*/
        }

        private void tbDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
