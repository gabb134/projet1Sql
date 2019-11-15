using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1BaseDeDonnee3
{
    public partial class frmGestionDesAssistants : Form
    {


        frmAssistantsAjoutModification frmAjoutModifAssistant;
        public frmGestionDesAssistants()
        {
            InitializeComponent();
        }

        private void assistantBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.assistantBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDTP1Guelleh_MarreroDataSet);

        }

        private void frmGestionDesAssistants_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDTP1Guelleh_MarreroDataSet.Soin'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.soinTableAdapter.Fill(this.bDTP1Guelleh_MarreroDataSet.Soin);
            // TODO: cette ligne de code charge les données dans la table 'bDTP1Guelleh_MarreroDataSet.Assistant'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.assistantTableAdapter.Fill(this.bDTP1Guelleh_MarreroDataSet.Assistant);

        }

        private void btnAjouterAssistant_Click(object sender, EventArgs e)
        {
            frmAjoutModifAssistant = new frmAssistantsAjoutModification();

            BDTP1Guelleh_MarreroDataSet.AssistantRow unAssistant = bDTP1Guelleh_MarreroDataSet.Assistant.NewAssistantRow();

            decimal noAssistantMax = 0;

            foreach (BDTP1Guelleh_MarreroDataSet.AssistantRow uneLigne in bDTP1Guelleh_MarreroDataSet.Assistant.Rows)
                if (uneLigne.NoAssistant > noAssistantMax) noAssistantMax = uneLigne.NoAssistant;

            //Valeur du plus grand no utilisateur = MAX(noUtilisateur)+1
            unAssistant.NoAssistant = Convert.ToInt32(noAssistantMax + 1);

            frmAjoutModifAssistant.strValeur = "a";
            frmAjoutModifAssistant.unAssistant = unAssistant;


            if (frmAjoutModifAssistant.ShowDialog() == DialogResult.OK) //Lorsque l'ajout est effectué
            {
                if (unAssistant.NoAssistant != -1)
                {
                    bDTP1Guelleh_MarreroDataSet.Assistant.AddAssistantRow(unAssistant);
                    assistantBindingSource.MoveLast();
                    this.assistantTableAdapter.Update(this.bDTP1Guelleh_MarreroDataSet.Assistant);

                }
            }
        }

        private void btnModifierAssistant_Click(object sender, EventArgs e)
        {
            frmAjoutModifAssistant = new frmAssistantsAjoutModification();
            frmAjoutModifAssistant.strValeur = "b";

            int noAssistant = assistantBindingSource.Position;
            int nbAssistant = assistantBindingSource.Count;

            if (noAssistant >= 0 && noAssistant < nbAssistant)
            {
                dynamic assitantSelectionne = assistantBindingSource.Current;

                // frmAjoutModifAssistant.intNoAssistant = assitantSelectionne["NoAssistant"];
                frmAjoutModifAssistant.strPrenom = assitantSelectionne["Prenom"];
                frmAjoutModifAssistant.strNom = assitantSelectionne["Nom"];
                frmAjoutModifAssistant.strSpecialites = assitantSelectionne["Specialites"];


            }



            if (frmAjoutModifAssistant.ShowDialog() == DialogResult.OK) //Lorsque la modification est effectué
            {


                assistantDataGridView.CurrentRow.Cells[1].Value = frmAjoutModifAssistant.strPrenom;
                assistantDataGridView.CurrentRow.Cells[2].Value = frmAjoutModifAssistant.strNom;
                assistantDataGridView.CurrentRow.Cells[3].Value = frmAjoutModifAssistant.strSpecialites;

                this.Validate();
                this.assistantBindingSource.EndEdit();

                this.assistantTableAdapter.Update(this.bDTP1Guelleh_MarreroDataSet.Assistant);
            }
        }

        private void btnSupprimerAssistant_Click(object sender, EventArgs e)
        {

            int noAssistant = Convert.ToInt32(assistantDataGridView.CurrentRow.Cells[0].Value);


            //MessageBox.Show(noAssistant.ToString());

            Boolean booDansPlanifSoin = (Boolean)planifSoinTableAdapter1.getAssistantDansPlanifSoin(noAssistant);
            // Boolean booDansAssistantSoin = (Boolean)assistantSoinTableAdapter1.getAssistantDansAssistantSoin(noAssistant);

            if (booDansPlanifSoin)
            {
                //Verifier si c'est dans planif soin

                MessageBox.Show("Vous ne pouvez pas supprimer ces données, car elle fait partie de la table PlanifSoin", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Si c'est pas dans planif soin, il faut d'abord supprimer dans assitant soin et ensuiste dans assitant

                //Faire avec requete sql pour supprimer l'assistant qui est dans assistant soin d'abord
                String maChaineDeConnexion = Projet1BaseDeDonnee3.Properties.Settings.Default.BDTP1Guelleh_MarreroConnectionString;
                SqlConnection maConnexion = new SqlConnection(maChaineDeConnexion);
                maConnexion.Open();

                SqlTransaction maTransaction = maConnexion.BeginTransaction();
                try
                { /***************************Pour l'assistantSoins************************************/
                    String requeteNoAssistantDansAssistantSoin = "delete from AssistantSoin where NoAssistant =  @noAssistant";
                    SqlParameter monParametreSQL1 = new SqlParameter("@noAssistant", noAssistant);
                    SqlCommand maCommande1 = new SqlCommand(requeteNoAssistantDansAssistantSoin, maConnexion);
                    maCommande1.Transaction = maTransaction;
                    maCommande1.Parameters.Add(monParametreSQL1);
                    maCommande1.ExecuteNonQuery();

                    ///  maTransaction.Commit();
                    MessageBox.Show("Transaction réussie, l'assistant numéro" + noAssistant + " a été effacé!");
                    /***************************Pour l'assistant************************************/
                    String requeteNoAssistantDansAssistant = "delete from Assistant where NoAssistant =  @noAssistant";
                    SqlParameter monParametreSQL2 = new SqlParameter("@noAssistant", noAssistant);
                    SqlCommand maCommande2 = new SqlCommand(requeteNoAssistantDansAssistant, maConnexion);
                    maCommande2.Transaction = maTransaction;
                    maCommande2.Parameters.Add(monParametreSQL2);
                    maCommande2.ExecuteNonQuery();

                    maTransaction.Commit();
                    assistantTableAdapter.Fill(bDTP1Guelleh_MarreroDataSet.Assistant);
                }
                catch
                {
                    maTransaction.Rollback();
                    MessageBox.Show("Transaction échouée");
                }

                maConnexion.Close();
            }
        }

        private void assistantBindingSource_PositionChanged(object sender, EventArgs e)
        {
            int noEnregistrement = assistantBindingSource.Position;
            int nbEnregistrement = assistantBindingSource.Count;

            if (noEnregistrement >= 0 && noEnregistrement < nbEnregistrement)
            {
                dynamic enregistrementSelectionne = assistantBindingSource.Current;
                if (!DBNull.Value.Equals(enregistrementSelectionne["NoAssistant"]))
                {
                    int noEmployeSelectionne = enregistrementSelectionne["NoAssistant"];
                    soinTableAdapter.ClearBeforeFill = true;
                    soinTableAdapter.FillBy(bDTP1Guelleh_MarreroDataSet.Soin, noEmployeSelectionne);
                }
                else
                {
                    soinTableAdapter.ClearBeforeFill = true;
                    // soinTableAdapter.FillSoin(bDTP1Bergeron_KoumaDataSet.Soin, null);
                }
            }
        }
    }
}