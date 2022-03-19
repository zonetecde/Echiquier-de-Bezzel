using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Echiquier_de_Bezzel
{
    public partial class Case : UserControl
    {
        Color couleurDeBase;
        private bool allDirectoryShowed;

        internal bool isQueen { get; set; }

        public Case(Color couleur, int[] position)
        {
            InitializeComponent();

            // Quadrillage
            this.BackColor = couleur;
            couleurDeBase = couleur;
            Position = position[0] + "," + position[1];
            caseAssiciée = null;
        }

        private void Case_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Affiche une reine dans la case
        /// </summary>
        /// <param name="v"></param>
        internal void SetQueen(bool v)
        {
            if(v)
            {
                isQueen = true;
                pictureBox_queen.Visible = true;
            }                  
            else
            {
                isQueen = false;
                pictureBox_queen.Visible = false;
            }
        }

        internal List<string> caseAssiciée { get; set; }
        public string Position { get; }

        internal void SetAssicied(List<string> caseAssiciée)
        {
            this.caseAssiciée = caseAssiciée;
        }

        /// <summary>
        /// Affiche les cases associées
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox_queen_MouseEnter(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Make la trajectoire ou pas
        /// </summary>
        /// <param name="v"></param>
        private void MakeSelected(bool v, bool dark)
        {
            if(v)
            {
                if(dark && Main.touteDirection)             
                    this.BackColor = Properties.Settings.Default.Couleur_TrajectoireReine_Tout_Afficher;

                else if(dark && Properties.Settings.Default.TrajectoireReineCouleurDifférente)
                    this.BackColor = Properties.Settings.Default.Couleur_TrajectoireReine_Tout_Afficher;

                else if (dark && !Properties.Settings.Default.TrajectoireReineCouleurDifférente)
                    this.BackColor = ControlPaint.Dark(this.BackColor);

                else
                    this.BackColor = Color.LightGray;
            }
            else
            {
                this.BackColor = couleurDeBase;
            }
        }


        private void pictureBox_queen_MouseLeave(object sender, EventArgs e)
        {

        }

        internal void showAllDirectoryOfQueen(bool show)
        {
            allDirectoryShowed = show;

            if (show)
            {
                showDirectory(true, false);
            }
            else
            {
                showDirectory(false, false);
            }
        }

        private void showDirectory(bool show, bool dark)
        {
            if (caseAssiciée != null)
            {
                Main main = (Main)Application.OpenForms["Main"];

                for (int height = 0; height < main.board.GetLength(0); height++)
                {
                    for (int length = 0; length < main.board.GetLength(1); length++)
                    {
                        if (caseAssiciée.Contains(height + "," + length) && !Position.Equals(height + "," + length))
                        {
                            main.board[height, length].MakeSelected(show, dark);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Affiche en rouge les tours qui peuvent tuer la case
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Case_MouseEnter(object sender, EventArgs e)
        {
            if(isQueen)
                showDirectory(true, true);
            else
                makeDangerous(true);
        }

        private void makeDangerous(bool isDangerous)
        {
            Main main = (Main)Application.OpenForms["Main"];
            foreach (var Case in main.board)
            {
                if (Case.isQueen)
                {
                    if (Case.caseAssiciée.Contains(Position))
                    {
                        Case.MakeDangerous(isDangerous);
                    }
                }
            }
        }

        /// <summary>
        /// Change la couleur de la case
        /// </summary>
        /// <param name="isDangerous"></param>
        private void MakeDangerous(bool isDangerous)
        {
            if (isDangerous)
                this.BackColor = Properties.Settings.Default.Couleur_toucherParUneReine;
            else
                this.BackColor = couleurDeBase;
        }


        /// <summary>
        /// Cache en rouge les tours qui peuvent tuer la case
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Case_MouseLeave(object sender, EventArgs e)
        {
            if (isQueen && !allDirectoryShowed)
                showDirectory(false, false);
            else if(isQueen && allDirectoryShowed)
                showDirectory(true, false);
            else
                makeDangerous(false);
        }
    }
}
