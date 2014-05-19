using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Module_pv : Form
    {
        private int x=12;
        private int y=15;
        public Module_pv()
        {
            InitializeComponent();
        }

        private void lb_generer_Click(object sender, EventArgs e)
        {

        }


        private void Module_pv_Load(object sender, EventArgs e)
        {

        }

        private void controlePVcs1_Load(object sender, EventArgs e)
        {

        }

        private void controlePVcs2_Load(object sender, EventArgs e)
        {

        }

        private void Ajout_button_Click(object sender, EventArgs e)
        {
            
            if (y >= 300 && x == 340)
            {
                MessageBox.Show("Vous ne pouvez pas affichez plus de barre de vie");
            }
            else
            {
                if (y >= 300)
                {
                    y = -70;
                    x = 340;
                }
                
                
                    ControlePVcs controle = new ControlePVcs();
                    controle.Width = 300;
                    controle.Height = 52;
                    y += 70;
                    Point po = new Point(x, y);
                    Point poBu = new Point(x, y + 50);
                    this.Ajout_button.Location = poBu;
                    controle.Location = po;
                    this.Controls.Add(controle);
                
            }
            
           
        }
    }
}
