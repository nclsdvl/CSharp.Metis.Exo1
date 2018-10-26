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
    public partial class frmChrono : Form
    {
        public frmChrono()
        {
            InitializeComponent();
            //this.tbChrono.Text = frmPrinc.count.ToString();
        }

        private void frmChrono_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((frmMDI)this.MdiParent).frmChrono = null;
        }

        public void SetTimeStamp(int t)
        {
            this.tbChrono.Text = t.ToString();
        }


        private void btnActualiser_Click(object sender, EventArgs e)
        {
            this.tbChrono.Text = frmPrinc.count.ToString();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
