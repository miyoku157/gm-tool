namespace GMTool
{
    partial class ControlePVcs
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
            this.bt_plus = new System.Windows.Forms.Button();
            this.Bt_moins = new System.Windows.Forms.Button();
            this.tb_pv = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Label_pnj = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt_plus
            // 
            this.bt_plus.Location = new System.Drawing.Point(46, 0);
            this.bt_plus.Name = "bt_plus";
            this.bt_plus.Size = new System.Drawing.Size(37, 23);
            this.bt_plus.TabIndex = 7;
            this.bt_plus.Text = "+";
            this.bt_plus.UseVisualStyleBackColor = true;
            this.bt_plus.Click += new System.EventHandler(this.bt_moins_Click);
            // 
            // Bt_moins
            // 
            this.Bt_moins.Location = new System.Drawing.Point(3, 1);
            this.Bt_moins.Name = "Bt_moins";
            this.Bt_moins.Size = new System.Drawing.Size(37, 23);
            this.Bt_moins.TabIndex = 6;
            this.Bt_moins.Text = "-";
            this.Bt_moins.UseVisualStyleBackColor = true;
            this.Bt_moins.Click += new System.EventHandler(this.Bt_plus_Click);
            // 
            // tb_pv
            // 
            this.tb_pv.Location = new System.Drawing.Point(93, 3);
            this.tb_pv.Name = "tb_pv";
            this.tb_pv.Size = new System.Drawing.Size(62, 20);
            this.tb_pv.TabIndex = 4;
            this.tb_pv.MouseLeave += new System.EventHandler(this.tb_pv_TextChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(162, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(125, 17);
            this.progressBar1.TabIndex = 8;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // Label_pnj
            // 
            this.Label_pnj.AutoSize = true;
            this.Label_pnj.Location = new System.Drawing.Point(3, 27);
            this.Label_pnj.Name = "Label_pnj";
            this.Label_pnj.Size = new System.Drawing.Size(64, 13);
            this.Label_pnj.TabIndex = 9;
            this.Label_pnj.Text = "Nom joueur:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(73, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            // 
            // ControlePVcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Label_pnj);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.bt_plus);
            this.Controls.Add(this.Bt_moins);
            this.Controls.Add(this.tb_pv);
            this.Name = "ControlePVcs";
            this.Size = new System.Drawing.Size(319, 51);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_plus;
        private System.Windows.Forms.Button Bt_moins;
        private System.Windows.Forms.TextBox tb_pv;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label Label_pnj;
        private System.Windows.Forms.TextBox textBox1;

    }
}
