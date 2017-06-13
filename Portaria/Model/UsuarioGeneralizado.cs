using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portaria.MODEL
{
    class UsuarioGeneralizado
    {

        private int id, cod_esp;
        private string nome, email, telefone;
        private string data_criacao;
        private string cpf;
        private string esp;
        private string senha, tipo, prontuario, siape, curso, adm;

        public int Id { get => id; set => id = value; }
        public int Cod_esp { get => cod_esp; set => cod_esp = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Data_criacao { get => data_criacao; set => data_criacao = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Esp { get => esp; set => esp = value; }
        public string Senha { get => senha; set => senha = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Prontuario { get => prontuario; set => prontuario = value; }
        public string Siape { get => siape; set => siape = value; }
        public string Curso { get => curso; set => curso = value; }
        public string Adm { get => adm; set => adm = value; }
    }
}
