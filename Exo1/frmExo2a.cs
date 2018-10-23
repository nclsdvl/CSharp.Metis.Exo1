using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exo1
{
    /// <summary>
    /// Exercice sur le fctionement d'une checkbox
    /// groupbox
    /// </summary>
    public partial class frmExo2a : Form
    {
        public frmExo2a()
        {
            InitializeComponent();
            this.Height = 300;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.gbxCouleur.Visible = this.chkModifier.Checked;

            this.Height = this.chkModifier.Checked ? 460 : 300 ;
  
        }

        private void rbtRouge_CheckedChanged(object sender, EventArgs e)
        {
            this.lblCouleur.BackColor = System.Drawing.Color.Red;
        }

        private void rbtVert_CheckedChanged(object sender, EventArgs e)
        {
            this.lblCouleur.BackColor = System.Drawing.Color.Green;
        }

        private void rbtBleu_CheckedChanged(object sender, EventArgs e)
        {
            this.lblCouleur.BackColor = System.Drawing.Color.Blue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmExo2b x = new frmExo2b();
            x.Show();
        }
    }
}
