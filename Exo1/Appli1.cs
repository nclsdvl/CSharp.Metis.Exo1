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
    public partial class Appli1 : Form
    {
        public Appli1()
        {
            InitializeComponent();
            rbTour100.Checked = true;
            rbTemp50.Checked = true;
            gbxParametres.Visible = false;
            tbTemperature.Enabled = false;
            tbVitesse.Enabled = false;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            gbxParametres.Visible = true;
            gbxTemp.Enabled = false;
            gbxVitesse.Enabled = false;



            if (this.rbTour100.Checked == true)
                {
                tbVitesse.Text = "100";
                }
            else if (this.rbTour200.Checked == true)
                {
                tbVitesse.Text = "200";
            }
            else if (this.rbTour300.Checked == true)
                {
                tbVitesse.Text = "300";
            }
            else
                {
                tbVitesse.Text = "500";
            }


            if (this.rbTemp50.Checked == true)
            {
                tbTemperature.Text = "50";
            }
            else if (this.rbTemp80.Checked == true)
            {
                tbTemperature.Text = "80";
            }
            else
            {
                tbTemperature.Text = "100";
            }

        }

        private void btnRetablir_Click(object sender, EventArgs e)
        {
            rbTour100.Checked = true;
            rbTemp50.Checked = true;
            gbxParametres.Visible = false;
            tbVitesse.Text = "";
            tbTemperature.Text = "";
            tbTemperature.Enabled = false;
            tbVitesse.Enabled = false;
            gbxTemp.Enabled = true;
            gbxVitesse.Enabled = true;
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
