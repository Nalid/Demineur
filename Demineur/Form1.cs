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
        // variable pour le timer
        int timCounter;

        //estethique des cases 
        const int LARGEURcase = 25;
        const int HAUTEURcase = 25;

        // nombres de cases 
        int LARGEURgrille;
        int HAUTEURgrille;

        // estetique de la forme, marge du haut et de gauche 
        const int MARGEX = 30;
        const int MARGEY = 30;

        // nombre de bombes
        int nbbombe;

        //autres utiles pour le code 
        int idcases = 0; // nombre de base !! pas toucher !!
        Random rdmbombe = new Random(); // random pour placer les bombes 
        
        List<Cases> caseslist = new List<Cases>();// les des cases du jeu 

        // List<int> caserevealed = new List<int>();// utile pour les 0 

        Point pos = new System.Drawing.Point();//point pour positionner les cases

        // image de remplissage par default des cases , supprimer plus tard, alpha uniquement 
        Image imageFond = null;

        public Form1()
        {
            InitializeComponent();
           
        }

        private void tsmDebutant_Click(object sender, EventArgs e)
        {
            tsmIntermediaire.Checked = false;
            tsmExpert.Checked = false;
            tsmDebutant.Checked = true;
            LARGEURgrille = 9;
            HAUTEURgrille = 9;
            nbbombe = 10;
            NewGame();
        }

        private void tsmIntermediaire_Click(object sender, EventArgs e)
        {
            tsmExpert.Checked = false;
            tsmDebutant.Checked = false;
            tsmIntermediaire.Checked = true;
            LARGEURgrille = 16;
            HAUTEURgrille = 16;
            nbbombe = 40;
            NewGame();
        }

        private void tsmExpert_Click(object sender, EventArgs e)
        {
            tsmExpert.Checked = true;
            tsmDebutant.Checked = false;
            tsmIntermediaire.Checked = false;
            LARGEURgrille = 16;
            HAUTEURgrille = 30;
            nbbombe = 99;
            NewGame();
        }

        private void tsmCustom_Click(object sender, EventArgs e)
        {

        }

        // ceci est un commentaire
        private void Form1_Load(object sender, EventArgs e)
        {
            // creer le terrain, pose les bombes, puis  attribut le num au case(nmbre de bombes alentour pour chaque case )
            
            
        }

        public void NewGame()
        {
            CreeGrille(LARGEURgrille, HAUTEURgrille);
            minerterrain(nbbombe);
            CountAutour();
            playSound("..\\..\\Resources\\The_Body_Bome_The_Hurt_Locker.wav");
            tim.Enabled = true;
            pbHorloge.Visible = true;
            timCounter = 0;
            
        }

        public void CreeGrille(int largeur, int hauteur)
        {
            // vider tout
            foreach (var caze in caseslist)
            {
                caze.Dispose();
            }
            caseslist.Clear();

            idcases = 0; //reinit


            // creation de la grille et des toutes les cases 
            for (int i = 0; i < largeur; i++)
            {
                //Crée une liste
                for (int j = 0; j < hauteur; j++)
                {
                    Cases cases = new Cases(this, imageFond);// creation de la listes des cases 
                    pos.X = LARGEURcase * j + MARGEX;
                    pos.Y = HAUTEURcase * i + MARGEY;
                    cases.Location = pos;//position de la case 
                    cases.Width = LARGEURcase;
                    cases.Height = HAUTEURcase;

                    cases.id = idcases;

                    caseslist.Add(cases);

                    idcases++;
                }
            }
           
        }

        // methode pour poser les bombes sur le terrain
        public void minerterrain(int nbmines)
        {
            for (int i = 0; i < nbmines; i++)
            {
                int bombeid = rdmbombe.Next(0, idcases);
                foreach (var caze in caseslist)
                {
                    if (caze.id == bombeid)
                    {
                        caze.Bombe = true;
                    }
                }

            }
            
        }

        public void CountAutour()
        {
            // cherche le nombre de bombes autour de la case en vue d'afficher le numero une fois la case cliquée 



            // empplacement des cases par rapport a la centrale (celle cliquée)
            /*
             * haut gauche  =  (caze.id - (LARGEURgrille + 1))
             * gauche       =  (caze.id - 1)
             * bas gauche   =  (caze.id + LARGEURgrille - 1)
             * haut         =  (caze.id - 10)
             * bas          =  (caze.id + LARGEURgrille)
             * haut droite  =  (caze.id - (LARGEURgrille - 1))
             * droite       =  (caze.id + 1)
             * bas droite   =  (caze.id + (LARGEURgrille + 1))
             * 
             */



            // peut etre pas fini

            foreach (var caze in caseslist)
            {
                int NbAutour = 0;
                // cherche en haut a gauche
                foreach (var caseatrouver in caseslist)
                {
                    if (caze.id % LARGEURgrille == 0)// si est pas en bout de grille
                    {
                        break;
                    }
                    else if (caseatrouver.id == (caze.id - (LARGEURgrille + 1)))
                    {
                        // si la case a coté de la case selecitonnée a une bombe 
                        if (caseatrouver.Bombe == true)
                        {
                            NbAutour++;
                        }

                        break;
                    }
                }
                // cherche a gauche
                foreach (var caseatrouver in caseslist)
                {
                    if (caze.id % LARGEURgrille == 0)// si est pas en bout de grille
                    {
                        break;
                    }
                    else if (caseatrouver.id == (caze.id - 1))
                    {
                        if (caseatrouver.Bombe == true)
                        {
                            NbAutour++;
                        }

                        break;
                    }
                }
                // cherche en bas a gauche
                foreach (var caseatrouver in caseslist)
                {
                    if (caze.id % LARGEURgrille == 0)// si est pas en bout de grille
                    {
                        break;
                    }
                    else if (caseatrouver.id == (caze.id + LARGEURgrille - 1))
                    {
                        // si la case a coté de la case selecitonnée a une bombe 
                        if (caseatrouver.Bombe == true)
                        {
                            NbAutour++;
                        }

                        break;
                    }
                }
                // cherche en haut
                foreach (var caseatrouver in caseslist)
                {
                    if (caze.id - LARGEURgrille < 0)// si est pas en bout de grille
                    {
                        break;
                    }
                    else if (caseatrouver.id == (caze.id - LARGEURgrille))
                    {
                        // si la case a coté de la case selecitonnée a une bombe 
                        if (caseatrouver.Bombe == true)
                        {
                            NbAutour++;
                        }

                        break;
                    }
                }
                // cherche en bas
                foreach (var caseatrouver in caseslist)
                {
                    if (caze.id + LARGEURgrille > (HAUTEURgrille * LARGEURgrille))// si est pas en bout de grille
                    {
                        break;
                    }
                    if (caseatrouver.id == (caze.id + LARGEURgrille))
                    {
                        // si la case a coté de la case selecitonnée a une bombe 
                        if (caseatrouver.Bombe == true)
                        {
                            NbAutour++;
                        }

                        break;
                    }
                }
                // cherche en haut a droite
                foreach (var caseatrouver in caseslist)
                {
                    if ((caze.id + 1) % LARGEURgrille == 0)// si est pas en bout de grille
                    {
                        break;
                    }
                    else if (caseatrouver.id == (caze.id - (LARGEURgrille - 1)))
                    {
                        // si la case a coté de la case selecitonnée a une bombe 
                        if (caseatrouver.Bombe == true)
                        {
                            NbAutour++;
                        }

                        break;
                    }
                }
                // cherche a droite
                foreach (var caseatrouver in caseslist)
                {
                    if ((caze.id + 1) % LARGEURgrille == 0)// si est pas en bout de grille
                    {
                        break;
                    }
                    else if (caseatrouver.id == (caze.id + 1))
                    {
                        // si la case a coté de la case selecitonnée a une bombe 
                        if (caseatrouver.Bombe == true)
                        {
                            NbAutour++;
                        }

                        break;
                    }
                }
                // cherche en bas a droite
                foreach (var caseatrouver in caseslist)
                {
                    if ((caze.id + 1) % LARGEURgrille == 0)// si est pas en bout de grille
                    {
                        break;
                    }
                    else if (caseatrouver.id == (caze.id + (LARGEURgrille + 1)))
                    {
                        // si la case a coté de la case selecitonnée a une bombe 
                        if (caseatrouver.Bombe == true)
                        {
                            NbAutour++;
                        }

                        break;
                    }
                }

                // inscris le nombre de bombes a coté de la case dans le parametre de la case
                caze.BBsAutour = NbAutour;

            }

        }

        public void Revealextend(int id0)
        {
            // empplacement des cases par rapport a la centrale (celle cliquée)
            /*
             * haut gauche  =  (caze.id - (LARGEURgrille + 1))
             * gauche       =  (caze.id - 1)
             * bas gauche   =  (caze.id + LARGEURgrille - 1)
             * haut         =  (caze.id - LARGEURgrille)
             * bas          =  (caze.id + LARGEURgrille)
             * haut droite  =  (caze.id - (LARGEURgrille - 1))
             * droite       =  (caze.id + 1)
             * bas droite   =  (caze.id + (LARGEURgrille + 1))
             */

            foreach (var caze in caseslist)
            {
                if (caze.id == (id0 - (LARGEURgrille + 1)) && id0 % LARGEURgrille != 0
                    || (caze.id == (id0 - 1) && id0 % LARGEURgrille != 0)
                    || (caze.id == (id0 + LARGEURgrille - 1) && id0 % LARGEURgrille != 0)
                    || caze.id == (id0 - LARGEURgrille)
                    || caze.id == (id0 + LARGEURgrille)
                    || (caze.id == (id0 - (LARGEURgrille - 1)) && (id0 + 1) % LARGEURgrille != 0)
                    || (caze.id == (id0 + 1) && (id0 + 1) % LARGEURgrille != 0)
                    || (caze.id == (id0 + (LARGEURgrille + 1)) && (id0 + 1) % LARGEURgrille != 0)
                    )
                {


                    if (caze.isrevealed == false)
                    {
                        caze.Reveal();
                        
                    }

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
            DialogResult exitApp = MessageBox.Show("Voulez-vous vraiment quitter?", "Quitter", MessageBoxButtons.YesNo);

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
        /// <summary>
        /// Permet de jouer du son avec des fichiers .WAV
        /// </summary>
        /// <param name="path">C'est le chemin du fichier dans les ressources</param>
        public void playSound(string path)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = path;
            player.Load();
            player.Play();
        }

        public void gameover()
        {
            MessageBox.Show("vous avez perdu");
            NewGame();
            

        }
        public void IsitFinish()
        {
            int nbrevealed = 0;
            foreach (var caze in caseslist)
            {
                if (caze.isrevealed == true)
                {
                    nbrevealed++;
                }
                // si toutes les cases non bombes sont revélées 
                if (nbrevealed >= (LARGEURgrille*HAUTEURgrille)-nbbombe)
                {
                    GameWin();
                    break;
                }
            }
        }
        // fonction de victoire 
        public void GameWin()
        {
            MessageBox.Show("vous avez gagné");
            NewGame();
        }

        private void tim_Tick(object sender, EventArgs e)
        {
            timCounter += 1;
            lblHorlogeUp.Text = timCounter.ToString();
        }
    }
}
