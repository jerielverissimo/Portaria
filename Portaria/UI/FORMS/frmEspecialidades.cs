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
    public partial class frmEspecialidades : Form
    {

        Notification notify = new Notification();
        BLL.EspecialidadesBLL espBLL = new BLL.EspecialidadesBLL();
        MODEL.Especialidade espMODEL = new MODEL.Especialidade();


        public frmEspecialidades()
        {
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        private void lblCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblCadastrar_Click(object sender, EventArgs e)
        {

            espMODEL.Esp = txtNome.Text;
            espBLL.validaForm(espMODEL.Esp);
            txtNome.Text = null;
            espBLL.salvarEspecialidade(espMODEL.Esp);
            tmNotify.Tag = panCenter;
            tmNotify.Enabled = true;
            
        }

        private void frmEspecialidades_Load(object sender, EventArgs e)
        {
            panNotify.Left = this.Width / 2 - panNotify.Width;

            panNotify.Left = (panCenter.ClientSize.Width - panNotify.ClientSize.Width) / 2;
            notify.OrigemPanNotify = panCenter.ClientSize.Width / 2;
            notify.LargPanNotify = panCenter.ClientSize.Width * Notification.__PORCENEFX;
            notify.PosPanNotify = (panCenter.ClientSize.Width / 2) * Notification.__PORCENEFX;
        }

        private void tmNotify_Tick(object sender, EventArgs e)
        {

            espBLL.validaForm(espMODEL.Esp);
            notify.setMessage(espBLL.Msg, espBLL.Validado, lblNotify, ptbNotify, panNotify);
            notify.elasticAnimation(panNotify, tmNotify);
        }
    }
}
