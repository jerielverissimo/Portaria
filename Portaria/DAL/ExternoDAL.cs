using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portaria.DAL
{
    class ExternoDAL : UsuarioDAL
    {
        private string cpf;
        private int id_usuario;

       
        public string Cpf { get => cpf; set => cpf = value; }
        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
    }
}
