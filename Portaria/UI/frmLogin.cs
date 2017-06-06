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
    public partial class frmLogin : Form
    {

        // Instâncias

        PALETT.Colors cor = new PALETT.Colors();

        // Var

        int window_X = 0, window_Y = 0; // variáveis para usar no arrastar form.
        bool loginAdm = true, loginMembros = true;



        public frmLogin()
        {
            InitializeComponent();
        }
                

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.BackColor = cor.AzulBackground;
            lblEntrarADM.BackColor = cor.AzulBackground;
            lblEntrarMembro.BackColor = cor.AzulBackground;

            mskSenha.UseSystemPasswordChar = true; // mascara a senha com pontos
            
            
        }

        #region Eventos

        private void pctCloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void ptbMember_MouseEnter(object sender, EventArgs e)
        {
            ptbMember.BackColor = cor.AzulHighLight;
        }

        private void ptbMember_MouseLeave(object sender, EventArgs e)
        {
            ptbMember.BackColor = cor.AzulBackground;
        }
        private void ptbMember_Click(object sender, EventArgs e)
        {
            panLoginMember.BringToFront();
            ptbADM.Visible = false;
            ptbVisitantes.Visible = false;
            lblADM.Visible = false;
            lblVisitantes.Visible = false;
            tmLoginMembro.Enabled = true;

        }

        private void ptbVisitantes_MouseEnter(object sender, EventArgs e)
        {
            ptbVisitantes.BackColor = cor.AzulHighLight;
        }

        private void ptbVisitantes_MouseLeave(object sender, EventArgs e)
        {
            ptbVisitantes.BackColor = cor.AzulBackground;
        }

        private void ptbADM_MouseEnter(object sender, EventArgs e)
        {
            ptbADM.BackColor = cor.AzulHighLight;
        }

        private void panLogin_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            window_X = this.Left - MousePosition.X;
            window_Y = this.Top - MousePosition.Y;
        }

        private void panLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = window_X + MousePosition.X;
            this.Top = window_Y + MousePosition.Y;
        }

        private void ptbADM_Click(object sender, EventArgs e)
        {
            panLoginADM.BringToFront();
            tmLoginADM.Enabled = true;
        }

        private void ptbVisitantes_Click(object sender, EventArgs e)
        {
            
            
            fadeOutEffect.Enabled = true;

            
        }

        private void tmLoginMembro_Tick(object sender, EventArgs e)
        {
            switch (loginMembros)
            {
                case true:

                    if (panLoginMember.Height < 250)
                    {
                        panLoginMember.Height += 25;

                        if (ptbMember.Top > 150) ptbMember.Top -= 25;
                        if (lblMembro.Top > 250) lblMembro.Top -= 25;

                        if (ptbMember.Left > 410) ptbMember.Left -= 20;
                        if (lblMembro.Left > 410) lblMembro.Left -= 20;

                    } else
                    {
                        tmLoginMembro.Enabled = false;
                        loginMembros = false;
                    }
                    break;
                case false:

                    if (panLoginMember.Height > 0)
                    {
                        panLoginMember.Height -= 25;

                        if (ptbMember.Top < 250) ptbMember.Top += 25;
                        if (lblMembro.Top < 350) lblMembro.Top += 25;

                        if (ptbMember.Left < 590) ptbMember.Left += 20;
                        if (lblMembro.Left < 588) lblMembro.Left += 20;

                    }
                    else
                    {
                        tmLoginMembro.Enabled = false;
                        loginMembros = true;

                        ptbADM.Visible = true;
                        ptbVisitantes.Visible = true;
                        lblADM.Visible = true;
                        lblVisitantes.Visible = true;
                    }
                    break;
            }
        }

        private void lblEntrarMembro_MouseEnter(object sender, EventArgs e)
        {
            lblEntrarMembro.BackColor = cor.AzulHighLight;
        }

        private void lblEntrarMembro_MouseLeave(object sender, EventArgs e)
        {
            lblEntrarMembro.BackColor = cor.AzulBackground;
        }

        private void lblEntrarADM_MouseEnter(object sender, EventArgs e)
        {
            lblEntrarADM.BackColor = cor.AzulHighLight;
        }

        private void lblEntrarADM_MouseLeave(object sender, EventArgs e)
        {
            lblEntrarADM.BackColor = cor.AzulBackground;
        }

        private void lblEntrarADM_Click(object sender, EventArgs e)
        {
            frmADM frm = new frmADM();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.WindowState = FormWindowState.Maximized;
            this.Hide();
            frm.ShowDialog();
            this.Close();

        }

        private void lblEntrarMembro_Click(object sender, EventArgs e)
        {
           
        }

        private void fadeOutEffect_Tick(object sender, EventArgs e)
        {
            if (this.Opacity >= 0.1) this.Opacity -= 0.025;
            else {
                frmVisitantes frm = new frmVisitantes();
                frm.StartPosition = FormStartPosition.CenterScreen;
                fadeOutEffect.Enabled = false;
                this.Hide();
                frm.ShowDialog();
                this.Close();
            }
        }

        private void tmLoginADM_Tick(object sender, EventArgs e)
        {
            switch (loginAdm)
            {
                case true:

                    ptbMember.Visible = false;
                    ptbVisitantes.Visible = false;
                    lblMembro.Visible = false;
                    lblVisitantes.Visible = false;

                    if (panLoginADM.Height < 250)
                    {
                        panLoginADM.Height += 25;
                        if (ptbADM.Top > 150)
                            ptbADM.Top -= 25;

                        if (lblADM.Top > 250)
                            lblADM.Top -= 25;

                        
                        
                    } else
                    {
                        loginAdm = false;
                        tmLoginADM.Enabled = false;
                    }
                    break;
                case false:
                    if (panLoginADM.Height > 0)
                    {
                        panLoginADM.Height -= 25;
                        if (ptbADM.Top < 250)
                            ptbADM.Top += 25;

                        if (lblADM.Top < 350)
                            lblADM.Top += 25;

                       
                    }
                    else
                    {
                        loginAdm = true;
                        tmLoginADM.Enabled = false;
                        ptbMember.Visible = true;
                        ptbVisitantes.Visible = true;
                        lblMembro.Visible = true;
                        lblVisitantes.Visible = true;
                    }
                    break;
            }
        }

      
        private void ptbADM_MouseLeave(object sender, EventArgs e)
        {
            ptbADM.BackColor = cor.AzulBackground;
        }



        #endregion


    }
}
