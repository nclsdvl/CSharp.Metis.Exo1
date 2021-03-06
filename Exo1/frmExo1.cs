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
    public partial class FrmExo1 : Form
    {
        private String LeTexte;
        /// <summary>
        /// Constructeur
        /// </summary>
        public FrmExo1()
        {
            InitializeComponent();
            this.LeTexte = "Entrer le texte initial";
        }

        private void btnRecopier_Click(object sender, EventArgs e)
        {
            this.lblResultat.Text = this.txtOriginal.Text;
        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            this.txtOriginal.Text = this.LeTexte;
            this.lblResultat.Text = "";
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmExo1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rep;
            rep = MessageBox.Show("Voulez-vous quittez?", "terminer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rep == DialogResult.No)
            {
                e.Cancel = true;
            };
        }

        private void FrmExo1_Load(object sender, EventArgs e)
        {
            this.txtOriginal.Text = "Entrer le texte original";
        }

        private void txtOriginal_Enter(object sender, EventArgs e)
        {
            this.txtOriginal.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmExo2a frmExo2a = new frmExo2a();
            frmExo2a.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmExo2b frmExo2b = new frmExo2b();
            frmExo2b.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmExo3 frmExo3 = new frmExo3();
            frmExo3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Appli1 Appli1 = new Appli1();
            Appli1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Appli2 Appli2 = new Appli2();
            Appli2.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmMDI frmMDI = new frmMDI();
            frmMDI.Show();


        }
    }
}
