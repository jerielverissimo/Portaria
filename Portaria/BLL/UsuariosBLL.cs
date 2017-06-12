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
        DAL.ExternoDAL extDAL = new DAL.ExternoDAL();
        Model.Externo extMODEL = new Model.Externo();


        private bool valido;
        private string msg;
        

        public bool Valido { get => valido; set => valido = value; }
        public string Msg { get => msg; set => msg = value; }

        public void validaFORM(string nome, string email, string tel, string data, string esp)
        {

          
            if (nome == "" || email == "" || tel == "" || data == "") Valido = false;
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

        public void validaFORM(string nome, string email, string tel, string data, int cod, string prontuario)
        {


            if (nome == "" || email == "" || tel == "" || data == "" || cod.Equals(null) || prontuario == "") Valido = false;
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

        public void validaFORM(string nome, string email, string tel, string data, int cod, string esp, string siap, string senha)
        {


            if (nome == "" || email == "" || tel == "" || data == "" || cod.Equals(null) || esp == "" || siap == "" || senha == "") Valido = false;
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

        public void salvarUsuario(string nome, string email, string tel, string data, string esp)
        {
            extMODEL.Nome = nome;
            extMODEL.Email = email;
            extMODEL.Telefone = tel;
            extMODEL.Data_criacao = data;
            //extMODEL.Cod = Convert.ToInt32(cod);
            //extMODEL.Cod_esp = Convert.ToInt32(cod_esp);
            extMODEL.Esp = esp;
           
            extDAL.salvar(extMODEL.Nome, extMODEL.Email, extMODEL.Telefone, extMODEL.Data_criacao, extMODEL.Esp);
            
        }

        public void salvarUsuario(string nome, string email, string tel, string data, int cod, string prontuario)
        {
            usrModel.Nome = nome;
            usrModel.Email = email;
            usrModel.Telefone = tel;
            usrModel.Data_criacao = data;
            usrModel.Cod_esp = Convert.ToInt32(cod);


            usrDAL.Salvar(usrModel.Nome, usrModel.Email, usrModel.Telefone, usrModel.Data_criacao, usrModel.Cod_esp);

        }

        public void salvarUsuario(string nome, string email, string tel, string data, int cod, string esp, string siap, string senha)
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
