using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;
using Portaria.MODEL;

namespace Portaria.DAL
{
    class UsuarioGeneralizadoDAL
    {

        private string xml_path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;

        // Salvar Externo

        public void Salvar(string nome, string cpf, string email, string telefone, string data, string tipo, int cod, string esp)
        {

            try
            {

                var xDoc = XDocument.Load(xml_path + @"\DB\UsuariosGeneralizados.xml");
                var count = xDoc.Descendants("usuario").Count();
                var novoUsuario = new XElement("usuario",
                                  new XElement("id", count + 1),
                                  new XElement("nome", nome),
                                  new XElement("cpf", cpf),
                                  new XElement("email", email),
                                  new XElement("tel", telefone),
                                  new XElement("data_criacao", data),
                                  new XElement("tipo", tipo),
                                  new XElement("cod_esp", cod),
                                  new XElement("esp", esp),
                                  new XElement("prontuario"),
                                  new XElement("curso"),
                                  new XElement("siape"),
                                  new XElement("adm"),
                                  new XElement("senha"));
                
                xDoc.Root.Add(novoUsuario);
                xDoc.Save(xml_path + @"\DB\UsuariosGeneralizados.xml");
            }
            catch (FileNotFoundException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        // Salvar Aluno

        public void Salvar(string nome, string email, string telefone, string data, string pront, string curso)
        {

        }

        // Salvar Servidor

        public void Salvar(string nome, string email, string telefone, string data, int cod, string esp, string siape, string senha, string ADM)
        {

        }


        // Carregar Usuários

        public List <UsuarioGeneralizado> carregaUsuarios()
        {

            var xDoc = XDocument.Load(xml_path + @"\DB\UsuariosGeneralizados.xml");

            List <UsuarioGeneralizado> usuarios = new List<MODEL.UsuarioGeneralizado>();


            foreach (XElement xe in xDoc.Descendants("usuario"))
            {

                UsuarioGeneralizado usrGen = new UsuarioGeneralizado();

                //usrGen.Id = Convert.ToInt32(xe.Element("id").Value);
                usrGen.Nome = xe.Element("nome").Value;
                usrGen.Cpf = xe.Element("cpf").Value;
                usrGen.Email = xe.Element("email").Value;
                usrGen.Data_criacao = xe.Element("data_criacao").Value;
                usrGen.Cod_esp = Convert.ToInt32(xe.Element("cod_esp").Value);
                usrGen.Esp = xe.Element("esp").Value;
                usrGen.Tipo = xe.Element("tipo").Value;
                usrGen.Prontuario = xe.Element("prontuario").Value;
                usrGen.Curso = xe.Element("curso").Value;
                usrGen.Siape = xe.Element("siape").Value;
                usrGen.Adm = xe.Element("adm").Value;
                usrGen.Senha = xe.Element("senha").Value;

                usuarios.Add(usrGen);

            }

            return usuarios;
        }
    }
}
