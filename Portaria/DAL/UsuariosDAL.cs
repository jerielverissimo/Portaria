using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portaria.DAL
{
    class UsuarioDAL
    {
        private int id, cod_esp;
        private string nome, email, telefone;
        private string data_criacao;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        
        public int Cod_esp { get => cod_esp; set => cod_esp = value; }
        public string Data_criacao { get => data_criacao; set => data_criacao = value; }
    }
}
