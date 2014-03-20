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

        public Interface()
        {
            InitializeComponent();
        }

        private void buttonConfig_Click(object sender, EventArgs e)
        {
            MenuConfig config = new MenuConfig();
            config.Show();
            for (int i = 0; i < 6; i++)
            {
                if (playlist[i] != null)
                {
                    playlist[i].StopFile();
                }
                switch (i)
                {
                    case 0:
                        playlist[i] = new Musique("Archangel", "C:/Users/Léo/Music/TSFH/Archangel/02 Archangel.mp3");
                        button1.Text = playlist[i].getNom();
                        button1.Refresh();
                        break;
                    case 1:
                        playlist[i] = new Musique("Norwegian Pirate", "C:/Users/Léo/Music/TSFH/Archangel/13 Norwegian Pirate.mp3");
                        button2.Text = playlist[i].getNom();
                        button2.Refresh();
                        break;
                    case 2:
                        playlist[i] = new Musique("Nero", "C:/Users/Léo/Music/TSFH/Archangel/07 Nero.mp3");
                        button3.Text = playlist[i].getNom();
                        button3.Refresh();
                        break;
                    case 3:
                        playlist[i] = new Musique("Strength of a Thousand Men", "C:/Users/Léo/Music/TSFH/Archangel/10 Strength of a Thousand Men.mp3");
                        button4.Text = playlist[i].getNom();
                        button4.Refresh();
                        break;
                    case 4:
                        playlist[i] = new Musique("He Who Brings the Night", "C:/Users/Léo/Music/TSFH/Archangel/21 He Who Brings the Night.mp3");
                        button5.Text = playlist[i].getNom();
                        button5.Refresh();
                        break;
                    case 5:
                        playlist[i] = new Musique("United We Stand - Divided We Fall", "C:/Users/Léo/Music/TSFH/Archangel/04 United We Stand - Divided We Fall.mp3");
                        button6.Text = playlist[i].getNom();
                        button6.Refresh();
                        break;
                }
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
