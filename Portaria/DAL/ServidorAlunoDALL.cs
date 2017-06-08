using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portaria.DAL
{
    class ServidorAlunoDALL : UsuarioDAL
    {
        private string senha, tipo, prontuario, siape;
        private int id_usuario;

        public string Senha
        {
            get
            {
                return senha;
            }

            set
            {
                senha = value;
            }
        }

        public string Tipo
        {
            get
            {
                return tipo;
            }

            set
            {
                tipo = value;
            }
        }

        public string Prontuario
        {
            get
            {
                return prontuario;
            }

            set
            {
                prontuario = value;
            }
        }

        public string Siape
        {
            get
            {
                return siape;
            }

            set
            {
                siape = value;
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
    }
}
