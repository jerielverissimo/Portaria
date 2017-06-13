using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portaria.MODEL
{
    class Usuario : Especialidade
    {
        private int id, cod_esp;
        private string nome, email, telefone;
        private string data_criacao;

        public int Cod_esp
        {
            get
            {
                return cod_esp;
            }

            set
            {
                cod_esp = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Telefone
        {
            get
            {
                return telefone;
            }

            set
            {
                telefone = value;
            }
        }

        public string Data_criacao
        {
            get
            {
                return data_criacao;
            }

            set
            {
                data_criacao = value;
            }
        }

        private void pegaEspecialidade()
        {
            cod_esp = this.Cod;
        }
    }
}
