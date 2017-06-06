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

        public string Senha { get => senha; set => senha = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Prontuario { get => prontuario; set => prontuario = value; }
        public string Siape { get => siape; set => siape = value; }
        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
    }
}
