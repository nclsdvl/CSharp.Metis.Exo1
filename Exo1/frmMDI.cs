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
        public Form frmAleat;
        public int A;
        //internal object tbAleatoire;

        public frmMDI()
        {
            InitializeComponent();



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

        private void nombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.frmAleat == null)
            {
                frmAleat = new frmAleat();
                frmAleat.MdiParent = this;
                frmAleat.Show();
                ((frmAleat)this.frmAleat).SetAleat(frmPrinc.A);
            }
            else
            {
                this.frmAleat.Activate();
            }
        }

        private void aProposDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox1 = new AboutBox1();
            //aboutBox1.MdiParent = this;
            
            aboutBox1.ShowDialog();
        }
    }
        }
    