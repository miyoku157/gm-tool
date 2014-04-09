using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace EssaiGMTools
{
    public class Musique
    {
        private string nom;
        private string lien;
        private bool repet;
        private WindowsMediaPlayer Mp3Player;

        public Musique()
        {
            Mp3Player = new WMPLib.WindowsMediaPlayer();
            this.nom = "Aucune musique séléctionnée";
        }

        public Musique(string _nom, string _lien, bool _repet)
        {
            Mp3Player = new WMPLib.WindowsMediaPlayer();
            this.nom = _nom;
            this.lien = _lien;
            this.repet = _repet;
            if (repet) Mp3Player.settings.setMode("loop", true);
            Mp3Player.URL = @getLien();
            Mp3Player.controls.stop();
        }

        public string getLien()
        {
            return this.lien;
        }

        public string getNom()
        {
            return this.nom;
        }

        public bool getRepet()
        {
            return this.repet;
        }

        public void PlayFile()
        {
            if (Mp3Player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                Mp3Player.controls.pause();
            }
            else
            {
                Mp3Player.controls.play();
            }
        }

        public bool StopFile()
        {
            bool WerePlaying = false;
            if (Mp3Player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                Mp3Player.controls.stop();
                WerePlaying = true;
            }
            return WerePlaying;
        }
    }
}
