using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Echiquier_de_Bezzel
{
    public static class Algorithme
    {
        public static int essai = 0;
        public static int essaiGénérationAvancée = 0;
        public static List<string> casesTouchées = new List<string>();
        public static List<BoardInformation> results = new List<BoardInformation>();
        public static Random rnd = new Random();

        /// <summary>
        /// Check toutes les cases et essai de rentrer une reine dedans si rien la touche
        /// </summary>
        /// <param name="cases"></param>
        public static List<BoardInformation> setCaseWithQueen(Case[,] cases, int queenVoulu = 0, int essai_avancée = 0)
        {            
            // Toutes les cases auquel on ne peut pas ajouter de reine
            casesTouchées.Clear();
            essai++;

            List<string> queenPosition = new List<string>();
            int queenGénérer = 0;

            for (int height = 0; height < cases.GetLength(0); height++)
            {
                for (int length = 0; length < cases.GetLength(1); length++)
                {
                    int rd = rnd.Next(0, cases.GetLength(1));

                    if (height == 0 && rd < cases.GetLength(1))
                    {
                        length = rd;
                    }
                    else if (height == 1 && rd < cases.GetLength(1))
                    {
                        length = rd;
                    }
                    else if (height == 2 && rd < cases.GetLength(1))
                    {
                        length = rd;
                    }

                    // Si aucune correpond
                    if (!casesTouchées.Contains(height + "," + length))
                    {
                        queenGénérer++;

                        List<string> caseAssiciée = new List<string>();
                        // Alors on peut y ajouter une queen
                        cases[height, length].SetQueen(true);
                        queenPosition.Add(height + "," + length);

                        // Et on bannit toutes les cases que la queen touche
                        // Partout en haut
                        for (int i = height; i > 0; i--)
                        {
                            casesTouchées.Add(i + "," + length);
                            caseAssiciée.Add(i + "," + length);
                        }

                        // Partout en bas
                        for (int i = 0; i < cases.GetLength(0); i++)
                        {
                            casesTouchées.Add(i + "," + length);
                            caseAssiciée.Add(i + "," + length);
                        }

                        // Partour sur le coté gauche
                        for (int i = length; i > 0; i--)
                        {
                            casesTouchées.Add(height + "," + i);
                            caseAssiciée.Add(height + "," + i);
                        }

                        // Partout sur le coté droit
                        for (int i = 0; i < cases.GetLength(1); i++)
                        {
                            casesTouchées.Add(height + "," + i);
                            caseAssiciée.Add(height + "," + i);
                        }

                        // Diagonale haut gauche
                        int h = height;
                        int w = length;
                        while (h > 0 && w > 0)
                        {
                            h--;
                            w--;
                            casesTouchées.Add(h + "," + w);
                            caseAssiciée.Add(h + "," + w);
                        }

                        // Diagonale haut droit
                        int h1 = height;
                        int w1 = length;
                        while (h1 > 0 && w1 > 0)
                        {
                            h1--;
                            w1++;
                            casesTouchées.Add(h1 + "," + w1);
                            caseAssiciée.Add(h1 + "," + w1);
                        }

                        // Diagonale bas gauche
                        int h2 = height;
                        int w2 = length;
                        while (h2 < cases.GetLength(0) && w2 < cases.GetLength(1))
                        {
                            h2++;
                            w2--;
                            casesTouchées.Add(h2 + "," + w2);
                            caseAssiciée.Add(h2 + "," + w2);
                        }

                        // Diagonale bas droit
                        int h3 = height;
                        int w3 = length;
                        while (h3 < cases.GetLength(0) && w3 < cases.GetLength(1))
                        {
                            h3++;
                            w3++;
                            casesTouchées.Add(h3 + "," + w3);
                            caseAssiciée.Add(h3 + "," + w3);
                        }

                        cases[height, length].SetAssicied(caseAssiciée);

                        break;
                    }
                }
            }

            Main main = (Main)Application.OpenForms["Main"];
            main.setInformation_nbReine(queenGénérer);
       
            if(essai_avancée > 0 && essaiGénérationAvancée != essai_avancée)
            {
                // Ajoute un nouveau tableau d'échec à la liste des résultats
                results.Add(new BoardInformation(queenGénérer, queenPosition));

                essaiGénérationAvancée++;
                setCaseWithQueen(cases, essai_avancée: essai_avancée);
            }

            if (queenVoulu != 0 && queenVoulu != queenGénérer && essai < 250)
            {
                for (int height = 0; height < cases.GetLength(0); height++)
                {
                    for (int length = 0; length < cases.GetLength(1); length++)
                    {
                        cases[height, length].SetQueen(false);
                    }
                }
                setCaseWithQueen(cases, queenVoulu);
            }
            else if (essai == 250 && queenVoulu != 0)
            {
                main.tooManyTry();
            }

            return results;
        }
    }
}