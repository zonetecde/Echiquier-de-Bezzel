using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Echiquier_de_Bezzel
{
    public partial class Main : Form
    {
        public static Génération_avancée génération_Avancée;
        public static bool touteDirection = false;

        // Stock la taille de l'échiquier (longueur et hauteur)
        // Par défault 8 (taille d'un échiquier normale)
        private byte BoardSizeLenght = 8;

        private byte BoardSizeHeight = 8;

        private byte sizeCase = 50;

        internal Case[,] board;

        public Main()
        {
            InitializeComponent();

            génération_Avancée = new Génération_avancée(this);

            // Définit l'icone de la fenêtre.
            // L'icone se trouve dans les ressources du projet.
            this.Icon = Properties.Resources.icon;

            // Enlève le focus sur la zone de saisie de la taille du tableau mais
            this.ActiveControl = panel_paramètreDeGénération;
        }

        private void Main_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Active la saisie de la taille de l'échiquier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_tailleDeEchiquier_MouseDown(object sender, MouseEventArgs e)
        {
            // Attribut les dimensions actuelle à l'interieur des textboxs
            textBox_tailleDeEchiquier_Longueur.Text = BoardSizeLenght.ToString();
            textBox_tailleDeEchiquier_Hauteur.Text = BoardSizeHeight.ToString();
            // Enlève le bord du repère de taille
            textBox_tailleDeEchiquier.BorderStyle = BorderStyle.None;
            // Affiche les deux zone de saisie pour modifier la taille du tableau
            textBox_tailleDeEchiquier_Hauteur.Visible = true;
            textBox_tailleDeEchiquier_Longueur.Visible = true;
            // Affiche les repères
            label_hauteur.Visible = true;
            label_longueur.Visible = true;
            // Entre dans la zone de saisie pour la longueur
            this.ActiveControl = textBox_tailleDeEchiquier_Longueur;
            textBox_tailleDeEchiquier_Longueur.SelectAll();
        }

        internal List<BoardInformation> generateWithParameter(int value)
        {
            if (textBox_tailleDeEchiquier_Hauteur.Visible)
                setBoardSize();

            removeErrorFromParameter();

            // Clear les cases existante d'abord
            if (board != null)
            {
                if (board.GetLength(0) != BoardSizeHeight || board.GetLength(1) != BoardSizeLenght || board[0, 0].Height != sizeCase)
                {
                    panel_chess.Controls.Clear();
                    board = Board.GenerateBoard(BoardSizeLenght, BoardSizeHeight, sizeCase, panel_chess);
                    showBoard();
                }
            }
            else
            {
                panel_chess.Controls.Clear();
                board = Board.GenerateBoard(BoardSizeLenght, BoardSizeHeight, sizeCase, panel_chess);
                showBoard();
            }

            // Affiche les reines dans les cases (Alghoritme)  
            Algorithme.results.Clear();
            Algorithme.essaiGénérationAvancée = 0;

            List<BoardInformation> results = Algorithme.setCaseWithQueen(board, essai_avancée: value);

            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int z = 0; z < board.GetLength(1); z++)
                {
                    board[i, z].SetQueen(false);
                }
            }

            foreach(var pos in results[0].PositionQueen)
            {
                string[] position = pos.Split(',');
                board[Convert.ToInt32(position[0]), Convert.ToInt32(position[1])].SetQueen(true);
            }

            if (checkBox_showAllQueenTrajectorie.Checked)
            {
                showAllQueenDirectory();
            }

            return results;
        }

        /// <summary>
        /// Load le board séléctionné
        /// </summary>
        /// <param name="boardGenerate"></param>
        internal void LoadBoard(BoardInformation boardGenerate)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int z = 0; z < board.GetLength(1); z++)
                {
                    board[i, z].SetQueen(false);
                    if (boardGenerate.PositionQueen.Contains(i + "," + z))
                    {
                        board[i, z].SetQueen(true);
                    }
                }
            }

            label_nbQueen.Text = "Nombre de reine sur le plateau : " + boardGenerate.NbQueen;
        }

        private void removeErrorFromParameter()
        {
            checkBox_showAllQueenTrajectorie.Enabled = true;
            if (sizeCase <= 0)
            {
                sizeCase = 50;
                textBox_caseTaille.Text = "50";
            }
            else if (String.IsNullOrEmpty(textBox_caseTaille.Text))
            {
                sizeCase = 50;
                textBox_caseTaille.Text = "50";
            }
        }

        /// <summary>
        /// Attribut la même valeur de longueur pour la hauteur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_tailleDeEchiquier_Longueur_TextChanged(object sender, EventArgs e)
        {
            textBox_tailleDeEchiquier_Hauteur.Text = textBox_tailleDeEchiquier_Longueur.Text;
        }

        /// <summary>
        /// Valide les zones de saisie de la taille du tableau si on appuie sur entrer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_tailleDeEchiquier_Longueur_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                setBoardSize();
            }
        }

        /// <summary>
        /// Valide les zones de saisie de la taille du tableau si on appuie sur entrer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void setBoardSize()
        {
            // Attribut les dimensions actuelle au nouvelle dimension si c'est bien un nombre et qu'il n'y est pas d'erreur
            try
            {
                BoardSizeLenght = Convert.ToByte(textBox_tailleDeEchiquier_Longueur.Text);
                BoardSizeHeight = Convert.ToByte(textBox_tailleDeEchiquier_Hauteur.Text);
            }
            catch
            {
            }
            finally
            {
                // Attribut les dimensions saisie au repère
                textBox_tailleDeEchiquier.Text = BoardSizeLenght.ToString() + "x" + BoardSizeHeight.ToString();
                // Active le bord du repère de taille
                textBox_tailleDeEchiquier.BorderStyle = BorderStyle.FixedSingle;
                // Cache les deux zone de saisie pour modifier la taille du tableau
                textBox_tailleDeEchiquier_Hauteur.Visible = false;
                textBox_tailleDeEchiquier_Longueur.Visible = false;
                // Cache les repères
                label_hauteur.Visible = false;
                label_longueur.Visible = false;
                // Enlève le focus sur la textbox de repère
                this.ActiveControl = panel_paramètreDeGénération;

                génération_Avancée.setParameter(textBox_tailleDeEchiquier.Text, textBox_caseTaille.Text);
            }
        }

        /// <summary>
        /// Génère le chequier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_generate_MouseDown(object sender, EventArgs e)
        {
            if (textBox_tailleDeEchiquier_Hauteur.Visible)
                setBoardSize();

            removeErrorFromParameter();

            // Clear les cases existante d'abord
            if (board != null)
            {
                if (board.GetLength(0) != BoardSizeHeight || board.GetLength(1) != BoardSizeLenght || board[0, 0].Height != sizeCase)
                {
                    // Des paramètres ont été changés
                    panel_chess.Controls.Clear();

                    board = Board.GenerateBoard(BoardSizeLenght, BoardSizeHeight, sizeCase, panel_chess);
                    showBoard();

                    génération_Avancée.DeleteInformation();
                }                
            }
            else
            {
                panel_chess.Controls.Clear();

                board = Board.GenerateBoard(BoardSizeLenght, BoardSizeHeight, sizeCase, panel_chess);
                showBoard();
            }

            // Affiche les reines dans les cases (Alghoritme)
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int z = 0; z < board.GetLength(1); z++)
                {
                    if(board[i,z].isQueen)
                    {
                        board[i, z].SetQueen(false);
                    }
                }
            }

            if (checkBox_nbDeReinne.Checked)
            {
                Algorithme.essai = 0;

                try
                {
                    Algorithme.setCaseWithQueen(board, Convert.ToInt32(textBox_nbQueen.Text));
                }
                catch
                {
                    Algorithme.setCaseWithQueen(board);
                    textBox_nbQueen.Text = "8";
                    checkBox_nbDeReinne.Checked = false;
                }
            }
            else
            {
                Algorithme.setCaseWithQueen(board);
            }

            if (checkBox_showAllQueenTrajectorie.Checked)
            {
                showAllQueenDirectory();
            }
        }

        private void showBoard()
        {

            // Pour toutes les hauteurs du tableau
            for (byte height = 0; height < BoardSizeHeight; height++)
            {
                // Pour toutes les cases en longueur du tableau
                for (byte length = 0; length < BoardSizeLenght; length++)
                {
                    // On affiche la case avec la bonne taille
                    board[height, length].Size = new Size(sizeCase, sizeCase);
                    panel_chess.Controls.Add(board[height, length]);
                }
            }
        }

        /// <summary>
        /// Change le nombre de reine générer
        /// </summary>
        /// <param name="queenGénérer"></param>
        internal void setInformation_nbReine(int queenGénérer)
        {
            label_nbQueen.Text = "Nombre de reine sur le plateau : " + queenGénérer;
        }

        /// <summary>
        /// Affiche un message comme quoi il est impossible de générer x queen
        /// </summary>
        internal void tooManyTry()
        {
            MessageBox.Show("Impossible de générer " + textBox_nbQueen.Text + " reines dans un jeu de " + textBox_tailleDeEchiquier.Text + " après 200 tentatives.", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Change la taille d'une case
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_caseTaille_TextChanged(object sender, EventArgs e)
        {
            try
            {
                sizeCase = Convert.ToByte(textBox_caseTaille.Text);
                génération_Avancée.setParameter(textBox_tailleDeEchiquier.Text, textBox_caseTaille.Text);
            }
            catch
            {
            }
        }

        /// <summary>
        /// Active/désactive la fonction de reine voulue
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox_nbDeReinne_CheckedChanged(object sender, EventArgs e)
        {
            génération_Avancée.setEnabled(!checkBox_nbDeReinne.Checked);

            textBox_nbQueen.Enabled = checkBox_nbDeReinne.Checked;

        }

        /// <summary>
        /// Affiche / Enlève la trajectoire de toutes les reines sur le plateau
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox_showAllQueenTrajectorie_CheckedChanged(object sender, EventArgs e)
        {
            showAllQueenDirectory();

            touteDirection = checkBox_showAllQueenTrajectorie.Checked;
        }

        private void showAllQueenDirectory()
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int v = 0; v < board.GetLength(1); v++)
                {
                    if (board[i, v].isQueen)
                    {
                        board[i, v].showAllDirectoryOfQueen(checkBox_showAllQueenTrajectorie.Checked);
                    }
                }
            }
        }

        /// <summary>
        /// Ouvre la fenetre des détails sur la génération
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_advancedGeneration_MouseDown(object sender, EventArgs e)
        {
            try
            {
                génération_Avancée.setParameter(textBox_tailleDeEchiquier.Text, textBox_caseTaille.Text);
                génération_Avancée.Show();
            }
            catch
            {
                génération_Avancée = new Génération_avancée(this);
                génération_Avancée.setParameter(textBox_tailleDeEchiquier.Text, textBox_caseTaille.Text);
                génération_Avancée.Show();
            }
        }

        /// <summary>
        /// Valide les zones de saisie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_caseTaille_Enter(object sender, EventArgs e)
        {
            if (textBox_tailleDeEchiquier_Hauteur.Visible)
                setBoardSize();
        }

        /// <summary>
        /// Ouvre les paramètres
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox_parameter_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Paramètre paramètre = new Paramètre();
                paramètre.ShowDialog();
            }
        }
    }
}