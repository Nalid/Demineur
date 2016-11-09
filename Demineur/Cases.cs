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
        private int nbrClick = 0;
        public int id;
        public int BBsAutour;// nb de bombes entourant la case 
        public static Form1 mainform;


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
                if (this.BackgroundImage.Tag == "VIDE3")
                {
                    this.BackgroundImage = Properties.Resources.Flag;
                    
                }
                if(this.BackgroundImage.Tag == "Flag")
                {
                    this.BackgroundImage = Properties.Resources.VIDE3;
                }
            }
            if(e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                
                if (_bombe == true)
                {
                    this.Text = "X";

                }
                else
                {
                    this.Reveal(BBsAutour);

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
            // revele le nombre de bombes alentours   ( appelé par la methode onclick)
            switch (BBsAutour)
            {
                default:
                    break;
                case 0:
                    this.Text = "0";
                    mainform.Revealextend(this.id);

                    // plus tard : change l'image en "case vide "

                    break;
                case 1:
                    this.Text = "1";

                    // plus tard : change l'image en "case 1 bombe a coté "

                    break;
                case 2:
                    this.Text = "2";

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
        public void Reveal(int NbBombeAutour,bool bug)
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
                    this.Text = "1";

                    // plus tard : change l'image en "case 1 bombe a coté "

                    break;
                case 2:
                    this.Text = "2";

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

    }
}
