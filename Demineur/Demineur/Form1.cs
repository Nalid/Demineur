using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demineur
{
    public partial class Form1 : Form
    {
        const int LARGEUR = 40;
        const int HAUTEUR = 40;
        const int MARGEX = 30;
        const int MARGEY = 30;
        Point pos = new System.Drawing.Point();
        Image imageFond = Properties.Resources.VIDE3;

        public Form1()
        {
            InitializeComponent();
        }


        private void tsmCustom_Click(object sender, EventArgs e)
        {

        }
            

        // ceci est un commentaire
        private void Form1_Load(object sender, EventArgs e)
        {
            CreeGrille(LARGEUR, HAUTEUR);
        }

        public void CreeGrille(int largeur, int hauteur)
        {
            for (int i = 0; i < largeur; i++ )
            {
                for (int j = 0; j < hauteur; j++)
                {
                    Cases cases = new Cases(this, imageFond);
                    pos.X = 20 * i + MARGEX;
                    pos.Y = 20 * j + MARGEY;
                    cases.Location = pos;
                }
            }

        }

        private void tsmAide_Click(object sender, EventArgs e)
        {
            Form2 aide = new Form2();
            aide.ShowDialog();
        }

        private void tsmExit_Click(object sender, EventArgs e)
        {
            DialogResult exitApp = MessageBox.Show("Voulez-vous vraiment quitter?","Quitter", MessageBoxButtons.YesNo);

            if (exitApp == DialogResult.Yes)
            {
                Application.Exit();
            }         
        }

        private void tsmPropos_Click(object sender, EventArgs e)
        {
            AboutBox aPropos = new AboutBox();
            aPropos.ShowDialog();
        }
    }
}
