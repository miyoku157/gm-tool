namespace GMTool
{
    partial class Module_pv
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
            this.Ajout_button = new System.Windows.Forms.Button();
            this.controlePVcs1 = new GMTool.ControlePVcs();
            this.SuspendLayout();
            // 
            // Ajout_button
            // 
            this.Ajout_button.Location = new System.Drawing.Point(26, 70);
            this.Ajout_button.Name = "Ajout_button";
            this.Ajout_button.Size = new System.Drawing.Size(152, 23);
            this.Ajout_button.TabIndex = 1;
            this.Ajout_button.Text = "Ajouter joueur";
            this.Ajout_button.UseVisualStyleBackColor = true;
            this.Ajout_button.Click += new System.EventHandler(this.Ajout_button_Click);
            // 
            // controlePVcs1
            // 
            this.controlePVcs1.Location = new System.Drawing.Point(12, 12);
            this.controlePVcs1.Name = "controlePVcs1";
            this.controlePVcs1.Size = new System.Drawing.Size(300, 52);
            this.controlePVcs1.TabIndex = 0;
            this.controlePVcs1.Load += new System.EventHandler(this.controlePVcs1_Load);
            // 
            // Module_pv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.Ajout_button);
            this.Controls.Add(this.controlePVcs1);
            this.Name = "Module_pv";
            this.Text = "Module PV";
            this.Load += new System.EventHandler(this.Module_pv_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ControlePVcs controlePVcs1;
        private System.Windows.Forms.Button Ajout_button;


    }
}

