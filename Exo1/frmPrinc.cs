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
        public static int count;
        public Random nbrAlea = new Random();
        public String A { get; set; }
        public TextBox tbaleatoire;
        public static double monNBR;


        public frmPrinc()
        {
            InitializeComponent();
            
        }


    internal void InitializeTimer()
        {
            tim = new Timer();
            tim.Interval = 1000;
            tim.Start();

            this.tim.Tick += new EventHandler(RemplissageTB);
            this.tim.Tick += new EventHandler(RemplissageAleat);
        }

        public void RemplissageAleat(object sender, EventArgs e)
        {
            monNBR = nbrAlea.NextDouble();
            A = monNBR.ToString(".##########");
            tbAleatoire.Text = A;
        }

        public void RemplissageTB(object sender, EventArgs e)
        {
            count++;
            tbChrono.Text = count.ToString();
        }

        private void tbAleatoire_TextChanged(object sender, EventArgs e)
        {

        }

        public void frmPrinc_Load(object sender, EventArgs e)
        {
            InitializeTimer();


        }
    }
}
