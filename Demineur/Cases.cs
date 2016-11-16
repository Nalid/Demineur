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
        public static Form1 mainform;
        private bool flag = false;

        public bool Flag
        {
            get { return flag; }
            set { flag = value; }
        }


        public bool isrevealed = false; // est revelé ou pas 
        //Form1 parent = Demineur.Form1.;

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
            this.BackgroundImage = image;
            BackgroundImageLayout = ImageLayout.Stretch;
            mainform = parent;

        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            // lorsque cette case est cliquée          |    * en cours 
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (this.isrevealed == true)
                {
                    // tu peux rine faire
                }
                else 
                { 
                     if (flag == false)
                                    {
                                        // met un drapeau 
                                        this.BackgroundImage = Properties.Resources.Flag;
                                        flag = true;
                    
                                    }
                                    else if( flag ==true )
                                    {
                                        this.BackgroundImage = null;
                                        flag = false;
                                    }
                }
            }

            if (this.flag == true)
            {
                // tu fais rine  
            }
            else// clic gauche
            {
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                {

                    if (_bombe == true)
                    {
                        this.BackgroundImage = Properties.Resources.mine;
                        playSound("..\\..\\Resources\\Explosion_sound.wav");
                    }
                    else
                    {
                        this.Reveal(BBsAutour);

                    }
                }
            }
            
        }

        //compte le nombre de bombe sur les 8 cases qui entour la case en queestion  | remplacée par la function lancée par la fenetre qui le fait en debut de partie 
        public void Reveal()
        {
            
                    if (_bombe == true)
                    {
                        this.Text = "X";

                    }
                    else
                    {
                        isrevealed = true;
                        this.Reveal(BBsAutour);
                        
                    }
            
        }

        public void Reveal(int NbBombeAutour)
        {
            isrevealed = true;
            // revele le nombre de bombes alentours   ( appelé par la methode onclick)
            switch (BBsAutour)
            {
                default:
                    break;
                case 0:
                    this.BackgroundImage = Properties.Resources.zero;
                    mainform.Revealextend(this.id);

                    // plus tard : change l'image en "case vide "

                    break;
                case 1:
                    
                    this.BackgroundImage = Properties.Resources.un;
                    // plus tard : change l'image en "case 1 bombe a coté "

                    break;
                case 2:
                    this.BackgroundImage = Properties.Resources.deux;

                    // plus tard : change l'image en "case 2 bombes a coté  "

                    break;
                case 3:
                    this.BackgroundImage = Properties.Resources.trois;
                    break;
                case 4:
                    this.BackgroundImage = Properties.Resources.quatre;
                    break;
                case 5:
                    this.BackgroundImage = Properties.Resources.cinq;
                    break;
                case 6:
                    this.BackgroundImage = Properties.Resources.six;
                    break;
                case 7:
                    this.BackgroundImage = Properties.Resources.sept;
                    break;
                case 8:
                    this.BackgroundImage = Properties.Resources.huit;
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
