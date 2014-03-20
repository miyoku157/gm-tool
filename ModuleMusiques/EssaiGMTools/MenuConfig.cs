using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace EssaiGMTools
{
    public partial class MenuConfig : Form
    {
        private OpenFileDialog dialogMusic = new OpenFileDialog();
        private string[,] tabTB = new string[2, 6];
        private Dictionary<string, TextBox> DicoTextbox = new Dictionary<string, TextBox>();

        public MenuConfig()
        {
            InitializeComponent();
            DicoTextbox.Add("Nom_1", Nom_1);
            DicoTextbox.Add("Nom_2", Nom_2);
            DicoTextbox.Add("Nom_3", Nom_3);
            DicoTextbox.Add("Nom_4", Nom_4);
            DicoTextbox.Add("Nom_5", Nom_5);
            DicoTextbox.Add("Nom_6", Nom_6);

            DicoTextbox.Add("textBox1", textBox1);
            DicoTextbox.Add("textBox2", textBox2);
            DicoTextbox.Add("textBox3", textBox3);
            DicoTextbox.Add("textBox4", textBox4);
            DicoTextbox.Add("textBox5", textBox5);
            DicoTextbox.Add("textBox6", textBox6);
        }

        private void Parcourir_1_Click(object sender, EventArgs e)
        {
            dialogMusic.InitialDirectory = "c:\\";

            // S'occuper des filtres !

            //dialogMusic.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            //dialogMusic.FilterIndex = 2;
            dialogMusic.RestoreDirectory = true;

            if (dialogMusic.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = dialogMusic.FileName;
                textBox1.Refresh();
            }
        }

        private void Parcourir_2_Click(object sender, EventArgs e)
        {
            dialogMusic.InitialDirectory = "c:\\";
            dialogMusic.RestoreDirectory = true;

            if (dialogMusic.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = dialogMusic.FileName;
                textBox2.Refresh();
            }
        }

        private void button_valider_Click(object sender, EventArgs e)
        {
            string nomTB = "";
            for (int i = 0; i < 2; i++)
            {
                switch (i)
                {
                    case 0:
                        nomTB = "Nom_";
                        break;
                    case 1:
                        nomTB = "textBox";
                        break;
                }
                for (int j = 0; j < 6; j++)
                {
                    tabTB[i, j] = DicoTextbox[nomTB + (j + 1)].Text;
                }
            }
            if (System.Windows.Forms.Application.OpenForms["Interface"] != null)
            {
                (System.Windows.Forms.Application.OpenForms["Interface"] as Interface).retourConfig(tabTB);
            }
        }
    }
}
