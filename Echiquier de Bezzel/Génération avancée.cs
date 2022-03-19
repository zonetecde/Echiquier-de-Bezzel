using MoreLinq;
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
    public partial class Génération_avancée : Form
    {
        public Main Main { get; }
        List<BoardInformation> boardGenerate { get; set; }

        public Génération_avancée(Main main)
        {
            InitializeComponent();

            boardGenerate = new List<BoardInformation>();

            this.Icon = Properties.Resources.icon;
            Main = main;
        }

        private void Génération_avancée_Load(object sender, EventArgs e)
        {

        }

        internal void setParameter(string boardSize, string caseSize)
        {
            label_boardSize.Text = boardSize;
            label_sizeCase.Text = caseSize;
        }

        internal void setEnabled(bool isChecked)
        {
            Button_generate.Visible = isChecked;
            label_erreur.Visible = !isChecked;
            tabControl_page.Enabled = isChecked;
        }

        /// <summary>
        /// Lance la génération
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_generate_MouseDown(object sender, EventArgs e)
        {
            if (!checkBox_conserver.Checked)
                boardGenerate = Main.generateWithParameter(Convert.ToInt32(numericUpDown_nbDeGénération.Value));
            else
            {
                List<BoardInformation> toAdd = Main.generateWithParameter(Convert.ToInt32(numericUpDown_nbDeGénération.Value));
                boardGenerate.AddRange(toAdd);
            }
            showInformationOfList();
        }

        /// <summary>
        /// Affiche toutes les informations
        /// Max, min, moyenne...
        /// </summary>
        private void showInformationOfList()
        {
            dataGridView_result.Rows.Clear();

            int i = dataGridView_result.Rows.Count + 1;

            foreach (var board in boardGenerate)
            {
                dataGridView_result.Rows.Add(i, board.NbQueen.ToString(), "Charger");
                i++;
            }

            tabControl_page.SelectedIndex = 1;

            // Mes les info en chiffre
            int min = boardGenerate.Select(x => x.NbQueen).Min();
            label_nbMin.Text = min.ToString();

            int max = boardGenerate.Select(x => x.NbQueen).Max();
            label_nbMax.Text = max.ToString();

            double moyenne = boardGenerate.Select(x => x.NbQueen).Average();
            label_nbMoyenne.Text = moyenne.ToString();

            // Contient chaques valeur et le nombre de fois qu'elle est utilisé
            List<string> allChiffreWithNb = new List<string>();
            bool isUse = false;

            listBox_nbReineCombien.Items.Clear();

            int total = boardGenerate.Select(x => x.NbQueen).Sum();
            label_total.Text = total.ToString();

            for (int a = 0; a < boardGenerate.Count; a++)
            {
                isUse = false;

                for (int n = 0; n < allChiffreWithNb.Count; n++)
                {
                    List<string> it = allChiffreWithNb[n].Split(',').ToList();
                    if (it[0].Equals(boardGenerate[a].NbQueen.ToString()))
                    {
                        isUse = true;
                        it[1] = (Convert.ToInt32(it[1]) + 1).ToString();
                        allChiffreWithNb[n] = String.Join(",", it);
                    }
                }

                if (!isUse)
                {
                    allChiffreWithNb.Add(boardGenerate[a].NbQueen + ",1");
                }
            }

            // On ajoute tous à la listBox
            foreach (var item in allChiffreWithNb)
            {
                listBox_nbReineCombien.Items.Add(item.Replace(",", " reine on été générée ") + " fois.");
            }
        }

        /// <summary>
        /// Charge la disposition séléctionée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView_result_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {

                int selectedrowindex = dataGridView_result.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView_result.Rows[selectedrowindex];
                string a = Convert.ToString(selectedRow.Cells["Nb"].Value);

                try
                {
                    Main.LoadBoard(boardGenerate[Convert.ToInt32(a) - 1]);
                }
                catch
                {
                    MessageBox.Show("Impossible de charger l'échiquier, les paramètres ont été modifiés.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        
        /// <summary>
        /// Supprime toutes les informations dans les datasgridview
        /// </summary>
        internal void DeleteInformation()
        {
            dataGridView_result.Rows.Clear();
        }

        /// <summary>
        /// Supprime tous les doublons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_deleteDouble_MouseDown(object sender, EventArgs e)
        {
            boardGenerate = boardGenerate.GroupBy(x => String.Join(",", x.PositionQueen))
                                 .Select(x => x.First())
                                 .ToList();

            showInformationOfList();
        }
    }
}
