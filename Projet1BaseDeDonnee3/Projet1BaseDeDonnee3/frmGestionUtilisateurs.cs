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
    public partial class frmGestionUtilisateurs : Form

    {
        frmAjouterUtilisateur frmAjout;
        //  ConnexionSysteme t = new ConnexionSysteme();


        String strUtilisteurConnextion = "";
        public static string utilisateurDatagriview = "";
        public int noUtilisateur;
        public frmGestionUtilisateurs()
        {
            InitializeComponent();
        }

        private void utilisateurBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.utilisateurBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDTP1Guelleh_MarreroDataSet);

        }

        private void frmGestionUtilisateurs_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDTP1Guelleh_MarreroDataSet.TypeUtilisateur'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.typeUtilisateurTableAdapter.Fill(this.bDTP1Guelleh_MarreroDataSet.TypeUtilisateur);
            // TODO: cette ligne de code charge les données dans la table 'bDTP1Guelleh_MarreroDataSet.Utilisateur'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.utilisateurTableAdapter.Fill(this.bDTP1Guelleh_MarreroDataSet.Utilisateur);

            //utilisateurTableAdapter.Fill(bDTP1Guelleh_MarreroDataSet.Utilisateur, Convert.ToDecimal(noUtilisateur));

            // t  = new ConnexionSysteme();


        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            utilisateurDatagriview = this.bDTP1Guelleh_MarreroDataSet.Utilisateur.NomUtilisateurColumn.ToString(); // voir comment chercher le nomutilisateur du datagridview
            frmAjout = new frmAjouterUtilisateur();

            BDTP1Guelleh_MarreroDataSet.UtilisateurRow unUtilisateur = bDTP1Guelleh_MarreroDataSet.Utilisateur.NewUtilisateurRow();

            decimal noUtilisateurMax = 0;
            foreach (BDTP1Guelleh_MarreroDataSet.UtilisateurRow uneLigne in bDTP1Guelleh_MarreroDataSet.Utilisateur.Rows)
                if (uneLigne.NoUtilisateur > noUtilisateurMax) noUtilisateurMax = uneLigne.NoUtilisateur;

            //Valeur du plus grand no utilisateur = MAX(noUtilisateur)+1
            unUtilisateur.NoUtilisateur = Convert.ToInt32(noUtilisateurMax + 1);



            frmAjout.strValeur = "a";
            frmAjout.unUtilisateur = unUtilisateur;
            if (frmAjout.ShowDialog() == DialogResult.OK)
            {

                // MessageBox.Show("allo");
                if (unUtilisateur.NoUtilisateur != -1)
                {
                    bDTP1Guelleh_MarreroDataSet.Utilisateur.AddUtilisateurRow(unUtilisateur);
                    // MessageBox.Show("bonjour");

                 /*  if(Convert.ToInt32(utilisateurDataGridView.CurrentRow.Cells[0].Value) != 1)
                    {

                        utilisateurBindingSource.MoveFirst();

                        this.utilisateurTableAdapter.Update(this.bDTP1Guelleh_MarreroDataSet.Utilisateur);
                        MessageBox.Show("L'utilisateur " + unUtilisateur.NoUtilisateur.ToString() + " a été ajouté", "Ajout d'un utilisateur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }*/
                   
                        utilisateurBindingSource.MoveLast();
                        
                        this.utilisateurTableAdapter.Update(this.bDTP1Guelleh_MarreroDataSet.Utilisateur);
                        MessageBox.Show("L'utilisateur " + unUtilisateur.NoUtilisateur.ToString() + " a été ajouté", "Ajout d'un utilisateur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    

                }

            }

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
          

            //   frmAjout = new frmAjouterUtilisateur();

            frmAjout = new frmAjouterUtilisateur();


            frmAjout.strValeur = "b";

          

            int noUtilisateur = utilisateurBindingSource.Position;
            int nbUtilisateurs = utilisateurBindingSource.Count;

            if (noUtilisateur >= 0 && noUtilisateur < nbUtilisateurs)
            {

                dynamic utilisateurSelectionne = utilisateurBindingSource.Current;
                

                frmAjout.strNomUtilisateur = utilisateurSelectionne["NomUtilisateur"];
                frmAjout.strMotdePasse = utilisateurSelectionne["MotDePasse"];
                frmAjout.intType = utilisateurSelectionne["NoTypeUtilisteur"];

                //MessageBox.Show(frmAjout.strMotdePasse);

                //MessageBox.Show(strNomUtilisateur);

               

            }
            if (frmAjout.ShowDialog() == DialogResult.OK)
            {
                //Update de le datagridview pour voir la modification
                utilisateurDataGridView.CurrentRow.Cells[1].Value = frmAjout.strNomUtilisateurModifier;
                utilisateurDataGridView.CurrentRow.Cells[2].Value = frmAjout.strMotdePasseModifier;
                utilisateurDataGridView.CurrentRow.Cells[3].Value = frmAjout.intTypeModier;


                this.Validate();
                this.utilisateurBindingSource.EndEdit();
                this.utilisateurTableAdapter.Update(this.bDTP1Guelleh_MarreroDataSet.Utilisateur);
            }


            //  frmAjout.strValeur = "b";


           /// frmAjout.Show();







        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {




            //  noUtilisateur = utilisateurBindingSource.Position;
            noUtilisateur = Convert.ToInt32(utilisateurDataGridView.CurrentRow.Cells[0].Value);
            int nbUtilisateurs = utilisateurBindingSource.Count;

            String strNomUtilisateur = "";
            String strMotdePasse = "";

            strUtilisteurConnextion = ConnexionSysteme.strUtilisateurConnexion;

           // MessageBox.Show("Utilisateur choisi : " + noUtilisateur.ToString());
          
            dynamic utilisateurSelectionne = utilisateurBindingSource.Current;

            strNomUtilisateur = utilisateurSelectionne["NomUtilisateur"];
            strMotdePasse = utilisateurSelectionne["MotDePasse"];

            //MessageBox.Show(strNomUtilisateur);
            //  MessageBox.Show(noUtilisateur.ToString());
            //MessageBox.Show(frmAjout.strMotdePasse);
            String maChaineDeConnexion = Projet1BaseDeDonnee3.Properties.Settings.Default.BDTP1Guelleh_MarreroConnectionString;
            SqlConnection maConnexion = new SqlConnection(maChaineDeConnexion);
            maConnexion.Open();

            SqlTransaction maTransaction = maConnexion.BeginTransaction();
            try
            {
                string requeteUtilisateur = "delete from Utilisateur where NoUtilisateur = @noUtilisateur";

                SqlParameter monParametreSQL1 = new SqlParameter("@noUtilisateur", noUtilisateur);
                SqlCommand maCommande1 = new SqlCommand(requeteUtilisateur, maConnexion);
                maCommande1.Transaction = maTransaction;
                maCommande1.Parameters.Add(monParametreSQL1);
                maCommande1.ExecuteNonQuery();


                if (strNomUtilisateur.Equals(strUtilisteurConnextion))
                {
                    maTransaction.Rollback();
                    MessageBox.Show("vous ne pouvez pas supprimer l'utilisateur courant.", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



                maTransaction.Commit();
                MessageBox.Show("Transaction réussie, l'utilisateur numéro " + noUtilisateur + " a été effacé!");
                //MessageBox.Show(noUtilisateur.ToString());

                // utilisateurTableAdapter.Fill(bDTP1Guelleh_MarreroDataSet.Utilisateur, Convert.ToDecimal(noUtilisateur));
                utilisateurTableAdapter.Fill(bDTP1Guelleh_MarreroDataSet.Utilisateur);
            }
            catch
            {
                if (strNomUtilisateur.Equals(strUtilisteurConnextion))
                {


                }
                else
                {
                    maTransaction.Rollback();
                    MessageBox.Show("Transaction échouée");
                }
                    


            }


            maConnexion.Close();
            // }


            /*foreach (var row in utilisateurBindingSource)
            {
                utilisateurBindingSource.Remove(row);
            }*/
            // utilisateurBindingSource.RemoveCurrent();
        }

       
    }
}
