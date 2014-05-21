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
    public partial class MainForm : Form
    {
        Interface formInterface;
        Module_des formModuleDes;
        PJs formPjs;
        MenuConfig formConfig;
        Module_pv formPV;
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnMusique_Click(object sender, EventArgs e)
        {
            if (formInterface == null)
            {
                formInterface = new Interface(this);
                formInterface.TopLevel = false;
                this.Controls.Add(formInterface);
                formInterface.Show();
                formInterface.BringToFront();
            }
            else
            {
                formInterface.WindowState = FormWindowState.Normal;
            }
        }

        private void btnDes_Click(object sender, EventArgs e)
        {
            if (formModuleDes == null)
            {
                formModuleDes = new Module_des();
                formModuleDes.TopLevel = false;
                this.Controls.Add(formModuleDes);
                formModuleDes.Show();
                formModuleDes.BringToFront();
            }
            else
            {
                formModuleDes.WindowState = FormWindowState.Normal;
            }
        }

        private void btnPJs_Click(object sender, EventArgs e)
        {
            if (formPjs == null)
            {
                formPjs = new PJs();
                formPjs.TopLevel = false;
                this.Controls.Add(formPjs);
                formPjs.Show();
                formPjs.BringToFront();
            }
            else
            {
                formPjs.WindowState = FormWindowState.Normal;
            }
        }

        internal void setCurrentWindow(string p, Musique[] playlist, bool configSuper)
        {
            if (formConfig == null)
            {
                this.formInterface.Close();
                this.formInterface = null;
                formConfig = new MenuConfig(playlist, configSuper, this);
                formConfig.TopLevel = false;
                this.Controls.Add(formConfig);
                formConfig.Show();
                formConfig.BringToFront();
            }
            else
            {
                formConfig.WindowState = FormWindowState.Normal;
            }
        }

        private void btGestionPV_Click(object sender, EventArgs e)
        {
            if (formPV == null)
            {
                formPV = new Module_pv();
                formPV.TopLevel = false;
                this.Controls.Add(formPV);
                formPV.Show();
                formPV.BringToFront();
            }
            else
            {
                formPV.WindowState = FormWindowState.Normal;
            }
        }

        internal void displayInterface()
        {
            if (formInterface == null)
            {
                this.formConfig.Close();
                this.formConfig = null;
                formInterface = new Interface(this);
                formInterface.TopLevel = false;
                this.Controls.Add(formInterface);
                formInterface.Show();
                formInterface.BringToFront();
            }
            else
            {
                formInterface.WindowState = FormWindowState.Normal;
            }
        }

        internal void retourConfig(string[,] tabTB, bool[] tabRepet, bool configSuper)
        {
            this.formInterface.retourConfig(tabTB, tabRepet, configSuper);
        }
    }
}
