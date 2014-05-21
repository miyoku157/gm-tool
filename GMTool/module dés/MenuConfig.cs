using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GMTool
{
    public partial class MenuConfig : Form
    {
        private OpenFileDialog dialogMusic = new OpenFileDialog();
        private string[,] tabTB = new string[2, 6];
        private bool[] tabRepet = new bool[6];
        private Dictionary<string, TextBox> DicoTextbox = new Dictionary<string, TextBox>();
        private Dictionary<string, CheckBox> DicoCheckBox = new Dictionary<string, CheckBox>();
        private bool configSuper;
        private MainForm m_main;

        public MenuConfig(Musique[] playlist, bool repet, MainForm Main)
        {
            InitializeComponent();
            this.m_main = Main;
            if (repet)
            {
                checkBoxSuper.Checked = true;
            }
            else
            {
                checkBoxSuper.Checked = false;
            }

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

            DicoCheckBox.Add("checkBoxLoop1", checkBoxLoop1);
            DicoCheckBox.Add("checkBoxLoop2", checkBoxLoop2);
            DicoCheckBox.Add("checkBoxLoop3", checkBoxLoop3);
            DicoCheckBox.Add("checkBoxLoop4", checkBoxLoop4);
            DicoCheckBox.Add("checkBoxLoop5", checkBoxLoop5);
            DicoCheckBox.Add("checkBoxLoop6", checkBoxLoop6);

            int i = 0;

            foreach(Musique musique in playlist)
            {
                if (musique != null)
                {
                    DicoTextbox["Nom_" + (i +1)].Text = musique.getNom();
                    DicoTextbox["textBox" + (i + 1)].Text = musique.getLien();
                    DicoCheckBox["checkBoxLoop" + (i + 1)].Checked = musique.getRepet();
                }
                i++;
            }

            dialogMusic.Filter = "All Supported Audio | *.mp3; *.wma | MP3s | *.mp3 | WMAs | *.wma";
            dialogMusic.InitialDirectory = "c:\\";
            dialogMusic.RestoreDirectory = true;
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
                    if (DicoTextbox[nomTB + (j + 1)].Text == "")
                    {
                        tabTB[0, j] = "Musique non sélectionnée";
                    }
                    else
                    {
                        tabTB[i, j] = DicoTextbox[nomTB + (j + 1)].Text;
                    }
                    tabRepet[j] = DicoCheckBox["checkBoxLoop" + (j + 1)].Checked;
                }
            }
            this.m_main.displayInterface();
            this.m_main.retourConfig(tabTB, tabRepet, configSuper);
        }

        public void sauvegarde()
        {

        }

        private void Parcourir_1_Click(object sender, EventArgs e)
        {
            if (dialogMusic.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = dialogMusic.FileName;
                textBox1.Refresh();
            }
        }
        private void Parcourir_2_Click(object sender, EventArgs e)
        {
            if (dialogMusic.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = dialogMusic.FileName;
                textBox2.Refresh();
            }
       }
        private void Parcourir_3_Click(object sender, EventArgs e)
        {
            if (dialogMusic.ShowDialog() == DialogResult.OK)
            {
                textBox3.Text = dialogMusic.FileName;
                textBox3.Refresh();
            }
        }
        private void Parcourir_4_Click(object sender, EventArgs e)
        {
            if (dialogMusic.ShowDialog() == DialogResult.OK)
            {
                textBox4.Text = dialogMusic.FileName;
                textBox4.Refresh();
            }
        }
        private void Parcourir_5_Click(object sender, EventArgs e)
        {
            if (dialogMusic.ShowDialog() == DialogResult.OK)
            {
                textBox5.Text = dialogMusic.FileName;
                textBox5.Refresh();
            }
        }
        private void Parcourir_6_Click(object sender, EventArgs e)
        {
            if (dialogMusic.ShowDialog() == DialogResult.OK)
            {
                textBox6.Text = dialogMusic.FileName;
                textBox6.Refresh();
            }
        }

        private void Nom_1_Click(object sender, EventArgs e)
        {
            if (Nom_1.Text == "Non seléctionné") Nom_1.Text = "";
        }
        private void Nom_2_Click(object sender, EventArgs e)
        {
            if (Nom_2.Text == "Non seléctionné") Nom_2.Text = "";
        }
        private void Nom_3_Click(object sender, EventArgs e)
        {
            if (Nom_3.Text == "Non seléctionné") Nom_3.Text = "";
        }
        private void Nom_4_Click(object sender, EventArgs e)
        {
            if (Nom_4.Text == "Non seléctionné") Nom_4.Text = "";
        }
        private void Nom_5_Click(object sender, EventArgs e)
        {
            if (Nom_5.Text == "Non seléctionné") Nom_5.Text = "";
        }
        private void Nom_6_Click(object sender, EventArgs e)
        {
            if (Nom_6.Text == "Non seléctionné") Nom_6.Text = "";
        }

        private void checkBoxSuper_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxSuper.Checked)configSuper = true;
            else configSuper = false;
        }
        private void checkBoxLoop1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLoop1.Checked) tabRepet[0] = true;
            else tabRepet[0] = false;
        }
        private void checkBoxLoop2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLoop2.Checked) tabRepet[1] = true;
            else tabRepet[1] = false;
        }
        private void checkBoxLoop3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLoop3.Checked) tabRepet[2] = true;
            else tabRepet[2] = false;
        }
        private void checkBoxLoop4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLoop4.Checked) tabRepet[3] = true;
            else tabRepet[3] = false;
        }
        private void checkBoxLoop5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLoop5.Checked) tabRepet[4] = true;
            else tabRepet[4] = false;
        }
        private void checkBoxLoop6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLoop6.Checked) tabRepet[5] = true;
            else tabRepet[5] = false;
        }
    }
}
