using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portaria.VIEW
{
    public partial class frmADM : Form
    {
        public frmADM()
        {
            InitializeComponent();
        }

        private void ptbWindowClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ptbWindowMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ptbMaxRestore_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized) {
                this.StartPosition = FormStartPosition.CenterScreen;
                this.WindowState = FormWindowState.Normal;
                ptbMaxRestore.Image = Properties.Resources.window_maximize;
            }else 

            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                ptbMaxRestore.Image = Properties.Resources.window_restore;
            }
        }
    }
}
