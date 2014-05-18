using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionnaire_de_PNJs
{
    public class PNJ
    {
        private string nom;

        private string[,] caracteristiques;

        private string équpement;

        private string infos;

        private string texte;

        public string getCarac(int i, int j)
        {
            return caracteristiques[i,j];
        }

        public string getInfos()
        {
            return infos;
        }

        public string getNom()
        {
            return nom;
        }

        public string getEquip()
        {
            return équpement;
        }

        public string getText()
        {
            return texte;
        }

        public PNJ(string nomPNJ, string textePNJ, string stuffPNJ, string[,] caracsPNJ, string infosPNJ)
        {
            this.nom = nomPNJ;
            this.caracteristiques = caracsPNJ;
            this.équpement = stuffPNJ;
            this.texte = textePNJ;
            this.infos = infosPNJ;
        }
    }
}
