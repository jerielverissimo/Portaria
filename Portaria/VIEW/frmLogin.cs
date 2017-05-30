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
        bool loginAdm = true, loginVisitantes = true, loginMembros = true;



        public frmLogin()
        {
            InitializeComponent();
        }
                

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.BackColor = cor.AzulBackground;
            lblEntrar.BackColor = cor.AzulBackground;

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
            tmLoginADM.Enabled = true;
        }

        private void ptbVisitantes_Click(object sender, EventArgs e)
        {
            
            FormPrincipal form1 = new FormPrincipal();
            form1.ShowDialog();
            
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

        private void tmLoginVisitantes_Tick(object sender, EventArgs e)
        {
            switch (loginVisitantes)
            {
                case true:

                    ptbMember.Visible = false;
                    ptbADM.Visible = false;
                    lblMembro.Visible = false;
                    lblADM.Visible = false;

                    if (panLoginVisitantes.Height < 250)
                    {
                        panLoginVisitantes.Height += 25;
                        if (ptbVisitantes.Top > 150)
                            ptbVisitantes.Top -= 25;

                        if (lblVisitantes.Top > 250)
                            lblVisitantes.Top -= 25;



                    }
                    else
                    {
                        loginVisitantes = false;
                        tmLoginVisitantes.Enabled = false;
                    }
                    break;
                case false:
                    if (panLoginVisitantes.Height > 0)
                    {
                        panLoginVisitantes.Height -= 25;
                        if (ptbVisitantes.Top < 250)
                            ptbVisitantes.Top += 25;

                        if (lblVisitantes.Top < 350)
                            lblVisitantes.Top += 25;


                    }
                    else
                    {
                        loginVisitantes = true;
                        tmLoginVisitantes.Enabled = false;


                        ptbMember.Visible = true;
                        ptbADM.Visible = true;
                        lblMembro.Visible = true;
                        lblADM.Visible = true;
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
