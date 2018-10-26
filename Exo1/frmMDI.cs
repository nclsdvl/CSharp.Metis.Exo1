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
    public partial class frmMDI : Form
    {
        private int childFormNumber = 0;
        public Form frmChrono;

        public frmMDI()
        {
            InitializeComponent();



            //this.frmChrono = new frmChrono();
            //this.frmChrono.MdiParent = this;
            //this.frmChrono.Show();
        }





        private void frmMDI_Load(object sender, EventArgs e)
        {
            frmPrinc frmPrinc;
            frmPrinc = new frmPrinc();
            frmPrinc.MdiParent = this;
            frmPrinc.Show();
        }



        private void chronoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.frmChrono == null)
            {
                this.frmChrono = new frmChrono();
                this.frmChrono.MdiParent = this;
                this.frmChrono.Show();
            }
            else
            {
                this.frmChrono.Activate();
            }
        }

    }
        }
    