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
    public partial class PJs : Form
    {
        protected SortedList<int, string> galerie = new SortedList<int, string>();
        protected int i = 0;
        protected int j = 0;

        public PJs()
        {
            InitializeComponent();
        }

        private void Ouvrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenDial = new OpenFileDialog();

            OpenDial.Filter = "Fichiers PDF|*.pdf";
            OpenDial.DefaultExt = "*.pdf";
            OpenDial.Multiselect = false;
            OpenDial.CheckFileExists = true;
            OpenDial.InitialDirectory = Application.StartupPath;

            if (OpenDial.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                galerie.Add(j, OpenDial.FileName);
                PNJs.LoadFile(galerie.Values[j]);
                this.i = this.j;
                this.j++;
                Pagination.Text = (i + 1) + "/" + (j);
                Pagination.Refresh();
            }
        }

        private void Suivant_Click(object sender, EventArgs e)
        {
            this.i++;
            if (i >= galerie.Count)
            {
                i = 0;
            }
            PNJs.LoadFile(galerie.Values[i]);
            Pagination.Text = (i + 1) + "/" + (j);
            Pagination.Refresh();

        }

        private void Precedent_Click(object sender, EventArgs e)
        {
            this.i--;
            if (i < 0)
            {
                i = galerie.Count - 1;
            }
            PNJs.LoadFile(galerie.Values[i]);
            Pagination.Text = (i + 1) + "/" + (j);
            Pagination.Refresh();
        }

        private void redim(object sender, EventArgs e)
        {
            PNJs.Height = (int)(PJs.ActiveForm.Height - 120);
            PNJs.Width = (int)(PJs.ActiveForm.Width - 115);
            Suivant.Location = new System.Drawing.Point(PNJs.Width + 60, 200);
            Ajouter.Location = new System.Drawing.Point((int)(PJs.ActiveForm.Width / 2 - 50), (int)(PNJs.Height + 15));
            Pagination.Location = new System.Drawing.Point((int)(PJs.ActiveForm.Width / 2 - 50), (int)(PNJs.Height + 60));
            PJs.ActiveForm.Height = (int)(PJs.ActiveForm.Width * 6 / 5);
        }
    }
}
