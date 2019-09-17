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
    public partial class MenuPrepose : Form
    {
        public MenuPrepose()
        {
            InitializeComponent();
        }

        private void btnQuitterPrepose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
