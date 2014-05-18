using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestionnaire_de_PNJs
{
    public partial class PNJcreator : Form
    {

        int CompteurCarac = 1;
        private Dictionary<string, TextBox> DicoTextbox = new Dictionary<string, TextBox>();

        public PNJcreator()
        {
            InitializeComponent();
            DicoTextbox.Add("Ncarac1", Ncarac1);
            DicoTextbox.Add("Ncarac2", Ncarac2);
            DicoTextbox.Add("Ncarac3", Ncarac3);
            DicoTextbox.Add("Ncarac4", Ncarac4);
            DicoTextbox.Add("Ncarac5", Ncarac5);
            DicoTextbox.Add("Ncarac6", Ncarac6);
            DicoTextbox.Add("Ncarac7", Ncarac7);
            DicoTextbox.Add("Ncarac8", Ncarac8);
            DicoTextbox.Add("Ncarac9", Ncarac9);
            DicoTextbox.Add("Ncarac10", Ncarac10);
            DicoTextbox.Add("Vcarac1", Vcarac1);
            DicoTextbox.Add("Vcarac2", Vcarac2);
            DicoTextbox.Add("Vcarac3", Vcarac3);
            DicoTextbox.Add("Vcarac4", Vcarac4);
            DicoTextbox.Add("Vcarac5", Vcarac5);
            DicoTextbox.Add("Vcarac6", Vcarac6);
            DicoTextbox.Add("Vcarac7", Vcarac7);
            DicoTextbox.Add("Vcarac8", Vcarac8);
            DicoTextbox.Add("Vcarac9", Vcarac9);
            DicoTextbox.Add("Vcarac10", Vcarac10);
        }

        public void Validation_Click(object sender, EventArgs e)
        {
            string[,] caracs = new string[CompteurCarac, 2];
            string Ncarac = "Ncarac";
            string Vcarac = "Vcarac";

            for (int i = 0; i < CompteurCarac; i++)
            {
                Ncarac = "Ncarac" + (i+1).ToString();
                Vcarac = "Vcarac" + (i+1).ToString();
                caracs[i, 0] = DicoTextbox[Ncarac].Text;
                caracs[i, 1] = DicoTextbox[Vcarac].Text;
            }
            PNJ monPNJ = new PNJ(NomPNJ.Text, Autres.Text, Équipement.Text, caracs, infos.Text);
            PNJs.numPerso = PNJs.nbPerso;
            Campagne.mesPNJs.Add(PNJs.nbPerso, monPNJ);
            PNJs.nbPerso++;
            if (System.Windows.Forms.Application.OpenForms["PNJs"] != null)
            {
                (System.Windows.Forms.Application.OpenForms["PNJs"] as PNJs).modifLabel();
            }
            this.Close();
        }

        private void SupprCarac_Click(object sender, EventArgs e)
        {
            if(CompteurCarac > 1){
                string Ncarac = "Ncarac" + CompteurCarac;
                string Vcarac = "Vcarac" + CompteurCarac;
                DicoTextbox[Ncarac].Text = null;
                DicoTextbox[Ncarac].Visible = false;
                DicoTextbox[Ncarac].Enabled = false;
                DicoTextbox[Vcarac].Text = null;
                DicoTextbox[Vcarac].Visible = false;
                DicoTextbox[Vcarac].Enabled = false;
                this.CompteurCarac--;
            }
        }

        private void AjoutCarac_Click(object sender, EventArgs e)
        {
            if(CompteurCarac < 10){
                this.CompteurCarac++;
                string Ncarac = "Ncarac" + CompteurCarac;
                string Vcarac = "Vcarac" + CompteurCarac;
                DicoTextbox[Ncarac].Visible = true;
                DicoTextbox[Ncarac].Enabled = true;
                DicoTextbox[Vcarac].Visible = true;
                DicoTextbox[Vcarac].Enabled = true;
            }
        }
    }
}
