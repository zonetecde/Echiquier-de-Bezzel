namespace Echiquier_de_Bezzel
{
    partial class Génération_avancée
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Génération_avancée));
            this.label_boardSize = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_sizeCase = new System.Windows.Forms.Label();
            this.tabControl_page = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkBox_conserver = new System.Windows.Forms.CheckBox();
            this.Button_generate = new Bunifu.Framework.UI.BunifuThinButton2();
            this.numericUpDown_nbDeGénération = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage_result = new System.Windows.Forms.TabPage();
            this.dataGridView_result = new System.Windows.Forms.DataGridView();
            this.Nb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reine_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Voir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label_erreur = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label_nbMin = new System.Windows.Forms.Label();
            this.label_nbMax = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox_nbReineCombien = new System.Windows.Forms.ListBox();
            this.label_nbMoyenne = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_total = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Button_deleteDouble = new Bunifu.Framework.UI.BunifuThinButton2();
            this.tabControl_page.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_nbDeGénération)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage_result.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_result)).BeginInit();
            this.SuspendLayout();
            // 
            // label_boardSize
            // 
            this.label_boardSize.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_boardSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_boardSize.Location = new System.Drawing.Point(306, 20);
            this.label_boardSize.Name = "label_boardSize";
            this.label_boardSize.Size = new System.Drawing.Size(100, 23);
            this.label_boardSize.TabIndex = 0;
            this.label_boardSize.Text = "00x00";
            this.label_boardSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_title
            // 
            this.label_title.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(12, 19);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(403, 25);
            this.label_title.TabIndex = 1;
            this.label_title.Text = "Génération avancée";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Taille de l\'échiquier :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Taille d\'une case :";
            // 
            // label_sizeCase
            // 
            this.label_sizeCase.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sizeCase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_sizeCase.Location = new System.Drawing.Point(330, 56);
            this.label_sizeCase.Name = "label_sizeCase";
            this.label_sizeCase.Size = new System.Drawing.Size(76, 25);
            this.label_sizeCase.TabIndex = 4;
            this.label_sizeCase.Text = "00";
            this.label_sizeCase.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabControl_page
            // 
            this.tabControl_page.Controls.Add(this.tabPage1);
            this.tabControl_page.Controls.Add(this.tabPage2);
            this.tabControl_page.Controls.Add(this.tabPage_result);
            this.tabControl_page.Location = new System.Drawing.Point(3, 59);
            this.tabControl_page.Name = "tabControl_page";
            this.tabControl_page.SelectedIndex = 0;
            this.tabControl_page.Size = new System.Drawing.Size(421, 379);
            this.tabControl_page.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.checkBox_conserver);
            this.tabPage1.Controls.Add(this.Button_generate);
            this.tabPage1.Controls.Add(this.numericUpDown_nbDeGénération);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label_sizeCase);
            this.tabPage1.Controls.Add(this.label_boardSize);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(413, 353);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Paramètre";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // checkBox_conserver
            // 
            this.checkBox_conserver.AutoSize = true;
            this.checkBox_conserver.Font = new System.Drawing.Font("Verdana", 10.25F);
            this.checkBox_conserver.Location = new System.Drawing.Point(8, 145);
            this.checkBox_conserver.Name = "checkBox_conserver";
            this.checkBox_conserver.Size = new System.Drawing.Size(259, 21);
            this.checkBox_conserver.TabIndex = 9;
            this.checkBox_conserver.Text = "Conserver les échiquiers générés";
            this.checkBox_conserver.UseVisualStyleBackColor = true;
            // 
            // Button_generate
            // 
            this.Button_generate.ActiveBorderThickness = 1;
            this.Button_generate.ActiveCornerRadius = 20;
            this.Button_generate.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.Button_generate.ActiveForecolor = System.Drawing.Color.White;
            this.Button_generate.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.Button_generate.BackColor = System.Drawing.Color.Transparent;
            this.Button_generate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_generate.BackgroundImage")));
            this.Button_generate.ButtonText = "Générer et voir les résultats";
            this.Button_generate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_generate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_generate.ForeColor = System.Drawing.Color.SeaGreen;
            this.Button_generate.IdleBorderThickness = 1;
            this.Button_generate.IdleCornerRadius = 20;
            this.Button_generate.IdleFillColor = System.Drawing.Color.White;
            this.Button_generate.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.Button_generate.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.Button_generate.Location = new System.Drawing.Point(8, 304);
            this.Button_generate.Margin = new System.Windows.Forms.Padding(5);
            this.Button_generate.Name = "Button_generate";
            this.Button_generate.Size = new System.Drawing.Size(400, 41);
            this.Button_generate.TabIndex = 8;
            this.Button_generate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_generate.MouseDown += new System.EventHandler(this.Button_generate_MouseDown);
            // 
            // numericUpDown_nbDeGénération
            // 
            this.numericUpDown_nbDeGénération.Font = new System.Drawing.Font("Verdana", 15.75F);
            this.numericUpDown_nbDeGénération.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.numericUpDown_nbDeGénération.Location = new System.Drawing.Point(337, 90);
            this.numericUpDown_nbDeGénération.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_nbDeGénération.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_nbDeGénération.Name = "numericUpDown_nbDeGénération";
            this.numericUpDown_nbDeGénération.Size = new System.Drawing.Size(71, 33);
            this.numericUpDown_nbDeGénération.TabIndex = 7;
            this.numericUpDown_nbDeGénération.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_nbDeGénération.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre de génération :";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label_total);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label_nbMoyenne);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.listBox_nbReineCombien);
            this.tabPage2.Controls.Add(this.label_nbMax);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label_nbMin);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(413, 353);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Résultat en chiffre";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage_result
            // 
            this.tabPage_result.Controls.Add(this.Button_deleteDouble);
            this.tabPage_result.Controls.Add(this.dataGridView_result);
            this.tabPage_result.Location = new System.Drawing.Point(4, 22);
            this.tabPage_result.Name = "tabPage_result";
            this.tabPage_result.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_result.Size = new System.Drawing.Size(413, 353);
            this.tabPage_result.TabIndex = 1;
            this.tabPage_result.Text = "Voir les résultats";
            this.tabPage_result.UseVisualStyleBackColor = true;
            // 
            // dataGridView_result
            // 
            this.dataGridView_result.AllowUserToAddRows = false;
            this.dataGridView_result.AllowUserToDeleteRows = false;
            this.dataGridView_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_result.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nb,
            this.reine_num,
            this.Voir});
            this.dataGridView_result.Location = new System.Drawing.Point(9, 6);
            this.dataGridView_result.Name = "dataGridView_result";
            this.dataGridView_result.ReadOnly = true;
            this.dataGridView_result.Size = new System.Drawing.Size(414, 298);
            this.dataGridView_result.TabIndex = 0;
            this.dataGridView_result.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_result_CellContentClick);
            // 
            // Nb
            // 
            this.Nb.HeaderText = "Nb";
            this.Nb.Name = "Nb";
            this.Nb.ReadOnly = true;
            this.Nb.Width = 30;
            // 
            // reine_num
            // 
            this.reine_num.HeaderText = "Nombre de reine générées";
            this.reine_num.Name = "reine_num";
            this.reine_num.ReadOnly = true;
            this.reine_num.Width = 170;
            // 
            // Voir
            // 
            this.Voir.HeaderText = "Voir";
            this.Voir.Name = "Voir";
            this.Voir.ReadOnly = true;
            this.Voir.Width = 153;
            // 
            // label_erreur
            // 
            this.label_erreur.AutoSize = true;
            this.label_erreur.ForeColor = System.Drawing.Color.Red;
            this.label_erreur.Location = new System.Drawing.Point(8, 399);
            this.label_erreur.Name = "label_erreur";
            this.label_erreur.Size = new System.Drawing.Size(410, 13);
            this.label_erreur.TabIndex = 9;
            this.label_erreur.Text = "Veuillez décocher l\'option \"Combien de reine\" pour effectuer une génération avanc" +
    "ée";
            this.label_erreur.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 12.25F);
            this.label8.Location = new System.Drawing.Point(2, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(331, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Nombre de reine minimum générée :";
            // 
            // label_nbMin
            // 
            this.label_nbMin.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nbMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_nbMin.Location = new System.Drawing.Point(334, 20);
            this.label_nbMin.Name = "label_nbMin";
            this.label_nbMin.Size = new System.Drawing.Size(76, 25);
            this.label_nbMin.TabIndex = 11;
            this.label_nbMin.Text = "00";
            this.label_nbMin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_nbMax
            // 
            this.label_nbMax.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nbMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_nbMax.Location = new System.Drawing.Point(334, 50);
            this.label_nbMax.Name = "label_nbMax";
            this.label_nbMax.Size = new System.Drawing.Size(76, 25);
            this.label_nbMax.TabIndex = 13;
            this.label_nbMax.Text = "00";
            this.label_nbMax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12.25F);
            this.label5.Location = new System.Drawing.Point(2, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(335, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nombre de reine maximum générée :";
            // 
            // listBox_nbReineCombien
            // 
            this.listBox_nbReineCombien.Font = new System.Drawing.Font("Verdana", 10.25F);
            this.listBox_nbReineCombien.FormattingEnabled = true;
            this.listBox_nbReineCombien.ItemHeight = 17;
            this.listBox_nbReineCombien.Location = new System.Drawing.Point(5, 80);
            this.listBox_nbReineCombien.Name = "listBox_nbReineCombien";
            this.listBox_nbReineCombien.Size = new System.Drawing.Size(402, 123);
            this.listBox_nbReineCombien.TabIndex = 14;
            // 
            // label_nbMoyenne
            // 
            this.label_nbMoyenne.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nbMoyenne.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_nbMoyenne.Location = new System.Drawing.Point(334, 203);
            this.label_nbMoyenne.Name = "label_nbMoyenne";
            this.label_nbMoyenne.Size = new System.Drawing.Size(76, 25);
            this.label_nbMoyenne.TabIndex = 16;
            this.label_nbMoyenne.Text = "00";
            this.label_nbMoyenne.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12.25F);
            this.label6.Location = new System.Drawing.Point(2, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(279, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Nombre de reine en moyenne :";
            // 
            // label_total
            // 
            this.label_total.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_total.Location = new System.Drawing.Point(334, 229);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(76, 25);
            this.label_total.TabIndex = 18;
            this.label_total.Text = "00";
            this.label_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12.25F);
            this.label7.Location = new System.Drawing.Point(2, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(314, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Nombre de reine générée au total :";
            // 
            // Button_deleteDouble
            // 
            this.Button_deleteDouble.ActiveBorderThickness = 1;
            this.Button_deleteDouble.ActiveCornerRadius = 20;
            this.Button_deleteDouble.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.Button_deleteDouble.ActiveForecolor = System.Drawing.Color.White;
            this.Button_deleteDouble.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.Button_deleteDouble.BackColor = System.Drawing.Color.Transparent;
            this.Button_deleteDouble.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_deleteDouble.BackgroundImage")));
            this.Button_deleteDouble.ButtonText = "Supprimer les doublons";
            this.Button_deleteDouble.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_deleteDouble.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_deleteDouble.ForeColor = System.Drawing.Color.SeaGreen;
            this.Button_deleteDouble.IdleBorderThickness = 1;
            this.Button_deleteDouble.IdleCornerRadius = 20;
            this.Button_deleteDouble.IdleFillColor = System.Drawing.Color.White;
            this.Button_deleteDouble.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.Button_deleteDouble.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.Button_deleteDouble.Location = new System.Drawing.Point(10, 307);
            this.Button_deleteDouble.Margin = new System.Windows.Forms.Padding(5);
            this.Button_deleteDouble.Name = "Button_deleteDouble";
            this.Button_deleteDouble.Size = new System.Drawing.Size(403, 41);
            this.Button_deleteDouble.TabIndex = 1;
            this.Button_deleteDouble.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_deleteDouble.MouseDown += new System.EventHandler(this.Button_deleteDouble_MouseDown);
            // 
            // Génération_avancée
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 441);
            this.Controls.Add(this.label_erreur);
            this.Controls.Add(this.tabControl_page);
            this.Controls.Add(this.label_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Génération_avancée";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Génération avancée";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Génération_avancée_Load);
            this.tabControl_page.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_nbDeGénération)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage_result.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_result)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_boardSize;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_sizeCase;
        private System.Windows.Forms.TabControl tabControl_page;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage_result;
        private System.Windows.Forms.NumericUpDown numericUpDown_nbDeGénération;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuThinButton2 Button_generate;
        private System.Windows.Forms.Label label_erreur;
        private System.Windows.Forms.DataGridView dataGridView_result;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nb;
        private System.Windows.Forms.DataGridViewTextBoxColumn reine_num;
        private System.Windows.Forms.DataGridViewButtonColumn Voir;
        private System.Windows.Forms.CheckBox checkBox_conserver;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label_nbMin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_nbMax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox_nbReineCombien;
        private System.Windows.Forms.Label label_nbMoyenne;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuThinButton2 Button_deleteDouble;
    }
}