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
    class Cases : Button
    {
        private bool _bombe;
        public int id;
        public int BBsAutour;// nb de bombes entourant la case 

        public bool Bombe
        {
            get { return _bombe; }
            set { _bombe = value; }
        }

        public Cases(Form1 parent, Image image)
        {
            this.Parent = parent;
            Width = 20;
            Height = 20;
            Bombe = false;
        }

        protected override void OnClick(EventArgs e)
        {
            // lorsque cette case est cliquée          |    * en cours 
            if (_bombe == true)
            {
                this.Text = "X";
                playSound("..\\..\\Resources\\Explosion_sound.wav ");

            }
            else
            {
                this.Text = Convert.ToString(BBsAutour);
            }
        }

        //compte le nombre de bombe sur les 8 cases qui entour la case en queestion  | remplacée par la funciton lancée par la fenetre qui le fait en debut de partie 
        public void Count()
        {

        }

        public void Reveal(int NbBombeAutour)
        {
            // revele le nombre de bombes alentours   ( appelé par la methode onclick)
            switch (NbBombeAutour)
            {
                default:
                    break;
                case 0:
                    this.Text = "0";

                    // plus tard : change l'image en "case vide "

                    break;
                case 1:
                    this.BackgroundImage = Properties.Resources.un;
                    BackgroundImageLayout = ImageLayout.Stretch;
                    // plus tard : change l'image en "case 1 bombe a coté "

                    break;
                case 2:
                    this.Text = "10";
                    this.BackgroundImage = Properties.Resources.deux;

                    // plus tard : change l'image en "case 2 bombes a coté  "

                    break;
                case 3:
                    this.Text = "3";
                    break;
                case 4:
                    this.Text = "4";
                    break;
                case 5:
                    this.Text = "5";
                    break;
                case 6:
                    this.Text = "6";
                    break;
                case 7:
                    this.Text = "7";
                    break;
                case 8:
                    this.Text = "8";
                    break;
            }
        }

        private void playSound(string path)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = path;
            player.Load();
            player.Play();
        }
    }
}
