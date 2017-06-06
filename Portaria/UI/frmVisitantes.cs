using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portaria
{
    public partial class frmVisitantes : Form
    {
        public frmVisitantes()
        {
            InitializeComponent();
        }

        private void pctCloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
