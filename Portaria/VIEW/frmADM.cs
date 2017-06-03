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


        // OBJ

        PALETT.Colors color = new PALETT.Colors();

        // var 

        int window_X = 0, window_Y = 0;

        // methods

        #region Methods

        private void Maximiza_Restaura_Tela ()
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.StartPosition = FormStartPosition.CenterScreen;
                this.WindowState = FormWindowState.Normal;
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

        public frmADM()
        {
            InitializeComponent();
        }
        private void frmADM_Load(object sender, EventArgs e)
        {
            panTitleBar.BackColor = color.AzulTitleBar;
            panActionBar.BackColor = color.AzulActionBar;
            panSideBar.BackColor = color.AzulSideBar;
            lblAddEsp.BackColor = color.AzulBackground;
            lblCadUser.BackColor = color.AzulBackground;

            this.Opacity = 0.1;
            fadeInEffectADM.Enabled = true;
        }

        // Eventos

       #region Eventos


        private void ptbWindowClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ptbWindowMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            window_X = this.Left - MousePosition.X;
            window_Y = this.Top - MousePosition.Y;
        }

        private void panTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = window_X + MousePosition.X;
            this.Top = window_Y + MousePosition.Y;
        }

        private void panTitleBar_DoubleClick(object sender, EventArgs e)
        {
            Maximiza_Restaura_Tela();
        }

        private void fadeEffectADM_Tick(object sender, EventArgs e)
        {
            if (this.Opacity <= 1.0)
            {
                this.Opacity += 0.025;
            }else
            {
                fadeInEffectADM.Enabled = false;
            }
        }

        private void rdbTipoServ_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTipoServ.Checked)
            {
                lblSIAPE.Visible = true;
                mskSIAPE.Visible = true;
                ckbADM.Visible = true;
            } else
            {
                lblSIAPE.Visible = false;
                mskSIAPE.Visible = false;
               
            }
        }

        private void rdbTipoAlluno_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTipoAlluno.Checked)
            {
                lblProntUsr.Visible = true;
                mskProntAlun.Visible = true;
                ckbADM.Visible = true;
            }
            else
            {
                lblProntUsr.Visible = false;
                mskProntAlun.Visible = false;
                
            }
        }

        private void rdbTipoExt_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTipoExt.Checked)
            {
                ckbADM.Visible = false;
                lblProntUsr.Visible = false;
                mskProntAlun.Visible = false;
                lblSIAPE.Visible = false;
                mskSIAPE.Visible = false;
            }
        }

        private void ptbMaxRestore_Click(object sender, EventArgs e)
        {
            Maximiza_Restaura_Tela();
        }

       #endregion
    }
}
