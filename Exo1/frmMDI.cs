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

        public Form frmChrono;
        frmPrinc frmPrinc;


        public frmMDI()
        {
            InitializeComponent();



            //this.frmChrono = new frmChrono();
            //this.frmChrono.MdiParent = this;
            //this.frmChrono.Show();
        }





        private void frmMDI_Load(object sender, EventArgs e)
        {
            
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
                ((frmChrono)this.frmChrono).SetTimeStamp(frmPrinc.count);
            }
            else
            {
                this.frmChrono.Activate();
            }
            
        }

    }
        }
    