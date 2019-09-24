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
    public partial class frmGestionUtilisateurs : Form

    {
        frmAjouterUtilisateur frmAjout = new frmAjouterUtilisateur();
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



        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (frmAjout==null)
            {
                frmAjout = new frmAjouterUtilisateur();
            }
            BDTP1Guelleh_MarreroDataSet.UtilisateurRow unUtilisateur = bDTP1Guelleh_MarreroDataSet.Utilisateur.NewUtilisateurRow();

            decimal noUtilisateurMax = 0;
            foreach (BDTP1Guelleh_MarreroDataSet.UtilisateurRow uneLigne in bDTP1Guelleh_MarreroDataSet.Utilisateur.Rows)
                if (uneLigne.NoUtilisateur > noUtilisateurMax) noUtilisateurMax = uneLigne.NoUtilisateur;

            //Valeur du plus grand no utilisateur = MAX(noUtilisateur)+1
            unUtilisateur.NoUtilisateur = Convert.ToInt32(noUtilisateurMax+1);

           


            frmAjout.strValeur = "a";
            frmAjout.unUtilisateur = unUtilisateur;
           if( frmAjout.ShowDialog()== DialogResult.OK)
            {

               // MessageBox.Show("allo");
                if (unUtilisateur.NoUtilisateur != -1)
                {
                    bDTP1Guelleh_MarreroDataSet.Utilisateur.AddUtilisateurRow(unUtilisateur);
                   // MessageBox.Show("bonjour");

                    utilisateurBindingSource.MoveLast();

                    this.utilisateurTableAdapter.Update(this.bDTP1Guelleh_MarreroDataSet.Utilisateur);
                    MessageBox.Show("L'utilisateur " + unUtilisateur.NoUtilisateur.ToString() + " a été ajouté", "Ajout d'un utilisateur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
        
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
          if(frmAjout== null)
            {
                 frmAjout = new frmAjouterUtilisateur();
            }
          
           
           
                frmAjout.strValeur = "b";

                
                frmAjout.Show();

            





        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
           
            foreach (var row in utilisateurBindingSource)
            {
                utilisateurBindingSource.Remove(row);
            }
           // utilisateurBindingSource.RemoveCurrent();
        }

        private void utilisateurBindingSource_PositionChanged(object sender, EventArgs e)
        {
            
            frmAjout.strValeur = "b";


            int noUtilisateur = utilisateurBindingSource.Position;
            int nbUtilisateurs = utilisateurBindingSource.Count;

            if (noUtilisateur >= 0 && noUtilisateur < nbUtilisateurs)
            {
            
                dynamic utilisateurSelectionne = utilisateurBindingSource.Current;

                frmAjout.strNomUtilisateur = utilisateurSelectionne["NomUtilisateur"];
                frmAjout.strMotdePasse = utilisateurSelectionne["MotDePasse"];


                //MessageBox.Show(frmAjout.strMotdePasse);

                //MessageBox.Show(strNomUtilisateur);

            }
          //  frmAjout.Show();
           
        }
    }
}
