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
    public partial class frmAjoutPlanifSoin : Form
    {
        public frmAjoutPlanifSoin()
        {
            InitializeComponent();
        }

        private void frmAjoutPlanifSoin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDTP1Guelleh_MarreroDataSet.Assistant' table. You can move, or remove it, as needed.
            this.assistantTableAdapter.Fill(this.bDTP1Guelleh_MarreroDataSet.Assistant);
            // TODO: This line of code loads data into the 'bDTP1Guelleh_MarreroDataSet.Soin' table. You can move, or remove it, as needed.
            this.soinTableAdapter.Fill(this.bDTP1Guelleh_MarreroDataSet.Soin);
            // TODO: This line of code loads data into the 'bDTP1Guelleh_MarreroDataSet.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.bDTP1Guelleh_MarreroDataSet.Client);

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
