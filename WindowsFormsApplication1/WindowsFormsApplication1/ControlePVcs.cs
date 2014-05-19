using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication1
{
    public partial class ControlePVcs : UserControl
    {
        public ControlePVcs()
        {
            InitializeComponent();
        }
        private void tb_pv_TextChanged(Object sender, EventArgs e)
        {
            if (tb_pv.Text != null && tb_pv.Text != "")
            {
                String[] chaine_base = extraireChaine(tb_pv.Text);
                String chaine_pv = chaine_base[0];
                int pv;
                if (int.TryParse(chaine_pv, out pv))
                {
                    pv = int.Parse(chaine_pv);
                    if (chaine_base[2] == "")
                    {
                        tb_pv.Text = pv.ToString();
                    }
                    else
                    {

                        tb_pv.Text = pv.ToString() + chaine_base[1] + chaine_base[2];
                    }
                }
                else
                {
                    tb_pv.Text = "";
                }
                int test;
                if (int.TryParse(chaine_base[2], out test))
                {
                    if (pv < 0)
                    {
                        pv = 0;
                    }
                    while (pv > progressBar1.Maximum)
                    {
                        pv--;
                    }
                    progressBar1.Value = pv;
                    test = int.Parse(chaine_base[2]);
                    progressBar1.Maximum = test;
                    progressBar1.Minimum = 0;

                }
            }
        }
        private void Bt_plus_Click(object sender, EventArgs e)
        {
            if (tb_pv.Text != null && tb_pv.Text != "")
            {
                String[] chaine_base = extraireChaine(tb_pv.Text);
                String chaine_pv = chaine_base[0];
                int pv;
                if (int.TryParse(chaine_pv, out pv))
                {
                    pv = int.Parse(chaine_pv);
                    pv -= 1;
                    tb_pv.Text = pv.ToString() + chaine_base[1] + chaine_base[2];

                }
                else
                {
                    tb_pv.Text = "";
                }
                int test;
                if (int.TryParse(chaine_base[2], out test))
                {
                    if (pv < 0)
                    {
                        pv = 0;
                    }
                    while (pv > progressBar1.Maximum)
                    {
                        pv--;
                    }
                    progressBar1.Value = pv;
                    test = int.Parse(chaine_base[2]);
                    progressBar1.Maximum = test;
                    progressBar1.Minimum = 0;

                }
            }
            
            }
        

        private void bt_moins_Click(object sender, EventArgs e)
        {
            if (tb_pv.Text!=null&&tb_pv.Text!=""){
                String[] chaine_base = extraireChaine(tb_pv.Text);
                String chaine_pv = chaine_base[0];
                int pv;
                if (int.TryParse(chaine_pv, out pv))
                {
                    pv = int.Parse(chaine_pv);
                    pv += 1;
                    tb_pv.Text = pv.ToString() + chaine_base[1] + chaine_base[2];

                }
                else
                {
                    tb_pv.Text = "";
                }
                int test;
                if (int.TryParse(chaine_base[2],out test))
                {
                    if (pv < 0)
                    {
                        pv = 0;
                    }
                    while (pv > progressBar1.Maximum)
                    {
                        pv--;
                    }
                    progressBar1.Value = pv;
                    test=int.Parse(chaine_base[2]);
                    progressBar1.Maximum = test;
                    progressBar1.Minimum = 0;

                }
            }
        }
        public String[] extraireChaine(String chaine)
        {
            bool test = true;
            int i = 1;
            String[] retour = new String[3];
            char[] array=chaine.ToCharArray();
            Regex reg = new Regex("[0-9.-]");
            foreach (char match in array)
            {
            
                    if (!reg.IsMatch(match.ToString())||test==false)
                    {
                        test = false;
                        retour[2] += match.ToString();
                    }
                    else
                    {
                        retour[0] += match.ToString();
                    }
                
                
           }
            retour[1] = "/";
            if (retour[2] != null && retour[2] != "")
            {
               
                array = retour[2].ToCharArray();
                if (array.Length == 1)
                {
                    retour[2] = null;
                }
                else
                {
                    retour[2] = "";
                    while (i < array.Length)
                    {
                        retour[2] += array[i].ToString();
                        i++;
                    }
                }
            }
            return retour;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
