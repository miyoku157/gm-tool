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
            this.Prev = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.seachButton = new System.Windows.Forms.Button();
            this.suppr = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.labelNom = new System.Windows.Forms.Label();
            this.TBnom = new System.Windows.Forms.TextBox();
            this.labelAutres = new System.Windows.Forms.Label();
            this.labelStuff = new System.Windows.Forms.Label();
            this.TBstuff = new System.Windows.Forms.RichTextBox();
            this.TBautres = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TBinfos = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // PNJCreator
            // 
            this.PNJCreator.Location = new System.Drawing.Point(96, 520);
            this.PNJCreator.Name = "PNJCreator";
            this.PNJCreator.Size = new System.Drawing.Size(90, 23);
            this.PNJCreator.TabIndex = 0;
            this.PNJCreator.Text = "Créer un PNJ";
            this.PNJCreator.UseVisualStyleBackColor = true;
            this.PNJCreator.Click += new System.EventHandler(this.PNJCreator_Click);
            // 
            // Prev
            // 
            this.Prev.Location = new System.Drawing.Point(12, 565);
            this.Prev.Name = "Prev";
            this.Prev.Size = new System.Drawing.Size(75, 23);
            this.Prev.TabIndex = 5;
            this.Prev.Text = "Précédent";
            this.Prev.UseVisualStyleBackColor = true;
            this.Prev.Click += new System.EventHandler(this.Prev_Click);
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(489, 564);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 23);
            this.Next.TabIndex = 6;
            this.Next.Text = "Suivant";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(189, 567);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // seachButton
            // 
            this.seachButton.Location = new System.Drawing.Point(295, 564);
            this.seachButton.Name = "seachButton";
            this.seachButton.Size = new System.Drawing.Size(75, 23);
            this.seachButton.TabIndex = 8;
            this.seachButton.Text = "Rechercher";
            this.seachButton.UseVisualStyleBackColor = true;
            // 
            // suppr
            // 
            this.suppr.Location = new System.Drawing.Point(374, 520);
            this.suppr.Name = "suppr";
            this.suppr.Size = new System.Drawing.Size(107, 23);
            this.suppr.TabIndex = 9;
            this.suppr.Text = "Supprimer le PNJ";
            this.suppr.UseVisualStyleBackColor = true;
            this.suppr.Click += new System.EventHandler(this.suppr_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(192, 520);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(176, 23);
            this.clear.TabIndex = 10;
            this.clear.Text = "Supprimer tous les PNJs";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(52, 20);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(35, 13);
            this.labelNom.TabIndex = 11;
            this.labelNom.Text = "Nom :";
            // 
            // TBnom
            // 
            this.TBnom.Enabled = false;
            this.TBnom.Location = new System.Drawing.Point(96, 13);
            this.TBnom.Name = "TBnom";
            this.TBnom.Size = new System.Drawing.Size(272, 20);
            this.TBnom.TabIndex = 12;
            // 
            // labelAutres
            // 
            this.labelAutres.AutoSize = true;
            this.labelAutres.Location = new System.Drawing.Point(52, 369);
            this.labelAutres.Name = "labelAutres";
            this.labelAutres.Size = new System.Drawing.Size(43, 13);
            this.labelAutres.TabIndex = 14;
            this.labelAutres.Text = "Autres :";
            // 
            // labelStuff
            // 
            this.labelStuff.AutoSize = true;
            this.labelStuff.Location = new System.Drawing.Point(52, 229);
            this.labelStuff.Name = "labelStuff";
            this.labelStuff.Size = new System.Drawing.Size(69, 13);
            this.labelStuff.TabIndex = 15;
            this.labelStuff.Text = "Équipement :";
            // 
            // TBstuff
            // 
            this.TBstuff.Enabled = false;
            this.TBstuff.Location = new System.Drawing.Point(55, 245);
            this.TBstuff.Name = "TBstuff";
            this.TBstuff.Size = new System.Drawing.Size(480, 112);
            this.TBstuff.TabIndex = 16;
            this.TBstuff.Text = "";
            // 
            // TBautres
            // 
            this.TBautres.Enabled = false;
            this.TBautres.Location = new System.Drawing.Point(55, 386);
            this.TBautres.Name = "TBautres";
            this.TBautres.Size = new System.Drawing.Size(480, 120);
            this.TBautres.TabIndex = 17;
            this.TBautres.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Compétences :";
            // 
            // TBinfos
            // 
            this.TBinfos.Enabled = false;
            this.TBinfos.Location = new System.Drawing.Point(55, 117);
            this.TBinfos.Name = "TBinfos";
            this.TBinfos.Size = new System.Drawing.Size(480, 99);
            this.TBinfos.TabIndex = 19;
            this.TBinfos.Text = "";
            // 
            // PNJs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 601);
            this.Controls.Add(this.TBinfos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBautres);
            this.Controls.Add(this.TBstuff);
            this.Controls.Add(this.labelStuff);
            this.Controls.Add(this.labelAutres);
            this.Controls.Add(this.TBnom);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.suppr);
            this.Controls.Add(this.seachButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Prev);
            this.Controls.Add(this.PNJCreator);
            this.MaximizeBox = false;
            this.Name = "PNJs";
            this.Text = "Gestionnaire de PNJs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PNJCreator;
        private System.Windows.Forms.Button Prev;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button seachButton;
        private System.Windows.Forms.Button suppr;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.TextBox TBnom;
        private System.Windows.Forms.Label labelAutres;
        private System.Windows.Forms.Label labelStuff;
        private System.Windows.Forms.RichTextBox TBstuff;
        private System.Windows.Forms.RichTextBox TBautres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox TBinfos;
    }
}

