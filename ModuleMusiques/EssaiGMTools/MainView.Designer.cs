namespace EssaiGMTools
{
    partial class MainView
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
            this.BTMusique = new System.Windows.Forms.Button();
            this.OngletsAcceuil = new System.Windows.Forms.TabControl();
            this.Player_Tab = new System.Windows.Forms.TabPage();
            this.MJ_Tab = new System.Windows.Forms.TabPage();
            this.OngletsAcceuil.SuspendLayout();
            this.MJ_Tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTMusique
            // 
            this.BTMusique.Location = new System.Drawing.Point(6, 6);
            this.BTMusique.Name = "BTMusique";
            this.BTMusique.Size = new System.Drawing.Size(122, 23);
            this.BTMusique.TabIndex = 1;
            this.BTMusique.Text = "Musique !";
            this.BTMusique.UseVisualStyleBackColor = true;
            this.BTMusique.Click += new System.EventHandler(this.BTMusique_Click);
            // 
            // OngletsAcceuil
            // 
            this.OngletsAcceuil.Controls.Add(this.Player_Tab);
            this.OngletsAcceuil.Controls.Add(this.MJ_Tab);
            this.OngletsAcceuil.Location = new System.Drawing.Point(12, 12);
            this.OngletsAcceuil.Name = "OngletsAcceuil";
            this.OngletsAcceuil.SelectedIndex = 0;
            this.OngletsAcceuil.Size = new System.Drawing.Size(760, 496);
            this.OngletsAcceuil.TabIndex = 2;
            // 
            // Player_Tab
            // 
            this.Player_Tab.Location = new System.Drawing.Point(4, 22);
            this.Player_Tab.Name = "Player_Tab";
            this.Player_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.Player_Tab.Size = new System.Drawing.Size(752, 441);
            this.Player_Tab.TabIndex = 0;
            this.Player_Tab.Text = "Joueur ";
            this.Player_Tab.UseVisualStyleBackColor = true;
            // 
            // MJ_Tab
            // 
            this.MJ_Tab.Controls.Add(this.BTMusique);
            this.MJ_Tab.Location = new System.Drawing.Point(4, 22);
            this.MJ_Tab.Name = "MJ_Tab";
            this.MJ_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.MJ_Tab.Size = new System.Drawing.Size(752, 470);
            this.MJ_Tab.TabIndex = 1;
            this.MJ_Tab.Text = "Maître de jeu";
            this.MJ_Tab.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.OngletsAcceuil);
            this.Name = "MainView";
            this.Text = "MainView";
            this.OngletsAcceuil.ResumeLayout(false);
            this.MJ_Tab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTMusique;
        private System.Windows.Forms.TabControl OngletsAcceuil;
        private System.Windows.Forms.TabPage Player_Tab;
        private System.Windows.Forms.TabPage MJ_Tab;
    }
}