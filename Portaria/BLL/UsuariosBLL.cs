using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portaria.BLL
{
    class UsuariosBLL
    {

        #region OBJ


        MODEL.Usuario usrModel = new MODEL.Usuario();
        MODEL.UsuarioGeneralizado usrGenMODEL = new MODEL.UsuarioGeneralizado();
        MODEL.Externo extMODEL = new MODEL.Externo();
        MODEL.ServidorAluno srvAln = new MODEL.ServidorAluno();
        DAL.UsuariosDAL usrDAL = new DAL.UsuariosDAL();
        DAL.ExternoDAL extDAL = new DAL.ExternoDAL();
        DAL.AlunoDAL alnDAL = new DAL.AlunoDAL();
        DAL.UsuarioGeneralizadoDAL usrGenDAL = new DAL.UsuarioGeneralizadoDAL();

        #endregion



        #region VAR

        private bool valido;
        private string msg;

        #endregion


        #region PROPRITIES

        public bool Valido { get => valido; set => valido = value; }
        public string Msg { get => msg; set => msg = value; }

        #endregion


        // Valida Externo

        public void ValidaFORM(string nome, string cpf, string email, string tel, string data, string tipo, int cod, string esp)
        {

          
            if (nome == "" || email == "" || tel == "" || data == "" || esp == "") Valido = false;
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

        // Valida Aluno

        public void ValidaFORM(string nome, string email, string tel, string data, string tipo, string prontuario, string curso)
        {


            if (nome == "" || email == "" || tel == "" || data == "" || prontuario == "" || curso == "") Valido = false;
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

        // Valida Servidor

        public void ValidaFORM(string nome, string email, string tel, string data, string tipo, int cod, string esp, string siap, string senha, string adm)
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


        // Salva Externo

        public void SalvarUsuario(string nome, string cpf, string email, string tel, string data, string tipo, int cod, string esp)
        {
            usrGenMODEL.Nome = nome;
            usrGenMODEL.Cpf = cpf;
            usrGenMODEL.Email = email;
            usrGenMODEL.Telefone = tel;
            usrGenMODEL.Data_criacao = data;
            usrGenMODEL.Tipo = tipo;
            usrGenMODEL.Cod_esp = cod;
            usrGenMODEL.Esp = esp;
           
            usrGenDAL.Salvar(usrGenMODEL.Nome, usrGenMODEL.Cpf, usrGenMODEL.Email, usrGenMODEL.Telefone,
                             usrGenMODEL.Data_criacao, usrGenMODEL.Tipo, usrGenMODEL.Cod_esp, usrGenMODEL.Esp);
            
        }

        // Salva Aluno

        public void SalvarUsuario(string nome, string email, string tel, string data, string prontuario, string curso)
        {
            usrGenMODEL.Nome = nome;
            usrGenMODEL.Email = email;
            usrGenMODEL.Telefone = tel;
            usrGenMODEL.Data_criacao = data;
            usrGenMODEL.Prontuario = prontuario;
            usrGenMODEL.Curso = curso;


            usrGenDAL.Salvar(usrModel.Nome, usrModel.Email, usrModel.Telefone, usrModel.Data_criacao, usrGenMODEL.Prontuario, usrGenMODEL.Curso);

        }

        // Salva Servidor

        public void SalvarUsuario(string nome, string email, string tel, string data, int cod, string esp, string siap, string senha, string adm)
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
