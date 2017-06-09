using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portaria.UI.FORMS
{
    public partial class frmVisitantes : Form
    {
        
        public frmVisitantes()
        {
            InitializeComponent();
            panAssociaçoes.Visible = false;
            panMembros.Visible = false;
            panPortarias.Visible = false;
        }
       
        #region Methods

        private void Maximiza_Restaura_Tela()
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.CenterToScreen();
                ptbMaxRestore.Image = Properties.Resources.window_maximize;
                

            }
            else

            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;

                ptbMaxRestore.Image = Properties.Resources.window_restore;
                
            }
        }

        #endregion

  

        private void pctCloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblAssociações_Click(object sender, EventArgs e)
        {
            panAssociaçoes.Visible = true;
            panAssociaçoes.BringToFront();
        }

        private void lblMembros_Click(object sender, EventArgs e)
        {
            panMembros.Visible = true;
            panMembros.BringToFront();
        }

        private void ptbMaxRestore_Click(object sender, EventArgs e)
        {
            Maximiza_Restaura_Tela();
        }

        private void ptbWindowMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblPortarias_Click(object sender, EventArgs e)
        {
            panPortarias.Visible = true;
            panPortarias.BringToFront();
        }
    }
}
