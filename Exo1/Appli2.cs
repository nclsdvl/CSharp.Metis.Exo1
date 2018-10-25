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
    public partial class Appli2 : Form
    {
        public Appli2()
        {
            InitializeComponent();
            this.cbxVitesse.Items.AddRange(new String[] { "100", "200", "300", "500" });
            this.cbxVitesse.SelectedIndex = 0;
            this.cbxTemperature.Items.AddRange(new String[] { "50", "80", "100" });
            this.cbxTemperature.SelectedIndex = 0;
            gbxParametre.Visible = false;
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbxVitesse_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.tbVitesse.Text = this.cbxVitesse.Text;

        }


        private void cbxTemperature_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.tbTemperature.Text = this.cbxTemperature.Text;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            gbxParametre.Visible = true;
        }

        private void btnRetablir_Click(object sender, EventArgs e)
        {
            gbxParametre.Visible = false;
            this.tbTemperature.Text = "";
            this.tbVitesse.Text = "";
            this.cbxVitesse.SelectedIndex = 0;
            this.cbxTemperature.SelectedIndex = 0;
        }
    }
}
