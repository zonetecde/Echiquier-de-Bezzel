using System.Drawing;
using System.Windows.Forms;

namespace Echiquier_de_Bezzel
{
    public static class Board
    {
        public static Case[,] GenerateBoard(byte longueur, byte hauteur, byte sizeCase, Panel panel)
        {
            Case[,] board = new Case[hauteur, longueur];
            // Permet de centrer dans le panel
            Point location = new Point(((panel.Width / 2) - (longueur * (sizeCase / 2))), 0);

            // Pour toutes les hauteurs du tableau
            for (byte height = 0; height < hauteur; height++)
            {
                // Pour toutes les cases en longueur du tableau
                for (byte length = 0; length < longueur; length++)
                {
                    // On crée une nouvelle case
                    board[height, length] = new Case(colorFor(height, length), new int[2] { height, length });
                    board[height, length].Location = location;
                    board[height, length].Size = new Size(sizeCase, sizeCase);
                    board[height, length].Anchor = (AnchorStyles.Top);
                    location.X += board[height, length].Width;
                }

                location.Y += sizeCase;
                // Permet de centrer dans le panel
                location.X = ((panel.Width / 2) - (longueur * (sizeCase / 2)));
            }

            return board;
        }

        /// <summary>
        /// Permet de savoir si la case doit être colorier en jaune ou en rien
        /// </summary>
        /// <param name="hauteur">Hauteur</param>
        /// <param name="longueur">Longueur</param>
        /// <returns></returns>
        private static Color colorFor(byte hauteur, byte longueur)
        {
            if ((hauteur % 2) == 0 && (longueur % 2) != 0)
            {
                return Properties.Settings.Default.Couleur_Damier_B;
            }
            else if ((hauteur % 2) != 0 && (longueur % 2) == 0)
            {
                return Properties.Settings.Default.Couleur_Damier_B;
            }
            else
            {
                return Properties.Settings.Default.Couleur_Damier_A;
            }
        }
    }
}