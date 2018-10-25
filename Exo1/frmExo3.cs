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
    public partial class frmExo3 : Form
    {
        private void Init()
        {
            this.cbxSource.Items.Clear();
            this.cbxSource.Items.Add("France");
            this.cbxSource.Items.Add("Belgique");
            this.cbxSource.Items.AddRange(new String[] { "Allemagne", "Japon", "Portugal", "Grece"});
        }

        public frmExo3()
        {
            InitializeComponent();
            this.Init();
            
        }

        private void btnAjoute_Click(object sender, EventArgs e)
        {
           
            
            if (cbxSource.SelectedItem != null)
            {
                this.lstCible.Items.Add(this.cbxSource.SelectedItem);
                this.cbxSource.Items.Remove(this.cbxSource.SelectedItem);
                this.cbxSource.Text = null;
                this.btnSupprime.Enabled = true;
                this.btnSupprimeTout.Enabled = true;
                this.lstCible.Enabled = true;
                if (cbxSource.Items.Count == 0)
                {
                    this.cbxSource.Enabled = false;
                    this.btnAjoute.Enabled = false;
                    this.btnAjouteTout.Enabled = false;
                }

            }
            if (cbxSource.Items.Count == 0)
            {
                this.btnAjoute.Enabled = false;
                this.btnAjouteTout.Enabled = false;
            }
        }

        private void btnAjouteTout_Click(object sender, EventArgs e)
        {
            if (this.cbxSource.Items.Count != 0)
            {
                foreach (Object element in this.cbxSource.Items)
                {
                    this.cbxSource.Text = null;
                    this.lstCible.Items.Add(element);
                }
                
                this.cbxSource.Items.Clear();
                this.lstCible.Enabled = true;
                this.cbxSource.Enabled = false;
                this.btnAjoute.Enabled = false;
                this.btnAjouteTout.Enabled = false;
                this.btnSupprimeTout.Enabled = true;
                this.btnSupprime.Enabled = true;
            }


        }

        private void btnSupprime_Click(object sender, EventArgs e)
        {
            if (lstCible.Items.Count == 0)
            {
                this.btnSupprimeTout.Enabled = false;
                this.btnSupprime.Enabled = false;
            }

            if (this.lstCible.SelectedItem != null)
            {
                this.cbxSource.Enabled = true;
                this.cbxSource.Items.Add(this.lstCible.SelectedItem);
                this.lstCible.Items.Remove(this.lstCible.SelectedItem);
                this.btnAjoute.Enabled = true;
                this.btnAjouteTout.Enabled = true;

                if (lstCible.Items.Count == 0)
                {
                    this.lstCible.Enabled = false;
                    this.btnSupprimeTout.Enabled = false;
                    this.btnSupprime.Enabled = false;
                }
            }
            

        }

        private void btnSupprimeTout_Click(object sender, EventArgs e)
        {

            if (lstCible.Items.Count != 0)
            {
                this.cbxSource.Enabled = true;
                foreach (Object elements in this.lstCible.Items)
                {
                    this.cbxSource.Items.Add(elements);
                }
                this.lstCible.Items.Clear();
                
                this.btnAjoute.Enabled = true;
                this.btnAjouteTout.Enabled = true;

                this.btnSupprime.Enabled = false;
                this.btnSupprimeTout.Enabled = false;
            }

            this.lstCible.Enabled = false;
        }

        private void btnHaut_Click(object sender, EventArgs e)
        {
            if (this.lstCible.SelectedItem != null)
            {
                try
                {
                    Object monChoixAMonter = this.lstCible.SelectedItem;

                    this.lstCible.Items[this.lstCible.SelectedIndex] = this.lstCible.Items[this.lstCible.SelectedIndex  -1];
                    this.lstCible.Items[this.lstCible.SelectedIndex -1] = monChoixAMonter;
                    this.lstCible.SelectedIndex--;
                }
                catch (ArgumentOutOfRangeException)
                {

                }
            }
        }

        private void btnBas_Click(object sender, EventArgs e)
        {
            if (this.lstCible.SelectedItem != null)
            {
                try
                {
                    Object monChoixAMonter = this.lstCible.SelectedItem;

                    this.lstCible.Items[this.lstCible.SelectedIndex] = this.lstCible.Items[this.lstCible.SelectedIndex + 1];
                    this.lstCible.Items[this.lstCible.SelectedIndex + 1] = monChoixAMonter;
                    this.lstCible.SelectedIndex++;
                }
                catch (ArgumentOutOfRangeException)
                {

                }
            }
        }
    }
}
