using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Echiquier_de_Bezzel
{
    public partial class Paramètre : Form
    {
        public Paramètre()
        {
            InitializeComponent();
        }

        private void Paramètre_Load(object sender, EventArgs e)
        {
            panel_couleurA.BackColor = Properties.Settings.Default.Couleur_Damier_A;
            panel__couleurA.BackColor = Properties.Settings.Default.Couleur_Damier_A;
            panel__couleurB.BackColor = Properties.Settings.Default.Couleur_Damier_B;
            panel_couleurB.BackColor = Properties.Settings.Default.Couleur_Damier_B;

            panel_caseTouchéParReine.BackColor = Properties.Settings.Default.Couleur_toucherParUneReine;

            panel_directionReine.BackColor = Properties.Settings.Default.Couleur_TrajectoireReine;
            panel_directionReineToutAffiché.BackColor = Properties.Settings.Default.Couleur_TrajectoireReine_Tout_Afficher;

            checkBox_enabledDirectionCouleur.Checked = Properties.Settings.Default.TrajectoireReineCouleurDifférente;
        }

        /// <summary>
        /// Set tous les paramètres
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Paramètre_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.TrajectoireReineCouleurDifférente = checkBox_enabledDirectionCouleur.Checked;
            Properties.Settings.Default.Couleur_Damier_A = panel_couleurA.BackColor;
            Properties.Settings.Default.Couleur_toucherParUneReine = panel_caseTouchéParReine.BackColor;
            Properties.Settings.Default.Couleur_TrajectoireReine = panel_directionReine.BackColor;
            Properties.Settings.Default.Couleur_TrajectoireReine_Tout_Afficher = panel_directionReineToutAffiché.BackColor;
            Properties.Settings.Default.Couleur_Damier_B = panel_couleurB.BackColor;

            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Ouvre le color dialogue pour le damier A
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel_couleurA_MouseDown(object sender, MouseEventArgs e)
        {
            ColorDialogExtension colorDialog_couleur = new ColorDialogExtension(Cursor.Position.X, Cursor.Position.Y, "Couleur du damier");

            colorDialog_couleur.Color = panel__couleurA.BackColor;
            
            if (colorDialog_couleur.ShowDialog() == DialogResult.OK)
            {
                panel_couleurA.BackColor = colorDialog_couleur.Color;
                panel__couleurA.BackColor = colorDialog_couleur.Color;
            }
        }

        /// <summary>
        /// Ouvre le color dialogue pour le damier B
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel_couleurB_MouseDown(object sender, MouseEventArgs e)
        {
            ColorDialogExtension colorDialog_couleur = new ColorDialogExtension(Cursor.Position.X, Cursor.Position.Y, "Couleur du damier");

            colorDialog_couleur.Color = panel_couleurB.BackColor;

            if (colorDialog_couleur.ShowDialog() == DialogResult.OK)
            {
                panel_couleurB.BackColor = colorDialog_couleur.Color;
                panel__couleurB.BackColor = colorDialog_couleur.Color;
            }
        }

        private void panel_caseTouchéParReine_MouseDown(object sender, MouseEventArgs e)
        {
            ColorDialogExtension colorDialog_couleur = new ColorDialogExtension(Cursor.Position.X, Cursor.Position.Y, "Couleur case touchée par une reine");

            colorDialog_couleur.Color = panel_caseTouchéParReine.BackColor;

            if (colorDialog_couleur.ShowDialog() == DialogResult.OK)
            {
                panel_caseTouchéParReine.BackColor = colorDialog_couleur.Color;
            }
        }

        private void panel_directionReine_MouseDown(object sender, MouseEventArgs e)
        {
            ColorDialogExtension colorDialog_couleur = new ColorDialogExtension(Cursor.Position.X, Cursor.Position.Y, "Couleur direction de la reine");

            colorDialog_couleur.Color = panel_directionReine.BackColor;

            if (colorDialog_couleur.ShowDialog() == DialogResult.OK)
            {
                panel_directionReine.BackColor = colorDialog_couleur.Color;
            }
        }

        private void panel_directionReineToutAffiché_MouseDown(object sender, MouseEventArgs e)
        {
            ColorDialogExtension colorDialog_couleur = new ColorDialogExtension(Cursor.Position.X, Cursor.Position.Y, "Couleur direction de la reine (toutes trajectoires affichées)");

            colorDialog_couleur.Color = panel_directionReineToutAffiché.BackColor;

            if (colorDialog_couleur.ShowDialog() == DialogResult.OK)
            {
                panel_directionReineToutAffiché.BackColor = colorDialog_couleur.Color;
            }
        }
    }
}
