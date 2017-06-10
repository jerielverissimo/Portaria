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
            // Model.Especialidade espMODEL = new Model.Especialidade();
            // DAL.EspecialidadeDAL espDAL = new DAL.EspecialidadeDAL();

            //espMODEL.Nome = txtNome.Text;
            //espDAL.Salvar(espMODEL.Nome);
            //txtNome.Text = null;

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
            BLL.EspecialidadesBLL espBLL = new BLL.EspecialidadesBLL();

            espBLL.validaForm(txtNome);
            notify.setMessage(espBLL.Msg, espBLL.Validado, lblNotify, ptbNotify, panNotify);
            notify.elasticAnimation(panNotify, tmNotify);
        }
    }
}
