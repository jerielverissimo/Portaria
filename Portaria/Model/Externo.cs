using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portaria.MODEL
{
    class Externo : Usuario
    {
        private string cpf;
        private int id_usuario;
        //private string esp;

        public string Cpf
        {
            get
            {
                return cpf;
            }

            set
            {
                cpf = value;
            }
        }

        public int Id_usuario
        {
            get
            {
                return id_usuario;
            }

            set
            {
                id_usuario = value;
            }
        }

       // public string Esp { get => esp; set => esp = value; }
    }
}
