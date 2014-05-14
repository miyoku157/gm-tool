using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GMTool
{
    public partial class Module_des : Form
    {
        public Random des = new Random();
        public Boolean erreur = false;
        public Module_des()
        {
            InitializeComponent();
            
        }
        private int random(int face)
        {

            int resultat=0;
            resultat = des.Next(face) + 1;
            return resultat;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"\d+");
            if (tb_chdes.Text!="" || tb_nblance.Text !="")
            {
                if (regex.IsMatch(tb_nblance.Text) && regex.IsMatch(tb_chdes.Text))
                {
                    if (erreur == true)
                    {
                        Rtb_result.Text = "";
                        erreur = false;

                    }
                    int nb_lancer = int.Parse(tb_nblance.Text);
                    int face_des = int.Parse(tb_chdes.Text);
                    for (int i = 0; i < nb_lancer; i++)
                    {
                        
                        Rtb_result.Text += random(face_des);
                        if (nb_lancer - 1 != i)
                        {
                            Rtb_result.Text += "-";
                        }

                    }
                    Rtb_result.Text += "\n";
                    Rtb_result.SelectAll();
                    Rtb_result.SelectionFont = new Font("Verdana", 12, FontStyle.Bold);
                    Rtb_result.SelectionAlignment = HorizontalAlignment.Center;

                }
                else
                {
                    Rtb_result.Text = "Veuillez remplir les textbox ci dessus avec des chiffres uniquement";
                    erreur = true;

                }
            }
            else
            {
                Rtb_result.Text = "Veuillez remplir les textbox ci dessus";
                erreur = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (erreur == true)
            {
                Rtb_result.Text = "";
                erreur = false;

            }
            Rtb_result.Text += random(20) + "\n";
            Rtb_result.SelectAll();
            Rtb_result.SelectionFont = new Font("Verdana", 12, FontStyle.Bold);
            Rtb_result.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void bt_raz_Click(object sender, EventArgs e)
        {
            if (erreur == true)
            {
                Rtb_result.Text = "";
                erreur = false;

            }
            Rtb_result.Text = "";
        }

        private void bt_D12_Click(object sender, EventArgs e)
        {
            if (erreur == true)
            {
                Rtb_result.Text = "";
                erreur = false;

            }
            Rtb_result.Text += random(12) + "\n";
            Rtb_result.SelectAll();
            Rtb_result.SelectionFont = new Font("Verdana", 12, FontStyle.Bold);
            Rtb_result.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (erreur == true)
            {
                Rtb_result.Text = "";
                erreur = false;

            }
            Rtb_result.Text += random(8) + "\n";
            Rtb_result.SelectAll();
            Rtb_result.SelectionFont = new Font("Verdana", 12, FontStyle.Bold);
            Rtb_result.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void bt_D6_Click(object sender, EventArgs e)
        {
            if (erreur == true)
            {
                Rtb_result.Text = "";
                erreur = false;

            }
            Rtb_result.Text += random(6) + "\n";
            Rtb_result.SelectAll();
            Rtb_result.SelectionFont = new Font("Verdana", 12, FontStyle.Bold);
            Rtb_result.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void bt_D4_Click(object sender, EventArgs e)
        {
            if (erreur == true)
            {
                Rtb_result.Text = "";
                erreur = false;
            }
            Rtb_result.Text += random(4) + "\n";
            Rtb_result.SelectAll();
            Rtb_result.SelectionFont = new Font("Verdana", 12, FontStyle.Bold);
            Rtb_result.SelectionAlignment = HorizontalAlignment.Center;

        }

        private void bt_D3_Click(object sender, EventArgs e)
        {
            if (erreur == true)
            {
                Rtb_result.Text = "";
                erreur = false;

            }
            Rtb_result.Text += random(3) + "\n";
            Rtb_result.SelectAll();
            Rtb_result.SelectionFont = new Font("Verdana", 12, FontStyle.Bold);
            Rtb_result.SelectionAlignment = HorizontalAlignment.Center;

        }

        private void bt_D100_Click(object sender, EventArgs e)
        {
            if (erreur == true)
            {
                Rtb_result.Text = "";
                erreur = false;

            }
            Rtb_result.Text += random(100) + "\n";
            Rtb_result.SelectAll();
            Rtb_result.SelectionFont = new Font("Verdana", 12, FontStyle.Bold);
            Rtb_result.SelectionAlignment = HorizontalAlignment.Center;
        }


    }
}
