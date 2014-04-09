namespace GMTool
{
    partial class MainForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabJoueur = new System.Windows.Forms.TabPage();
            this.tabMJ = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabJoueur);
            this.tabControl.Controls.Add(this.tabMJ);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(760, 537);
            this.tabControl.TabIndex = 0;
            // 
            // tabJoueur
            // 
            this.tabJoueur.Location = new System.Drawing.Point(4, 22);
            this.tabJoueur.Name = "tabJoueur";
            this.tabJoueur.Padding = new System.Windows.Forms.Padding(3);
            this.tabJoueur.Size = new System.Drawing.Size(752, 511);
            this.tabJoueur.TabIndex = 0;
            this.tabJoueur.Text = "Joueur";
            this.tabJoueur.UseVisualStyleBackColor = true;
            // 
            // tabMJ
            // 
            this.tabMJ.Location = new System.Drawing.Point(4, 22);
            this.tabMJ.Name = "tabMJ";
            this.tabMJ.Padding = new System.Windows.Forms.Padding(3);
            this.tabMJ.Size = new System.Drawing.Size(752, 511);
            this.tabMJ.TabIndex = 1;
            this.tabMJ.Text = "Maître de jeu";
            this.tabMJ.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "Page d\'acceuil";
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabJoueur;
        private System.Windows.Forms.TabPage tabMJ;
    }
}

