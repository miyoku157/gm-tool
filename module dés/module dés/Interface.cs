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

namespace GMTool
{
    public partial class Interface : Form
    {
        private Musique[] playlist = new Musique[6];
        private Musique playing;
        private Dictionary<string, Button> DicoButton = new Dictionary<string, Button>();
        private bool configSuper;
        private MenuConfig config;

        public Interface()
        {
            InitializeComponent();
            playing = new Musique("", "", false);
            DicoButton.Add("button1", button1);
            DicoButton.Add("button2", button2);
            DicoButton.Add("button3", button3);
            DicoButton.Add("button4", button4);
            DicoButton.Add("button5", button5);
            DicoButton.Add("button6", button6);
        }

        private void buttonConfig_Click(object sender, EventArgs e)
        {
            config = new MenuConfig(playlist, configSuper);
            config.Show();
        }

        public void retourConfig(string[,] tabMusique, bool[] tabRepet, bool super)
        {
            config.Close();
            configSuper = super;
            string nomButton = "";
            for (int i = 0; i < 6; i++)
            {
                if (playlist[i] != null)
                {
                    playlist[i].StopFile();
                }                

                nomButton = "button" + (i + 1);
                playlist[i] = new Musique(tabMusique[0, i], tabMusique[1, i], tabRepet[i]);
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
            if(configSuper)
            {
                playing = playlist[0];
                if (playing != null)
                {
                    if (playing.getLien() != "") playing.PlayFile();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Musique 1 non selectionnée");
                }
            }
            else
            {
                if (playing.Equals(playlist[0]) && playlist[0] != null)
                {
                    playlist[0].PlayFile();
                }
                else if (playlist[0] != null && playlist[0].getLien() != "")
                {
                    playing.StopFile();
                    playing = playlist[0];
                    playlist[0].PlayFile();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Musique 1 non selectionnée");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (configSuper)
            {
                playing = playlist[1];
                if (playing != null)
                {
                    if(playing.getLien() != "") playing.PlayFile();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Musique 2 non selectionnée");
                }
            }
            else
            {
                if(playing.Equals(playlist[1]) && playlist[1] != null)
                {
                    playlist[1].PlayFile();
                }
                else if(playlist[1] != null && playlist[1].getLien() != "")
                {
                    playing.StopFile();
                    playing = playlist[1];
                    playlist[1].PlayFile();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Musique 2 non selectionnée");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (configSuper)
            {
                playing = playlist[2];
                if (playing != null)
                {
                    if (playing.getLien() != "") playing.PlayFile();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Musique 3 non selectionnée");
                }
            }
            else
            {
                if (playing.Equals(playlist[2]) && playlist[2] != null)
                {
                    playlist[2].PlayFile();
                }
                else if (playlist[2] != null && playlist[2].getLien() != "")
                {
                    playing.StopFile();
                    playing = playlist[2];
                    playlist[2].PlayFile();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Musique 3 non selectionnée");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (configSuper)
            {
                playing = playlist[3];
                if (playing != null)
                {
                    if (playing.getLien() != "") playing.PlayFile();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Musique 4 non selectionnée");
                }
            }
            else
            {
                if (playing.Equals(playlist[3]) && playlist[3] != null)
                {
                    playlist[3].PlayFile();
                }
                else if (playlist[3] != null && playlist[3].getLien() != "")
                {
                    playing.StopFile();
                    playing = playlist[3];
                    playlist[3].PlayFile();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Musique 4 non selectionnée");
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (configSuper)
            {
                playing = playlist[4];
                if (playing != null)
                {
                    if (playing.getLien() != "") playing.PlayFile();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Musique 5 non selectionnée");
                }
            }
            else
            {
                if (playing.Equals(playlist[4]) && playlist[4] != null)
                {
                    playlist[4].PlayFile();
                }
                else if (playlist[4] != null && playlist[4].getLien() != "")
                {
                    playing.StopFile();
                    playing = playlist[4];
                    playlist[4].PlayFile();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Musique 5 non selectionnée");
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (configSuper)
            {
                playing = playlist[5];
                if (playing != null)
                {
                    if (playing.getLien() != "") playing.PlayFile();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Musique 6 non selectionnée");
                }
            }
            else
            {
                if (playing.Equals(playlist[5]) && playlist[5] != null)
                {
                    playlist[5].PlayFile();
                }
                else if (playlist[5] != null && playlist[5].getLien() != "")
                {
                    playing.StopFile();
                    playing = playlist[5];
                    playlist[5].PlayFile();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Musique 6 non selectionnée");
                }
            }
        }

    }
}
