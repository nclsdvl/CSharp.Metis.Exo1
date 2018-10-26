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
    public partial class frmPrinc : Form
    {
        Timer tim;
        int count = 0;
        public frmPrinc()
        {
            InitializeComponent();
            
        }


    private void InitializeTimer()
        {
            tim = new Timer();
            tim.Interval = 1000;
            tim.Start();
            this.tim.Tick += new EventHandler(RemplissageTB);


        }

        private void RemplissageTB(object sender, EventArgs e)
        {
            count++;
            tbChrono.Text = count.ToString();
        }

        private void tbAleatoire_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmPrinc_Load(object sender, EventArgs e)
        {
            InitializeTimer();
        }
    }
}
