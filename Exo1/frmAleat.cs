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
    public partial class frmAleat : Form
    {
        //TextBox tbAleatoire;

        public frmAleat()
        {
            InitializeComponent();
        }

        private void frmAleat_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((frmMDI)this.MdiParent).frmAleat = null;
        }

        public void SetAleat (String A)
        {
            this.tbNbrA.Text = A;
        }


        public void SetNewAleat(String monNBR)
        {
            this.tbNbrA.Text = monNBR.ToString();
        }

        private void btnActualiser_Click(object sender, EventArgs e)
        {
            this.tbNbrA.Text = frmPrinc.monNBR.ToString(".##########");
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        //public void btnActualiser_Click(String A)
        //{
        //    this.tbNbrA.Text = A;
        //    this.Close();
        //}

        //public void btnActualiser_Click(String A)
        //{
        //    this.tbNbrA.Text = "";
        //}


    }
}
