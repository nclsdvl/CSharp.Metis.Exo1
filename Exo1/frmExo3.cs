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


    }
}
