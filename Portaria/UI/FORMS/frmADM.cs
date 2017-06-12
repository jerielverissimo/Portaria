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
    public partial class frmADM : Form
    {


        // OBJ

        UI.PALETT.Colors color = new PALETT.Colors();
        
        Model.Usuario usrModel = new Model.Usuario();
        BLL.UsuariosBLL usrBLL = new BLL.UsuariosBLL();
        Notification notify = new Notification();


        // Var 

       

        int window_X = 0, window_Y = 0; // Variáveis usadas para mover form com o mouse
        double pan_X = 0;
        
        bool menuAberto = false, notifyAtivada = false; // variáveis para controle das animações

        // methods

        #region Methods

        private void Maximiza_Restaura_Tela ()
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.CenterToScreen();
                ptbMaxRestore.Image = Properties.Resources.window_maximize;
                if (menuAberto) tmSlideEfxMenu.Enabled = true;
                ptbSideMenu.Visible = false;
                lblTitleForm.Left = 23;

            }
            else

            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                
                ptbMaxRestore.Image = Properties.Resources.window_restore;
                ptbSideMenu.Visible = true;
                lblTitleForm.Left = 70;
            }
        }

        #endregion 

        public frmADM()
        {
            InitializeComponent();
        }

        private void frmADM_Load(object sender, EventArgs e)
        {

            DAL.ExternoDAL usrDal = new DAL.ExternoDAL();
            dgvMembros.DataSource = usrDal.carregaExterno(); 
            mskDataCria.Text = DateTime.Now.ToString();

            panTitleBar.BackColor = color.AzulTitleBar;
            panActionBar.BackColor = color.AzulActionBar;
            panSideBar.BackColor = color.AzulSideBar;
            lblAddEsp.BackColor = color.AzulBackground;
            lblCadUser.BackColor = color.AzulBackground;
            panNotify.BackColor = color.VerdeNotify;
            panPopPup.BackColor = color.AzulActionBar;

            panNotify.Left = (panUsers.Width / 2) - panNotify.Width;



            notify.PosPanNotify = panADM.ClientSize.Width / 2;
            notify.LargPanNotify = panADM.ClientSize.Width  * Notification.__PORCENEFX;
            notify.PosPanNotify = (panADM.ClientSize.Width / 2) * Notification.__PORCENEFX;

            //this.Opacity = 0.1;
           // fadeInEffectADM.Enabled = true;
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

       
        private void rdbTipoServ_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTipoServ.Checked)
            {
                lblSIAPE.Visible = true;
                mskSIAPE.Visible = true;
                lblSenhaADM.Visible = true;
                ckbADM.Visible = true;
                txtSenhaADM.Visible = true;
                lblEsp.Visible = true;
                cboxEsp.Visible = true;
                lblAddEsp.Visible = true;
            } else
            {
                lblSIAPE.Visible = false;
                mskSIAPE.Visible = false;
                lblSenhaADM.Visible = false;
                ckbADM.Visible = false;
                txtSenhaADM.Visible = false;
            }
        }

        private void rdbTipoAlluno_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTipoAluno.Checked)
            {
                lblProntUsr.Visible = true;
                mskProntAlun.Visible = true;
                ckbADM.Visible = false;
                txtSenhaADM.Visible = false;
                lblEsp.Visible = false;
                cboxEsp.Visible = false;
                lblAddEsp.Visible = false;
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
                ckbADM.Visible = false;
                txtSenhaADM.Visible = false;
                lblEsp.Visible = true;
                cboxEsp.Visible = true;
                lblAddEsp.Visible = true;
            }
        }

        private void ptbSideMenu_Click(object sender, EventArgs e)
        {
            tmSlideEfxMenu.Enabled = true;
        }

        private void tmSlideEfxMenu_Tick(object sender, EventArgs e)
        {
            switch (menuAberto)
            {
                case true:


                    panSideBar.Width -= 50;
                    lblUsuarios.Text = "";
                    lblAssociacoes.Text = "";
                    lblPortarias.Text = "";
                    lblVinculaMem.Text = "";

                    if (panSideBar.Width <= 75)
                    {
                        
                        menuAberto = false;
                        tmSlideEfxMenu.Enabled = false;
                    }

                    

                    break;
                case false:

                    panSideBar.Width += 50;

                    if (panSideBar.Width >= 250)
                    {
                        lblUsuarios.Text = "Usuários";
                        lblAssociacoes.Text = "Associações";
                        lblPortarias.Text = "Portarias";
                        lblVinculaMem.Text = "Membros";
                        menuAberto = true;
                        tmSlideEfxMenu.Enabled = false;
                    }

                    break;
            }
        }

        private void lblUsuarios_MouseEnter(object sender, EventArgs e)
        {
            lblUsuarios.BackColor = color.AzulSideBarHighlight;
        }

        private void lblUsuarios_MouseLeave(object sender, EventArgs e)
        {
            lblUsuarios.BackColor = color.AzulSideBar;
        }

        private void lblAssociacoes_MouseEnter(object sender, EventArgs e)
        {
            lblAssociacoes.BackColor = color.AzulSideBarHighlight;
        }

        private void lblAssociacoes_MouseLeave(object sender, EventArgs e)
        {
            lblAssociacoes.BackColor = color.AzulSideBar;
        }

        private void lblPortarias_MouseEnter(object sender, EventArgs e)
        {
            lblPortarias.BackColor = color.AzulSideBarHighlight;
        }

        private void lblPortarias_MouseLeave(object sender, EventArgs e)
        {
            lblPortarias.BackColor = color.AzulSideBar;
        }

        private void lblCadUser_Click(object sender, EventArgs e)
        {
            
            // Valida se os campos do aluno estão preenchidos
            if (rdbTipoAluno.Checked)
                usrBLL.validaFORM(txtNomeUsr.Text, mskEmail.Text,
                    mskTelUsr.Text, mskDataCria.Text, Convert.ToInt32(cboxEsp.SelectedValue), mskProntAlun.Text);

            // Valida se os campos do externo estão preenchidos
            if (rdbTipoExt.Checked)
            {
                usrBLL.validaFORM(txtNomeUsr.Text, mskEmail.Text, mskTelUsr.Text, mskDataCria.Text, cboxEsp.SelectedText);
                usrBLL.salvarUsuario(txtNomeUsr.Text, mskEmail.Text, mskTelUsr.Text, mskDataCria.Text, cboxEsp.Text);
            }

            // Valida se os campos do servidor estão preenchidos
            if (rdbTipoServ.Checked)
                usrBLL.validaFORM(txtNomeUsr.Text, mskEmail.Text,
                    mskTelUsr.Text, mskDataCria.Text, Convert.ToInt32(cboxEsp.SelectedValue), cboxEsp.Text, mskSIAPE.Text, txtSenhaADM.Text);


            // Se estvier válido os campos então ele salva
           // if (usrBLL.Valido)
               // usrBLL.salvarUsuario(txtNomeUsr.Text, mskEmail.Text, mskTelUsr.Text, mskDataCria.Text, Convert.ToInt32(cboxEsp.SelectedValue));

            // Exibe notificação com estado do cadastro
            tmBounceEfxNotify.Enabled = true;
            tmBounceEfxNotify.Tag = panADM;
        }

        private void frmADM_SizeChanged(object sender, EventArgs e)
        {
            notify.PosPanNotify = 0;
            notify.LargPanNotify = 0;
            notify.TamPanNotify = 0;
            notify.OrigemPanNotify = 0;

            panNotify.Left = (panADM.ClientSize.Width - panNotify.ClientSize.Width) / 2;
            notify.OrigemPanNotify = panADM.ClientSize.Width / 2;
            notify.LargPanNotify = panADM.ClientSize.Width * Notification.__PORCENEFX;
            notify.PosPanNotify = (panADM.ClientSize.Width / 2) * Notification.__PORCENEFX;

            if (notifyAtivada == true)
            {
               panNotify.Left = 0;
               panNotify.Width = panADM.ClientSize.Width;
            }
        }

        private void lblSession_Click(object sender, EventArgs e)
        {
            panPopPup.BringToFront();
            if (!panPopPup.Visible) panPopPup.Visible = true;
            else panPopPup.Visible = false;
        }

        private void panPopPup_MouseEnter(object sender, EventArgs e)
        {
            panPopPup.BackColor = color.AzulSideBar;
            lblSair.BackColor = color.AzulSideBar;
        }

        private void panPopPup_MouseLeave(object sender, EventArgs e)
        {
            panPopPup.BackColor = color.AzulActionBar;
            lblSair.BackColor = color.AzulActionBar;
        }

        private void panPopPup_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
            this.Close();
        }

        private void lblUsuarios_Click(object sender, EventArgs e)
        {
            lblTitleForm.Text = "Cadastro de Usuário";
            panUsers.BringToFront();
        }

        private void lblAssociacoes_Click(object sender, EventArgs e)
        {
            lblTitleForm.Text = "Cadastro de Associação";
            panAssociacao.BringToFront();
        }

        private void lblPortarias_Click(object sender, EventArgs e)
        {
            lblTitleForm.Text = "Cadastro de Portaria";
            panPortarias.BringToFront();
        }

        private void lblAddMem_Click(object sender, EventArgs e)
        {
            lblTitleForm.Text = "Vincular Membros";
            panVinculaMem.BringToFront();
            
        }

        private void lblCadAsso_Click(object sender, EventArgs e)
        {
           
           
        }

        private void lblAddMem_MouseEnter(object sender, EventArgs e)
        {
            lblVinculaMem.BackColor = color.AzulSideBarHighlight;
        }

        private void lblAddMem_MouseLeave(object sender, EventArgs e)
        {
            lblVinculaMem.BackColor = color.AzulSideBar;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblVincular_Click(object sender, EventArgs e)
        {

        }

        private void cboxEsp_Click(object sender, EventArgs e)
        {
            var especialidadeDAL = new DAL.EspecialidadeDAL();
            var especialidades = especialidadeDAL.todasEspecialidades();

            cboxEsp.DataSource = especialidades;
            cboxEsp.DisplayMember = "Nome";
            cboxEsp.ValueMember = "Cod";
        }

        private void lblAddEsp_Click(object sender, EventArgs e)
        {
            
            frmEspecialidades frm = new frmEspecialidades();

            frm.ShowDialog();
        }

        private void panUsers_SizeChanged(object sender, EventArgs e)
        {
            pan_X = panUsers.Width * 0.2;
        }

        private void lblCadUser_MouseEnter(object sender, EventArgs e)
        {
            lblCadUser.BackColor = color.AzulHighLight;
        }

        private void lblCadUser_MouseLeave(object sender, EventArgs e)
        {
            lblCadUser.BackColor = color.AzulBackground;
        }

        private void cboxEsp_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void lblAddMembros_Click(object sender, EventArgs e)
        {
            frmUsuarios frm = new frmUsuarios();
            frm.ShowDialog();
        }

        private void tmBounceEfxNotify_Tick(object sender, EventArgs e)
        {
            notify.setMessage(usrBLL.Msg, usrBLL.Valido,lblNotify,ptbNotify,panNotify);
            notify.elasticAnimation(panNotify, tmBounceEfxNotify);
        }

        private void ptbMaxRestore_Click(object sender, EventArgs e)
        {
            Maximiza_Restaura_Tela();
        }

       #endregion
    }
}
