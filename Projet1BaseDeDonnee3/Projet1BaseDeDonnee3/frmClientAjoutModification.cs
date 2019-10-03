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
            }
            else if (intChoix == 2)
            {
                this.Text = "Modification d'un client";

                label1.Text = "Modification d'un client";

                gbPlaceholder.Text = "Modifier ce client";

                btnPlaceholderEnregistrer.Text = "Modifier ce client";
            }
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
