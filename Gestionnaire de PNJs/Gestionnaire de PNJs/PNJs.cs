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
    public partial class PNJs : Form
    {
        public static int numPerso = 0;
        public static int nbPerso = 0;

        public PNJs()
        {
            InitializeComponent();
        }

        public void modifLabel()
        {
            if (nbPerso == 0)
            {
                this.TBnom.Text = "";
                this.TBinfos.Text = "";
                this.TBstuff.Text = "";
                this.TBautres.Text = "";
            }
            else
            {
                this.TBnom.Text = Campagne.mesPNJs.ElementAt(numPerso).Value.getNom();
                this.TBinfos.Text = Campagne.mesPNJs.ElementAt(numPerso).Value.getText();
                this.TBstuff.Text = Campagne.mesPNJs.ElementAt(numPerso).Value.getEquip();
                this.TBautres.Text = Campagne.mesPNJs.ElementAt(numPerso).Value.getInfos();
                //this.TBautres.Text = Campagne.mesPNJs.ElementAt(numPerso).Value.getCarac(0, 0);
            }
            this.TBnom.Refresh();
            this.TBinfos.Refresh();
            this.TBstuff.Refresh();
            this.TBautres.Refresh();
        }

        private void PNJCreator_Click(object sender, EventArgs e)
        {
            PNJcreator myForm = new PNJcreator();
            myForm.Show();
        }

        private void Prev_Click(object sender, EventArgs e)
        {
            numPerso--;
            if (numPerso < 0)
            {
                numPerso = nbPerso - 1;
            }
            this.modifLabel();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            numPerso++;
            if (numPerso >= nbPerso)
            {
                numPerso = 0;
            }
            this.modifLabel();
        }

        private void suppr_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes vous sûr de vouloir supprimer ce PNJ ? ", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (nbPerso != 0)
                {
                    Campagne.mesPNJs.RemoveAt(numPerso);
                    nbPerso--;
                    numPerso--;
                    this.modifLabel();
                }
                else{
                    MessageBox.Show("Aucun PNJ à supprimer !");
                }
            }            
        }

        private void clear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes vous sûr de vouloir supprimer tout les PNJs ? ", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Campagne.mesPNJs.Clear();
                nbPerso = 0;
                numPerso = 0;
                this.modifLabel();
            }
        }
    }
}
