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
        public frmEspecialidades()
        {
            InitializeComponent();
        }

        private void lblCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
