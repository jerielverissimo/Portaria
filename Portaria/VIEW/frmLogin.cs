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

        bool login = true;
        



        public frmLogin()
        {
            InitializeComponent();
        }
                

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.BackColor = cor.AzulBackground;
            lblEntrarMembro.BackColor = cor.AzulBackground;
            
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

        private void TmLoginMembro_Tick(object sender, EventArgs e)
        {
            switch (login)
            {
                case true:
                    lblMembro.Text = ptbMember.Top.ToString();

                    if (ptbMember.Top <= 118)
                    {
                        TmLoginMembro.Enabled = false;
                        login = false;
                    } else
                    {
                        ptbMember.Top -= 2;

                    }

                    if (panLoginMember.Width >= 250) {
                        
                    }
                    else
                    {
                        panLoginMember.Width += 25;

                    }
                    break;
                case false:

                    if (ptbMember.Top >= 155)
                    {
                        TmLoginMembro.Enabled = false;
                        login = true;
                    }
                    else
                    {
                        ptbMember.Top += 2;

                    }
                    if (panLoginMember.Width <= 0)
                    {
                        
                    }
                    else
                    {
                        panLoginMember.Width -= 25;

                    }
                    break;
            }
        }

        private void TmLoginVisitantes_Tick(object sender, EventArgs e)
        {
            switch (login)
            {
                case true:


                    if (ptbVisitantes.Left == 350)
                    {
                        TmLoginVisitantes.Enabled = false;
                        login = false;
                    }
                    else
                    {
                        ptbVisitantes.Left += 25;

                    }
                    break;
                case false:
                    if (panLoginMember.Width <= 0)
                    {
                        TmLoginVisitantes.Enabled = false;
                        login = true;
                    }
                    else
                    {
                        panLoginMember.Width -= 25;

                    }
                    break;
            }
        }

        #endregion

        private void ptbMember_Click(object sender, EventArgs e)
        {
            if (login)
            {
                ptbADM.Visible = false;
                ptbVisitantes.Visible = false;
                lblADM.Visible = false;
                lblVisitantes.Visible = false;
                lblLogin.Visible = false;
                TmLoginMembro.Enabled = true;
            } else
            {
                TmLoginMembro.Enabled = true;
                lblLogin.Visible = true;
                ptbADM.Visible = true;
                ptbVisitantes.Visible = true;
                lblADM.Visible = true;
                lblVisitantes.Visible = true;

            }
            
        }



        private void ptbVisitantes_Click(object sender, EventArgs e)
        {

        }

        
    }
}
