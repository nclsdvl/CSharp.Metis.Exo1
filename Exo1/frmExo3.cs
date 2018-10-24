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
            this.lstCible.Items.Add(this.cbxSource.SelectedItem);
            this.cbxSource.Items.Remove(this.cbxSource.SelectedItem);
        }

        private void btnAjouteTout_Click(object sender, EventArgs e)
        {
            foreach (Object element in this.cbxSource.Items)
            {
                this.lstCible.Items.Add(element);
            }
            this.cbxSource.Items.Clear();

        }

        private void btnSupprime_Click(object sender, EventArgs e)
        {
            if (lstCible.SelectedItems == "")
            {

            }
            else
            {
                this.cbxSource.Items.Add(this.lstCible.SelectedItem);
                this.lstCible.Items.Remove(this.lstCible.SelectedItem);
            }

        }

        private void btnSupprimeTout_Click(object sender, EventArgs e)
        {
            foreach (Object element in this.lstCible.Items)
            {
                this.lstCible.Items.Add(this.cbxSource.Items);
            }
            this.lstCible.Items.Clear();
        }
    }
}
