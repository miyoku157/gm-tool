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
            this.btnMusique = new System.Windows.Forms.Button();
            this.btnDes = new System.Windows.Forms.Button();
            this.btnPJs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMusique
            // 
            this.btnMusique.Location = new System.Drawing.Point(17, 12);
            this.btnMusique.Name = "btnMusique";
            this.btnMusique.Size = new System.Drawing.Size(98, 34);
            this.btnMusique.TabIndex = 1;
            this.btnMusique.Text = "Musique";
            this.btnMusique.UseVisualStyleBackColor = true;
            this.btnMusique.Click += new System.EventHandler(this.btnMusique_Click);
            // 
            // btnDes
            // 
            this.btnDes.Location = new System.Drawing.Point(121, 12);
            this.btnDes.Name = "btnDes";
            this.btnDes.Size = new System.Drawing.Size(98, 34);
            this.btnDes.TabIndex = 2;
            this.btnDes.Text = "Dés";
            this.btnDes.UseVisualStyleBackColor = true;
            this.btnDes.Click += new System.EventHandler(this.btnDes_Click);
            // 
            // btnPJs
            // 
            this.btnPJs.Location = new System.Drawing.Point(225, 12);
            this.btnPJs.Name = "btnPJs";
            this.btnPJs.Size = new System.Drawing.Size(98, 34);
            this.btnPJs.TabIndex = 3;
            this.btnPJs.Text = "Gestion de Pjs";
            this.btnPJs.UseVisualStyleBackColor = true;
            this.btnPJs.Click += new System.EventHandler(this.btnPJs_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.btnPJs);
            this.Controls.Add(this.btnDes);
            this.Controls.Add(this.btnMusique);
            this.Name = "MainForm";
            this.Text = "GMTool";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMusique;
        private System.Windows.Forms.Button btnDes;
        private System.Windows.Forms.Button btnPJs;

    }
}

