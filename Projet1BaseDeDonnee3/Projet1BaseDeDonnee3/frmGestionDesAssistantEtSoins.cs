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
    public partial class frmGestionDesAssistantEtSoins : Form
    {
        frmGestionDesAssistants frmGestionAssiant = new frmGestionDesAssistants();
        frmGestionDesSoins frmGestionSoins = new frmGestionDesSoins();


        public frmGestionDesAssistantEtSoins()
        {
            InitializeComponent();
        }
        
        private void soinBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.soinBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDTP1Guelleh_MarreroDataSet);

        }

        private void frmGererAssistantEtSoins_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDTP1Guelleh_MarreroDataSet.AssistantSoin'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.assistantSoinTableAdapter.Fill(this.bDTP1Guelleh_MarreroDataSet.AssistantSoin);
            // TODO: cette ligne de code charge les données dans la table 'bDTP1Guelleh_MarreroDataSet.Assistant'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.assistantTableAdapter.Fill(this.bDTP1Guelleh_MarreroDataSet.Assistant);
            // TODO: cette ligne de code charge les données dans la table 'bDTP1Guelleh_MarreroDataSet.Soin'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.soinTableAdapter.Fill(this.bDTP1Guelleh_MarreroDataSet.Soin);



        }

        private void btnGestionAssistant_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGestionAssiant.ShowDialog();
            this.Show();
        }

        private void btnGestionSoins_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGestionSoins.ShowDialog();
            this.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
