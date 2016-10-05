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
        //estethique des cases 
        const int LARGEURcase = 45;
        const int HAUTEURcase = 45;

        // nombres de cases 
        const int LARGEURgrille = 10;
        const int HAUTEURgrille = 10;

        // estetique de la forme, marge du haut et de gauche 
        const int MARGEX = 30;
        const int MARGEY = 30;

        // nombre de bombes
        int nbbombe = 20;

        //autres utiles pour le code 
        int idcases = 0; // nombre de base !! pas toucher !!
        Random rdmbombe = new Random(); // random pour placer les bombes 
        List<Cases> caseslist = new List<Cases>();// les des cases du jeu 
        Point pos = new System.Drawing.Point();//point pour positionner les cases

        // image de remplissage par default des cases , supprimer plus tard, alpha uniquement 
        Image imageFond = Properties.Resources.VIDE3;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // creer le terrain, pose les bombes, puis  attribut le num au case(nmbre de bombes alentour pour chaque case )
            CreeGrille(LARGEURgrille, HAUTEURgrille);
            minerterrain(nbbombe);
            CountAutour();
        }

        public void CreeGrille(int largeur, int hauteur)
        {
            // creation de la grille et des toutes les cases 
            for (int i = 0; i < largeur; i++)
            {
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
                    else if (caseatrouver.id == (caze.id - 10))
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
    }
}
