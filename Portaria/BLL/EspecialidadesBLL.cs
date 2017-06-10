using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portaria.BLL
{
    class EspecialidadesBLL 
    {
        private bool validado;
        private string msg;

        public bool Validado { get => validado; set => validado = value; }
        public string Msg { get => msg; set => msg = value; }

        public void validaForm(TextBox txt)
        {
            if (txt.Text == "")
            {
                Validado = false;

                msg = "Preenche o campo corretamente!";
            } else
            {
                Validado = true;

                msg = "Especialidade cadastrada com sucesso!";
            }
        }
    }
}
