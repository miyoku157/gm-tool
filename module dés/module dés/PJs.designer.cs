namespace GMTool
{
    partial class PJs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PJs));
            this.PNJs = new AxAcroPDFLib.AxAcroPDF();
            this.Ajouter = new System.Windows.Forms.Button();
            this.Precedent = new System.Windows.Forms.Button();
            this.Suivant = new System.Windows.Forms.Button();
            this.Pagination = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PNJs)).BeginInit();
            this.SuspendLayout();
            // 
            // PNJs
            // 
            this.PNJs.Enabled = true;
            this.PNJs.Location = new System.Drawing.Point(50, 10);
            this.PNJs.Name = "PNJs";
            this.PNJs.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("PNJs.OcxState")));
            this.PNJs.Size = new System.Drawing.Size(400, 500);
            this.PNJs.TabIndex = 0;
            // 
            // Ajouter
            // 
            this.Ajouter.Location = new System.Drawing.Point(200, 516);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(100, 40);
            this.Ajouter.TabIndex = 1;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = true;
            this.Ajouter.Click += new System.EventHandler(this.Ouvrir_Click);
            // 
            // Precedent
            // 
            this.Precedent.Location = new System.Drawing.Point(10, 200);
            this.Precedent.Name = "Precedent";
            this.Precedent.Size = new System.Drawing.Size(30, 35);
            this.Precedent.TabIndex = 2;
            this.Precedent.Text = "<";
            this.Precedent.UseVisualStyleBackColor = true;
            this.Precedent.Click += new System.EventHandler(this.Precedent_Click);
            // 
            // Suivant
            // 
            this.Suivant.Location = new System.Drawing.Point(460, 200);
            this.Suivant.Name = "Suivant";
            this.Suivant.Size = new System.Drawing.Size(30, 35);
            this.Suivant.TabIndex = 3;
            this.Suivant.Text = ">";
            this.Suivant.UseVisualStyleBackColor = true;
            this.Suivant.Click += new System.EventHandler(this.Suivant_Click);
            // 
            // Pagination
            // 
            this.Pagination.Location = new System.Drawing.Point(200, 562);
            this.Pagination.Name = "Pagination";
            this.Pagination.ReadOnly = true;
            this.Pagination.Size = new System.Drawing.Size(100, 20);
            this.Pagination.TabIndex = 4;
            this.Pagination.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PJs
            // 
            this.AcceptButton = this.Ajouter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 600);
            this.Controls.Add(this.Pagination);
            this.Controls.Add(this.Suivant);
            this.Controls.Add(this.Precedent);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.PNJs);
            this.MaximizeBox = false;
            this.Name = "PJs";
            this.Text = "PJs";
            this.Resize += new System.EventHandler(this.redim);
            ((System.ComponentModel.ISupportInitialize)(this.PNJs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxAcroPDFLib.AxAcroPDF PNJs;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.Button Precedent;
        private System.Windows.Forms.Button Suivant;
        private System.Windows.Forms.TextBox Pagination;

    }
}

