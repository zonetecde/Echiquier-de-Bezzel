namespace Echiquier_de_Bezzel
{
    partial class Case
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox_queen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_queen)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_queen
            // 
            this.pictureBox_queen.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_queen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox_queen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_queen.Image = global::Echiquier_de_Bezzel.Properties.Resources.queen;
            this.pictureBox_queen.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_queen.Name = "pictureBox_queen";
            this.pictureBox_queen.Size = new System.Drawing.Size(50, 50);
            this.pictureBox_queen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_queen.TabIndex = 0;
            this.pictureBox_queen.TabStop = false;
            this.pictureBox_queen.Visible = false;
            this.pictureBox_queen.MouseEnter += new System.EventHandler(this.Case_MouseEnter);
            this.pictureBox_queen.MouseLeave += new System.EventHandler(this.Case_MouseLeave);
            // 
            // Case
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.Controls.Add(this.pictureBox_queen);
            this.Name = "Case";
            this.Size = new System.Drawing.Size(50, 50);
            this.Load += new System.EventHandler(this.Case_Load);
            this.MouseEnter += new System.EventHandler(this.Case_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Case_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_queen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_queen;
    }
}
