﻿using System;
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
    public partial class MenuAdmin : Form
    {

        frmGestionUtilisateurs frmGestionUtil = new frmGestionUtilisateurs();
        frmGestionDesAssistantEtSoins frmGererAsstantEtSoins = new frmGestionDesAssistantEtSoins();
        frmGestionDesSoinsSeul frmGestionSoinsSeul = new frmGestionDesSoinsSeul();
        frmGestionDesChambres frmGestionChambres = new frmGestionDesChambres();

        
        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void optionsAdministrateursToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnQuitterAdmin_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void btnDeconnexionAdmin_Click(object sender, EventArgs e)
        {
            this.Close();


        }

        private void gérerLesUtilisateursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGestionUtil.ShowDialog();
            this.Show();
        }

        private void MenuAdmin_Load(object sender, EventArgs e)
        {
            //allo
        }

        private void gérerLesAssistantsEtLesSoinsQuilsOffrentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGererAsstantEtSoins.ShowDialog();
            this.Show();
        }

        private void gérerLesSoinsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGestionSoinsSeul.ShowDialog();
            this.Show();
        }

        private void gérerLesChambresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGestionChambres.ShowDialog();
            this.Show();
        }
    }
}
