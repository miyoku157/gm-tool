using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace EssaiGMTools
{
    public partial class Interface : Form
    {
        private Musique[] playlist = new Musique[6];
        private Dictionary<string, Button> DicoButton = new Dictionary<string, Button>();
        public MenuConfig config;

        public Interface()
        {
            InitializeComponent();
            DicoButton.Add("button1", button1);
            DicoButton.Add("button2", button2);
            DicoButton.Add("button3", button3);
            DicoButton.Add("button4", button4);
            DicoButton.Add("button5", button5);
            DicoButton.Add("button6", button6);
        }

        private void buttonConfig_Click(object sender, EventArgs e)
        {
            config = new MenuConfig();
            config.Show();
        }

        public void retourConfig(string[,] tab)
        {
            config.Close();
            string nomButton = "";
            for (int i = 0; i < 6; i++)
            {
                if (playlist[i] != null)
                {
                    playlist[i].StopFile();
                }                

                nomButton = "button" + (i + 1);
                playlist[i] = new Musique(tab[0, i], tab[1, i]);
                DicoButton[nomButton].Text = playlist[i].getNom();
                DicoButton[nomButton].Refresh();
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            bool test = false;
            bool vide = true;
            foreach (Musique element in playlist)
            {
                if (element != null)
                {
                    vide = false;
                    if (element.StopFile() == true)
                    {
                        test = true;
                    }
                }
            }
            if (test == false)
            {
                if (vide == true)
                {
                    System.Windows.Forms.MessageBox.Show("Aucune musique selectionée");
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Aucune musique en lecture");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Musique element in playlist)
            {
                if (element != null)
                {
                    element.StopFile();
                }
            }
            if (playlist[0] != null)
            {
                playlist[0].PlayFile();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Musique 1 non selectionnée");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Musique element in playlist)
            {
                if (element != null)
                {
                    element.StopFile();
                }
            }
            if (playlist[1] != null)
            {
                playlist[1].PlayFile();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Musique 2 non selectionnée");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Musique element in playlist)
            {
                if (element != null)
                {
                    element.StopFile();
                }
            }
            if (playlist[2] != null)
            {
                playlist[2].PlayFile();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Musique 3 non selectionnée");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (Musique element in playlist)
            {
                if (element != null)
                {
                    element.StopFile();
                }
            }
            if (playlist[3] != null)
            {
                playlist[3].PlayFile();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Musique 4 non selectionnée");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (Musique element in playlist)
            {
                if (element != null)
                {
                    element.StopFile();
                }
            }
            if (playlist[4] != null)
            {
                playlist[4].PlayFile();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Musique 5 non selectionnée");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            foreach (Musique element in playlist)
            {
                if (element != null)
                {
                    element.StopFile();
                }
            }
            if (playlist[5] != null)
            {
                playlist[5].PlayFile();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Musique 6 non selectionnée");
            }
        }

    }
}
