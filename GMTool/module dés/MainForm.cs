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
                formConfig = new MenuConfig(playlist, configSuper);
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
    }
}
