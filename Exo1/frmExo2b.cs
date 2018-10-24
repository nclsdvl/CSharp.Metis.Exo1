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
    public partial class frmExo2b : Form
    {
        public frmExo2b()
        {
            
            InitializeComponent();
            
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            int MonCompteur = 0;

            String maPhrase1 = tbxPhrase1.Text.Trim();
            int longueurPhrase1 = maPhrase1.Length;
            Char[] monTableauDeChar1 = maPhrase1.ToCharArray();

            if (tbxMonChar.Text == "")
            {
                MessageBox.Show("Merci d'entrer un caractere à rechercher");
            }
            else
            {
                Char monCaractere1 = Char.Parse(tbxMonChar.Text);
                String maPhrase2 = tbxPhrase2.Text.Trim();
                int longueurPhrase2 = maPhrase2.Length;
                Char[] monTableauDeChar2 = maPhrase2.ToCharArray();

                String maPhrase3 = tbxPhrase3.Text.Trim();
                int longueurPhrase3 = maPhrase3.Length;
                Char[] monTableauDeChar3 = maPhrase3.ToCharArray();


                if (cbxPhrase1.Checked)
                {
                    for (int i = 0; i < longueurPhrase1; i++)
                    {
                        if (monTableauDeChar1[i] == monCaractere1)
                        {
                            MonCompteur++;
                        }
                    }
                }

                if (cbxPhrase2.Checked)
                {
                    for (int i = 0; i < longueurPhrase2; i++)
                    {
                        if (monTableauDeChar2[i] == monCaractere1)
                        {
                            MonCompteur++;
                        }
                    }
                }

                if (cbxPhrase3.Checked)
                {
                    for (int i = 0; i < longueurPhrase3; i++)
                    {
                        if (monTableauDeChar3[i] == monCaractere1)
                        {
                            MonCompteur++;
                        }
                    }
                }
                tbx_Resultat.Text = MonCompteur.ToString();
            }
        }
    }
}
