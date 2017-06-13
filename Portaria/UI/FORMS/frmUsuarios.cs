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
    public partial class frmUsuarios : Form
    {

        DAL.ExternoDAL extDAL = new DAL.ExternoDAL();
        DAL.UsuarioGeneralizadoDAL usrGen = new DAL.UsuarioGeneralizadoDAL();

        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void lblCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = usrGen.carregaUsuarios();
        }

        private void rdbExteron_CheckedChanged(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = usrGen.carregaUsuarios();
        }
    }
}
