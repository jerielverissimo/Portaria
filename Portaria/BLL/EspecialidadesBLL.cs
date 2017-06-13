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
        DAL.EspecialidadeDAL espDAL = new DAL.EspecialidadeDAL();


        private bool validado;
        private string msg;

        public bool Validado { get => validado; set => validado = value; }
        public string Msg { get => msg; set => msg = value; }

        public string validaForm(String str)
        {

            MODEL.Especialidade espMODEL = new MODEL.Especialidade();

            if (str == "")
            {
                Validado = false;

                msg = "Preenche o campo corretamente!";
            } else
            {
                Validado = true;
                
                msg = "Especialidade cadastrada com sucesso!";
            }
            return str;
        }

        public void salvarEspecialidade(string str)
        {
            if (validado) espDAL.Salvar(str);
        }
    }
}
