namespace Gestionnaire_de_PNJs
{
    partial class PNJs
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
            this.PNJCreator = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PNJCreator
            // 
            this.PNJCreator.Location = new System.Drawing.Point(95, 213);
            this.PNJCreator.Name = "PNJCreator";
            this.PNJCreator.Size = new System.Drawing.Size(90, 23);
            this.PNJCreator.TabIndex = 0;
            this.PNJCreator.Text = "Créer un PNJ";
            this.PNJCreator.UseVisualStyleBackColor = true;
            this.PNJCreator.Click += new System.EventHandler(this.PNJCreator_Click);
            // 
            // PNJs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.PNJCreator);
            this.Name = "PNJs";
            this.Text = "Gestionnaire de PNJs";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PNJCreator;
    }
}

