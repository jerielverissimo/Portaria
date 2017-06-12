using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portaria.BLL
{
    class UsuariosBLL
    {

        Model.Usuario usrModel = new Model.Usuario();
        DAL.UsuariosDAL usrDAL = new DAL.UsuariosDAL();

        private bool valido;
        private string msg;

        public bool Valido { get => valido; set => valido = value; }
        public string Msg { get => msg; set => msg = value; }

        public void validaForm(string nome, string email, string tel, string data, int cod)
        {
            if (nome == "" || email == "" || tel == "" || data == "" || cod.Equals(null)) Valido = false;
            else Valido = true;

            if (valido)
            {
                Msg = "Usuário cadastrado com sucesso!";
            }
            else
            {
                Msg = "Preenche os campos corretamente!";
            }
        }

        public void salvarUsuario(string nome, string email, string tel, string data, int cod)
        {
            usrModel.Nome = nome;
            usrModel.Email = email;
            usrModel.Telefone = tel;
            usrModel.Data_criacao = data;
            usrModel.Cod_esp = Convert.ToInt32(cod);

           
            usrDAL.Salvar(usrModel.Nome, usrModel.Email, usrModel.Telefone, usrModel.Data_criacao, usrModel.Cod_esp);
            
        }

            
    }
}
