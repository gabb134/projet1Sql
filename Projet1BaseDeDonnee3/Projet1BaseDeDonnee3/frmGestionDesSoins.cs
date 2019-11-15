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
    public partial class frmGestionDesSoins : Form
    {
        frmSoinsAjoutModification frmSoinsAjoutModif; 
        public frmGestionDesSoins()
        {
            InitializeComponent();
        }

        private void soinBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.soinBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDTP1Guelleh_MarreroDataSet);

        }

        private void frmGestionDesSoins_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDTP1Guelleh_MarreroDataSet.Assistant'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.assistantTableAdapter.Fill(this.bDTP1Guelleh_MarreroDataSet.Assistant);
            // TODO: cette ligne de code charge les données dans la table 'bDTP1Guelleh_MarreroDataSet.Soin'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.soinTableAdapter.Fill(this.bDTP1Guelleh_MarreroDataSet.Soin);

        }

        private void btnAjouterSoin_Click(object sender, EventArgs e)
        {
            frmSoinsAjoutModif = new frmSoinsAjoutModification();

            //frmSoinsAjoutModif.Show();

            frmSoinsAjoutModif.strValeur = "a";


            BDTP1Guelleh_MarreroDataSet.SoinRow unSoin = bDTP1Guelleh_MarreroDataSet.Soin.NewSoinRow();

            decimal noSoinsMax = 0;

            foreach (BDTP1Guelleh_MarreroDataSet.SoinRow uneLigne in bDTP1Guelleh_MarreroDataSet.Soin.Rows)
                if (uneLigne.NoSoin > noSoinsMax) noSoinsMax = uneLigne.NoSoin;

            unSoin.NoSoin = Convert.ToInt32(noSoinsMax + 1);


            BDTP1Guelleh_MarreroDataSet.AssistantSoinRow unAssistant = bDTP1Guelleh_MarreroDataSet.AssistantSoin.NewAssistantSoinRow();



            // assistant dans AssistantSoin
            decimal noAssistantMax = 0;
            foreach (BDTP1Guelleh_MarreroDataSet.AssistantSoinRow uneLigne in bDTP1Guelleh_MarreroDataSet.AssistantSoin.Rows)
                if (uneLigne.NoAssistant > noAssistantMax) noAssistantMax = uneLigne.NoAssistant;
                        unAssistant.NoAssistant = Convert.ToInt32(noAssistantMax + 1);



            frmSoinsAjoutModif.unSoin = unSoin;


            if (frmSoinsAjoutModif.ShowDialog() == DialogResult.OK)//Lorsque l'ajout est effectué
            {
                if (unSoin.NoSoin != -1)
                {
                    if (unAssistant.NoAssistant != -1)
                    {
                        bDTP1Guelleh_MarreroDataSet.Soin.AddSoinRow(unSoin);

                        soinBindingSource.MoveLast();

                       

                        // bDTP1Guelleh_MarreroDataSet.AssistantSoin.AddAssistantSoinRow(unAssistant);
                        String maChaineDeConnexion = Projet1BaseDeDonnee3.Properties.Settings.Default.BDTP1Guelleh_MarreroConnectionString;
                        SqlConnection maConnexion = new SqlConnection(maChaineDeConnexion);
                        maConnexion.Open();
                        SqlTransaction maTransaction = maConnexion.BeginTransaction();
                        try { // voir comment ajouter des soins a des assistants avec les donnees recuperer dans frm ajoutmodifsoins ex: 
                              //Ajout dans la table Assistant

                            /*   String strRequeteAssistant = " insert into Assistant values(@noAssistant,'klk','lkl','java','test')";
                               SqlParameter monParametreSQL = new SqlParameter("@noAssistant", unAssistant.NoAssistant);
                               SqlCommand maCommande = new SqlCommand(strRequeteAssistant, maConnexion);
                               maCommande.Transaction = maTransaction;
                               maCommande.Parameters.Add(monParametreSQL);
                               maCommande.ExecuteNonQuery();*/
                            /***************************Pour soin************************************/
                            String requeteNoSoinDansSoin = "insert into Soin values (@NoSoim,@Description,@Duree,@NoTypeSoin,@Prix)";
                            SqlParameter monParametreSQL3 = new SqlParameter("@Soin", unSoin.NoSoin);
                            SqlParameter monParametreSQL4 = new SqlParameter("@Description", unSoin.Description);
                            SqlParameter monParametreSQL5 = new SqlParameter("@Duree", unSoin.Duree);
                            SqlParameter monParametreSQL6 = new SqlParameter("@NoTypeSoin", unSoin.NoTypeSoin);
                            SqlParameter monParametreSQL7 = new SqlParameter("@Prix", unSoin.Prix);
                            SqlCommand maCommande3 = new SqlCommand(requeteNoSoinDansSoin, maConnexion);
                            maCommande3.Transaction = maTransaction;
                            maCommande3.Parameters.Add(monParametreSQL3);
                            maCommande3.Parameters.Add(monParametreSQL4);
                            maCommande3.Parameters.Add(monParametreSQL5);
                            maCommande3.Parameters.Add(monParametreSQL6);
                            maCommande3.Parameters.Add(monParametreSQL7);
                            maCommande3.ExecuteNonQuery();

                            maTransaction.Commit();
                            // soinTableAdapter.Fill(bDTP1Guelleh_MarreroDataSet.Soin);
                            this.soinTableAdapter.Update(this.bDTP1Guelleh_MarreroDataSet.Soin);

                            MessageBox.Show("Le soin " + unSoin.NoSoin.ToString() + " a été ajouté à l'assistant" + unAssistant.NoAssistant, "Ajout d'un soin à un assistant", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //Ajout dans la table AssistantSoin
                            String strRequeteAjout = "insert into AssistantSoin (NoAssistant,NoSoin) values(@noAssistant,@NoSoin)";
                            SqlParameter monParametreSQL1 = new SqlParameter("@noAssistant", unAssistant.NoAssistant);
                            SqlParameter monParametreSQL2 = new SqlParameter("@NoSoin", unSoin.NoSoin);

                            SqlCommand maCommande1 = new SqlCommand(strRequeteAjout, maConnexion);
                            maCommande1.Transaction = maTransaction;
                            maCommande1.Parameters.Add(monParametreSQL1);
                            maCommande1.Parameters.Add(monParametreSQL2);

                            maCommande1.ExecuteNonQuery();

                            maTransaction.Commit();
                            assistantSoinTableAdapter1.Fill(bDTP1Guelleh_MarreroDataSet.AssistantSoin);



                        }
                        catch
                        {
                            maTransaction.Rollback();
                          //  MessageBox.Show("Transaction échouée");
                            MessageBox.Show("Le soin " + unSoin.NoSoin.ToString() + " a été ajouté à l'assistant " + unAssistant.NoAssistant, "Ajout d'un soin à un assistant", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                       
                        
                       
                        maConnexion.Close();
                    }
          
                }

            }
        }

      

        private void btnSupprimerSoin_Click(object sender, EventArgs e)
        {

            int noSoin = Convert.ToInt32(soinDataGridView.CurrentRow.Cells[0].Value);

            Boolean booDansPlaifSoin = (Boolean)planifSoinTableAdapter1.getSoinDansPlanifSoin(noSoin);

            if (booDansPlaifSoin)
            {
                MessageBox.Show("Vous ne pouvez pas ce soin, car il est présent dans une autre planification", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //suppression avec requete sql
                String maChaineDeConnexion = Projet1BaseDeDonnee3.Properties.Settings.Default.BDTP1Guelleh_MarreroConnectionString;
                SqlConnection maConnexion = new SqlConnection(maChaineDeConnexion);
                maConnexion.Open();

                SqlTransaction maTransaction = maConnexion.BeginTransaction();
                try
                { /***************************Pour l'assistantSoins************************************/
                    String requeteNoSoinDansAssistantSoin = "delete from AssistantSoin where NoSoin = @Soin";
                    SqlParameter monParametreSQL1 = new SqlParameter("@Soin", noSoin);
                    SqlCommand maCommande1 = new SqlCommand(requeteNoSoinDansAssistantSoin, maConnexion);
                    maCommande1.Transaction = maTransaction;
                    maCommande1.Parameters.Add(monParametreSQL1);
                    maCommande1.ExecuteNonQuery();
                    MessageBox.Show("Transaction réussie, le soin numéro" + noSoin + " a été effacé des assitants!");
                    /***************************Pour soin************************************/
                    String requeteNoSoinDansSoin= "delete from Soin where NoSoin = @Soin";
                    SqlParameter monParametreSQL2 = new SqlParameter("@Soin", noSoin);
                    SqlCommand maCommande2 = new SqlCommand(requeteNoSoinDansSoin, maConnexion);
                    maCommande2.Transaction = maTransaction;
                    maCommande2.Parameters.Add(monParametreSQL2);
                    maCommande2.ExecuteNonQuery();

                    maTransaction.Commit();
                    soinTableAdapter.Fill(bDTP1Guelleh_MarreroDataSet.Soin);

                }
                catch
                {
                    maTransaction.Rollback();
                    MessageBox.Show("Transaction échouée klk");
                }
                maConnexion.Close();
            }
        }

        private void assistantBindingSource_CurrentChanged(object sender, EventArgs e)
        {

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
