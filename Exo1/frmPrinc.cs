﻿using System;
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
        public int count;
        Random nbrAlea= new Random();

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


        }

        internal void RemplissageTB(object sender, EventArgs e)
        {
            count++;
            tbChrono.Text = count.ToString();
        }

        private void tbAleatoire_TextChanged(object sender, EventArgs e)
        {

        }

        internal void frmPrinc_Load(object sender, EventArgs e)
        {
            InitializeTimer();
            double monNBR = nbrAlea.NextDouble();
            tbAleatoire.Text = monNBR.ToString(".##########");

        }
    }
}
