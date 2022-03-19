namespace Echiquier_de_Bezzel
{
    partial class Paramètre
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
            this.label_ = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_couleurB = new System.Windows.Forms.Panel();
            this.panel_couleurA = new System.Windows.Forms.Panel();
            this.panel__couleurB = new System.Windows.Forms.Panel();
            this.panel__couleurA = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_caseTouchéParReine = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_directionReineToutAffiché = new System.Windows.Forms.Panel();
            this.panel_directionReine = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox_enabledDirectionCouleur = new System.Windows.Forms.CheckBox();
            this.label_warning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_
            // 
            this.label_.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_.Location = new System.Drawing.Point(-1, 70);
            this.label_.Name = "label_";
            this.label_.Size = new System.Drawing.Size(344, 89);
            this.label_.TabIndex = 0;
            this.label_.Text = "Couleur du quadrillage :";
            this.label_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 20F);
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Paramètres";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel_couleurB
            // 
            this.panel_couleurB.Location = new System.Drawing.Point(297, 80);
            this.panel_couleurB.Name = "panel_couleurB";
            this.panel_couleurB.Size = new System.Drawing.Size(35, 35);
            this.panel_couleurB.TabIndex = 2;
            this.panel_couleurB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_couleurB_MouseDown);
            // 
            // panel_couleurA
            // 
            this.panel_couleurA.Location = new System.Drawing.Point(262, 80);
            this.panel_couleurA.Name = "panel_couleurA";
            this.panel_couleurA.Size = new System.Drawing.Size(35, 35);
            this.panel_couleurA.TabIndex = 3;
            this.panel_couleurA.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_couleurA_MouseDown);
            // 
            // panel__couleurB
            // 
            this.panel__couleurB.Location = new System.Drawing.Point(262, 115);
            this.panel__couleurB.Name = "panel__couleurB";
            this.panel__couleurB.Size = new System.Drawing.Size(35, 35);
            this.panel__couleurB.TabIndex = 5;
            this.panel__couleurB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_couleurB_MouseDown);
            // 
            // panel__couleurA
            // 
            this.panel__couleurA.Location = new System.Drawing.Point(297, 115);
            this.panel__couleurA.Name = "panel__couleurA";
            this.panel__couleurA.Size = new System.Drawing.Size(35, 35);
            this.panel__couleurA.TabIndex = 4;
            this.panel__couleurA.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_couleurA_MouseDown);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-1, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 70);
            this.label2.TabIndex = 6;
            this.label2.Text = "Couleur case touchée par\r\n une reine :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_caseTouchéParReine
            // 
            this.panel_caseTouchéParReine.Location = new System.Drawing.Point(279, 177);
            this.panel_caseTouchéParReine.Name = "panel_caseTouchéParReine";
            this.panel_caseTouchéParReine.Size = new System.Drawing.Size(35, 35);
            this.panel_caseTouchéParReine.TabIndex = 6;
            this.panel_caseTouchéParReine.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_caseTouchéParReine_MouseDown);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-2, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(354, 80);
            this.label3.TabIndex = 7;
            this.label3.Text = "Couleur des directions des\r\nreines (toutes les trajectoires \r\naffichées) :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_directionReineToutAffiché
            // 
            this.panel_directionReineToutAffiché.Location = new System.Drawing.Point(279, 327);
            this.panel_directionReineToutAffiché.Name = "panel_directionReineToutAffiché";
            this.panel_directionReineToutAffiché.Size = new System.Drawing.Size(35, 35);
            this.panel_directionReineToutAffiché.TabIndex = 7;
            this.panel_directionReineToutAffiché.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_directionReineToutAffiché_MouseDown);
            // 
            // panel_directionReine
            // 
            this.panel_directionReine.Location = new System.Drawing.Point(279, 250);
            this.panel_directionReine.Name = "panel_directionReine";
            this.panel_directionReine.Size = new System.Drawing.Size(35, 35);
            this.panel_directionReine.TabIndex = 8;
            this.panel_directionReine.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_directionReine_MouseDown);
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-2, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(346, 70);
            this.label4.TabIndex = 9;
            this.label4.Text = "Couleur direction de reine :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkBox_enabledDirectionCouleur
            // 
            this.checkBox_enabledDirectionCouleur.AutoSize = true;
            this.checkBox_enabledDirectionCouleur.Font = new System.Drawing.Font("Verdana", 7.25F);
            this.checkBox_enabledDirectionCouleur.Location = new System.Drawing.Point(3, 234);
            this.checkBox_enabledDirectionCouleur.Name = "checkBox_enabledDirectionCouleur";
            this.checkBox_enabledDirectionCouleur.Size = new System.Drawing.Size(343, 16);
            this.checkBox_enabledDirectionCouleur.TabIndex = 10;
            this.checkBox_enabledDirectionCouleur.Text = "Activer (désactiver = couleur du quadrillage plus sombre)";
            this.checkBox_enabledDirectionCouleur.UseVisualStyleBackColor = true;
            // 
            // label_warning
            // 
            this.label_warning.Font = new System.Drawing.Font("Verdana", 10.25F);
            this.label_warning.ForeColor = System.Drawing.Color.Red;
            this.label_warning.Location = new System.Drawing.Point(0, 380);
            this.label_warning.Name = "label_warning";
            this.label_warning.Size = new System.Drawing.Size(343, 42);
            this.label_warning.TabIndex = 11;
            this.label_warning.Text = "Les modifications seront apportées à la prochaine génération.";
            this.label_warning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Paramètre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 423);
            this.Controls.Add(this.label_warning);
            this.Controls.Add(this.checkBox_enabledDirectionCouleur);
            this.Controls.Add(this.panel_directionReine);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel_directionReineToutAffiché);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel_caseTouchéParReine);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel__couleurB);
            this.Controls.Add(this.panel__couleurA);
            this.Controls.Add(this.panel_couleurA);
            this.Controls.Add(this.panel_couleurB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Paramètre";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paramètre";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Paramètre_FormClosed);
            this.Load += new System.EventHandler(this.Paramètre_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_couleurB;
        private System.Windows.Forms.Panel panel_couleurA;
        private System.Windows.Forms.Panel panel__couleurB;
        private System.Windows.Forms.Panel panel__couleurA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_caseTouchéParReine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel_directionReineToutAffiché;
        private System.Windows.Forms.Panel panel_directionReine;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox_enabledDirectionCouleur;
        private System.Windows.Forms.Label label_warning;
    }
}