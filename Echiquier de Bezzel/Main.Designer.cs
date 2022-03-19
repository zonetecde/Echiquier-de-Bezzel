namespace Echiquier_de_Bezzel
{
    partial class Main
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel_paramètreDeGénération = new System.Windows.Forms.Panel();
            this.pictureBox_parameter = new System.Windows.Forms.PictureBox();
            this.Button_advancedGeneration = new Bunifu.Framework.UI.BunifuThinButton2();
            this.checkBox_nbDeReinne = new System.Windows.Forms.CheckBox();
            this.textBox_nbQueen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_caseTaille = new System.Windows.Forms.TextBox();
            this.Button_generate = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label_hauteur = new System.Windows.Forms.Label();
            this.label_longueur = new System.Windows.Forms.Label();
            this.textBox_tailleDeEchiquier_Hauteur = new System.Windows.Forms.TextBox();
            this.textBox_tailleDeEchiquier_Longueur = new System.Windows.Forms.TextBox();
            this.label_sizeOfBoard = new System.Windows.Forms.Label();
            this.textBox_tailleDeEchiquier = new System.Windows.Forms.TextBox();
            this.panel_chess = new System.Windows.Forms.Panel();
            this.panel_information = new System.Windows.Forms.Panel();
            this.checkBox_showAllQueenTrajectorie = new System.Windows.Forms.CheckBox();
            this.label_nbQueen = new System.Windows.Forms.Label();
            this.panel_paramètreDeGénération.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_parameter)).BeginInit();
            this.panel_information.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_paramètreDeGénération
            // 
            this.panel_paramètreDeGénération.Controls.Add(this.pictureBox_parameter);
            this.panel_paramètreDeGénération.Controls.Add(this.Button_advancedGeneration);
            this.panel_paramètreDeGénération.Controls.Add(this.checkBox_nbDeReinne);
            this.panel_paramètreDeGénération.Controls.Add(this.textBox_nbQueen);
            this.panel_paramètreDeGénération.Controls.Add(this.label1);
            this.panel_paramètreDeGénération.Controls.Add(this.textBox_caseTaille);
            this.panel_paramètreDeGénération.Controls.Add(this.Button_generate);
            this.panel_paramètreDeGénération.Controls.Add(this.label_hauteur);
            this.panel_paramètreDeGénération.Controls.Add(this.label_longueur);
            this.panel_paramètreDeGénération.Controls.Add(this.textBox_tailleDeEchiquier_Hauteur);
            this.panel_paramètreDeGénération.Controls.Add(this.textBox_tailleDeEchiquier_Longueur);
            this.panel_paramètreDeGénération.Controls.Add(this.label_sizeOfBoard);
            this.panel_paramètreDeGénération.Controls.Add(this.textBox_tailleDeEchiquier);
            this.panel_paramètreDeGénération.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_paramètreDeGénération.Location = new System.Drawing.Point(0, 0);
            this.panel_paramètreDeGénération.Name = "panel_paramètreDeGénération";
            this.panel_paramètreDeGénération.Size = new System.Drawing.Size(800, 90);
            this.panel_paramètreDeGénération.TabIndex = 0;
            // 
            // pictureBox_parameter
            // 
            this.pictureBox_parameter.Image = global::Echiquier_de_Bezzel.Properties.Resources.setting;
            this.pictureBox_parameter.Location = new System.Drawing.Point(735, 14);
            this.pictureBox_parameter.Name = "pictureBox_parameter";
            this.pictureBox_parameter.Size = new System.Drawing.Size(62, 62);
            this.pictureBox_parameter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_parameter.TabIndex = 16;
            this.pictureBox_parameter.TabStop = false;
            this.pictureBox_parameter.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_parameter_MouseDown);
            // 
            // Button_advancedGeneration
            // 
            this.Button_advancedGeneration.ActiveBorderThickness = 1;
            this.Button_advancedGeneration.ActiveCornerRadius = 20;
            this.Button_advancedGeneration.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.Button_advancedGeneration.ActiveForecolor = System.Drawing.Color.White;
            this.Button_advancedGeneration.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.Button_advancedGeneration.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Button_advancedGeneration.BackColor = System.Drawing.SystemColors.Control;
            this.Button_advancedGeneration.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_advancedGeneration.BackgroundImage")));
            this.Button_advancedGeneration.ButtonText = "Génération avancée";
            this.Button_advancedGeneration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_advancedGeneration.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_advancedGeneration.ForeColor = System.Drawing.Color.SeaGreen;
            this.Button_advancedGeneration.IdleBorderThickness = 1;
            this.Button_advancedGeneration.IdleCornerRadius = 20;
            this.Button_advancedGeneration.IdleFillColor = System.Drawing.Color.White;
            this.Button_advancedGeneration.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.Button_advancedGeneration.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.Button_advancedGeneration.Location = new System.Drawing.Point(551, 2);
            this.Button_advancedGeneration.Margin = new System.Windows.Forms.Padding(5);
            this.Button_advancedGeneration.Name = "Button_advancedGeneration";
            this.Button_advancedGeneration.Size = new System.Drawing.Size(181, 42);
            this.Button_advancedGeneration.TabIndex = 15;
            this.Button_advancedGeneration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_advancedGeneration.MouseDown += new System.EventHandler(this.Button_advancedGeneration_MouseDown);
            this.Button_advancedGeneration.Enter += new System.EventHandler(this.textBox_caseTaille_Enter);
            // 
            // checkBox_nbDeReinne
            // 
            this.checkBox_nbDeReinne.AutoSize = true;
            this.checkBox_nbDeReinne.Cursor = System.Windows.Forms.Cursors.Default;
            this.checkBox_nbDeReinne.Font = new System.Drawing.Font("Verdana", 10F);
            this.checkBox_nbDeReinne.Location = new System.Drawing.Point(351, 5);
            this.checkBox_nbDeReinne.Name = "checkBox_nbDeReinne";
            this.checkBox_nbDeReinne.Size = new System.Drawing.Size(149, 21);
            this.checkBox_nbDeReinne.TabIndex = 13;
            this.checkBox_nbDeReinne.Text = "Combien de reine";
            this.checkBox_nbDeReinne.UseVisualStyleBackColor = true;
            this.checkBox_nbDeReinne.CheckedChanged += new System.EventHandler(this.checkBox_nbDeReinne_CheckedChanged);
            this.checkBox_nbDeReinne.Enter += new System.EventHandler(this.textBox_caseTaille_Enter);
            // 
            // textBox_nbQueen
            // 
            this.textBox_nbQueen.Enabled = false;
            this.textBox_nbQueen.Font = new System.Drawing.Font("Verdana", 25.25F);
            this.textBox_nbQueen.Location = new System.Drawing.Point(391, 26);
            this.textBox_nbQueen.MaxLength = 2;
            this.textBox_nbQueen.Name = "textBox_nbQueen";
            this.textBox_nbQueen.Size = new System.Drawing.Size(58, 48);
            this.textBox_nbQueen.TabIndex = 11;
            this.textBox_nbQueen.Text = "8";
            this.textBox_nbQueen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_nbQueen.Enter += new System.EventHandler(this.textBox_caseTaille_Enter);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Taille d\'une case";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_caseTaille
            // 
            this.textBox_caseTaille.Font = new System.Drawing.Font("Verdana", 25.25F);
            this.textBox_caseTaille.Location = new System.Drawing.Point(243, 25);
            this.textBox_caseTaille.MaxLength = 2;
            this.textBox_caseTaille.Name = "textBox_caseTaille";
            this.textBox_caseTaille.Size = new System.Drawing.Size(58, 48);
            this.textBox_caseTaille.TabIndex = 9;
            this.textBox_caseTaille.Text = "50";
            this.textBox_caseTaille.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_caseTaille.TextChanged += new System.EventHandler(this.textBox_caseTaille_TextChanged);
            this.textBox_caseTaille.Enter += new System.EventHandler(this.textBox_caseTaille_Enter);
            // 
            // Button_generate
            // 
            this.Button_generate.ActiveBorderThickness = 1;
            this.Button_generate.ActiveCornerRadius = 20;
            this.Button_generate.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.Button_generate.ActiveForecolor = System.Drawing.Color.White;
            this.Button_generate.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.Button_generate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Button_generate.BackColor = System.Drawing.SystemColors.Control;
            this.Button_generate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_generate.BackgroundImage")));
            this.Button_generate.ButtonText = "Générer";
            this.Button_generate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_generate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_generate.ForeColor = System.Drawing.Color.SeaGreen;
            this.Button_generate.IdleBorderThickness = 1;
            this.Button_generate.IdleCornerRadius = 20;
            this.Button_generate.IdleFillColor = System.Drawing.Color.White;
            this.Button_generate.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.Button_generate.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.Button_generate.Location = new System.Drawing.Point(551, 40);
            this.Button_generate.Margin = new System.Windows.Forms.Padding(5);
            this.Button_generate.Name = "Button_generate";
            this.Button_generate.Size = new System.Drawing.Size(181, 48);
            this.Button_generate.TabIndex = 8;
            this.Button_generate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_generate.MouseDown += new System.EventHandler(this.Button_generate_MouseDown);
            this.Button_generate.Enter += new System.EventHandler(this.textBox_caseTaille_Enter);
            // 
            // label_hauteur
            // 
            this.label_hauteur.Location = new System.Drawing.Point(114, 73);
            this.label_hauteur.Name = "label_hauteur";
            this.label_hauteur.Size = new System.Drawing.Size(58, 13);
            this.label_hauteur.TabIndex = 5;
            this.label_hauteur.Text = "Hauteur";
            this.label_hauteur.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_hauteur.Visible = false;
            // 
            // label_longueur
            // 
            this.label_longueur.Location = new System.Drawing.Point(33, 73);
            this.label_longueur.Name = "label_longueur";
            this.label_longueur.Size = new System.Drawing.Size(58, 13);
            this.label_longueur.TabIndex = 4;
            this.label_longueur.Text = "Longueur";
            this.label_longueur.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_longueur.Visible = false;
            // 
            // textBox_tailleDeEchiquier_Hauteur
            // 
            this.textBox_tailleDeEchiquier_Hauteur.Font = new System.Drawing.Font("Verdana", 25.25F);
            this.textBox_tailleDeEchiquier_Hauteur.Location = new System.Drawing.Point(114, 25);
            this.textBox_tailleDeEchiquier_Hauteur.MaxLength = 2;
            this.textBox_tailleDeEchiquier_Hauteur.Name = "textBox_tailleDeEchiquier_Hauteur";
            this.textBox_tailleDeEchiquier_Hauteur.Size = new System.Drawing.Size(58, 48);
            this.textBox_tailleDeEchiquier_Hauteur.TabIndex = 3;
            this.textBox_tailleDeEchiquier_Hauteur.Text = "8";
            this.textBox_tailleDeEchiquier_Hauteur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_tailleDeEchiquier_Hauteur.Visible = false;
            this.textBox_tailleDeEchiquier_Hauteur.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_tailleDeEchiquier_Longueur_KeyDown);
            // 
            // textBox_tailleDeEchiquier_Longueur
            // 
            this.textBox_tailleDeEchiquier_Longueur.Font = new System.Drawing.Font("Verdana", 25.25F);
            this.textBox_tailleDeEchiquier_Longueur.Location = new System.Drawing.Point(33, 25);
            this.textBox_tailleDeEchiquier_Longueur.MaxLength = 2;
            this.textBox_tailleDeEchiquier_Longueur.Name = "textBox_tailleDeEchiquier_Longueur";
            this.textBox_tailleDeEchiquier_Longueur.Size = new System.Drawing.Size(58, 48);
            this.textBox_tailleDeEchiquier_Longueur.TabIndex = 2;
            this.textBox_tailleDeEchiquier_Longueur.Text = "8";
            this.textBox_tailleDeEchiquier_Longueur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_tailleDeEchiquier_Longueur.Visible = false;
            this.textBox_tailleDeEchiquier_Longueur.TextChanged += new System.EventHandler(this.textBox_tailleDeEchiquier_Longueur_TextChanged);
            this.textBox_tailleDeEchiquier_Longueur.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_tailleDeEchiquier_Longueur_KeyDown);
            // 
            // label_sizeOfBoard
            // 
            this.label_sizeOfBoard.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sizeOfBoard.Location = new System.Drawing.Point(23, 5);
            this.label_sizeOfBoard.Name = "label_sizeOfBoard";
            this.label_sizeOfBoard.Size = new System.Drawing.Size(160, 18);
            this.label_sizeOfBoard.TabIndex = 1;
            this.label_sizeOfBoard.Text = "Taille du tableau";
            this.label_sizeOfBoard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_tailleDeEchiquier
            // 
            this.textBox_tailleDeEchiquier.Font = new System.Drawing.Font("Verdana", 25.25F);
            this.textBox_tailleDeEchiquier.Location = new System.Drawing.Point(22, 25);
            this.textBox_tailleDeEchiquier.Name = "textBox_tailleDeEchiquier";
            this.textBox_tailleDeEchiquier.ReadOnly = true;
            this.textBox_tailleDeEchiquier.Size = new System.Drawing.Size(161, 48);
            this.textBox_tailleDeEchiquier.TabIndex = 0;
            this.textBox_tailleDeEchiquier.Text = "8x8";
            this.textBox_tailleDeEchiquier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_tailleDeEchiquier.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox_tailleDeEchiquier_MouseDown);
            // 
            // panel_chess
            // 
            this.panel_chess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_chess.Location = new System.Drawing.Point(0, 90);
            this.panel_chess.Name = "panel_chess";
            this.panel_chess.Size = new System.Drawing.Size(800, 458);
            this.panel_chess.TabIndex = 1;
            // 
            // panel_information
            // 
            this.panel_information.Controls.Add(this.checkBox_showAllQueenTrajectorie);
            this.panel_information.Controls.Add(this.label_nbQueen);
            this.panel_information.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_information.Location = new System.Drawing.Point(0, 513);
            this.panel_information.Name = "panel_information";
            this.panel_information.Size = new System.Drawing.Size(800, 35);
            this.panel_information.TabIndex = 0;
            // 
            // checkBox_showAllQueenTrajectorie
            // 
            this.checkBox_showAllQueenTrajectorie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_showAllQueenTrajectorie.AutoSize = true;
            this.checkBox_showAllQueenTrajectorie.Cursor = System.Windows.Forms.Cursors.Default;
            this.checkBox_showAllQueenTrajectorie.Enabled = false;
            this.checkBox_showAllQueenTrajectorie.Font = new System.Drawing.Font("Verdana", 10F);
            this.checkBox_showAllQueenTrajectorie.Location = new System.Drawing.Point(471, 8);
            this.checkBox_showAllQueenTrajectorie.Name = "checkBox_showAllQueenTrajectorie";
            this.checkBox_showAllQueenTrajectorie.Size = new System.Drawing.Size(317, 21);
            this.checkBox_showAllQueenTrajectorie.TabIndex = 14;
            this.checkBox_showAllQueenTrajectorie.Text = "Afficher la trajectoire de toutes les reines";
            this.checkBox_showAllQueenTrajectorie.UseVisualStyleBackColor = true;
            this.checkBox_showAllQueenTrajectorie.CheckedChanged += new System.EventHandler(this.checkBox_showAllQueenTrajectorie_CheckedChanged);
            this.checkBox_showAllQueenTrajectorie.Enter += new System.EventHandler(this.textBox_caseTaille_Enter);
            // 
            // label_nbQueen
            // 
            this.label_nbQueen.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nbQueen.Location = new System.Drawing.Point(4, 8);
            this.label_nbQueen.Name = "label_nbQueen";
            this.label_nbQueen.Size = new System.Drawing.Size(287, 18);
            this.label_nbQueen.TabIndex = 14;
            this.label_nbQueen.Text = "Nombre de reine sur le plateau : ";
            this.label_nbQueen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 548);
            this.Controls.Add(this.panel_information);
            this.Controls.Add(this.panel_chess);
            this.Controls.Add(this.panel_paramètreDeGénération);
            this.MinimumSize = new System.Drawing.Size(816, 587);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Echiquier de Bezzel";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel_paramètreDeGénération.ResumeLayout(false);
            this.panel_paramètreDeGénération.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_parameter)).EndInit();
            this.panel_information.ResumeLayout(false);
            this.panel_information.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_paramètreDeGénération;
        private System.Windows.Forms.TextBox textBox_tailleDeEchiquier;
        private System.Windows.Forms.Label label_sizeOfBoard;
        private System.Windows.Forms.TextBox textBox_tailleDeEchiquier_Longueur;
        private System.Windows.Forms.TextBox textBox_tailleDeEchiquier_Hauteur;
        private System.Windows.Forms.Label label_hauteur;
        private System.Windows.Forms.Label label_longueur;
        private Bunifu.Framework.UI.BunifuThinButton2 Button_generate;
        private System.Windows.Forms.Panel panel_chess;
        private System.Windows.Forms.TextBox textBox_caseTaille;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_nbQueen;
        private System.Windows.Forms.CheckBox checkBox_nbDeReinne;
        private System.Windows.Forms.Panel panel_information;
        private System.Windows.Forms.Label label_nbQueen;
        private System.Windows.Forms.CheckBox checkBox_showAllQueenTrajectorie;
        private Bunifu.Framework.UI.BunifuThinButton2 Button_advancedGeneration;
        private System.Windows.Forms.PictureBox pictureBox_parameter;
    }
}

