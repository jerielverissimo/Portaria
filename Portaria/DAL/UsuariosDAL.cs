using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Data;
using System.Xml.Linq;

namespace Portaria.DAL
{
    class UsuariosDAL
    {

        private string xml_path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;


        public DataTable dt = new DataTable(); // cria tabela de dados
        public DataSet ds = new DataSet();
        


        public DataTable carregaUsuarios()
        {
            try
            {

                ds.ReadXml(xml_path + @"\DAL\Usuarios.xml");
                dt = ds.Tables[("usuario")];
            }
            catch (FileNotFoundException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                dt = new DataTable("usuario");
                dt.Columns.Add("id");
                dt.Columns.Add("nome");
                dt.Columns.Add("email");
                dt.Columns.Add("tel");
                dt.Columns.Add("data_criacao");
                dt.Columns.Add("cod_esp");
            }
            return dt;
        }

        public void Salvar (string nome, string email, string tel, string data_criacao, int cod_esp)
        {
            try
            {
                
                var xDoc = XDocument.Load(xml_path + @"\DAL\Usuarios.xml"); 
                var count = xDoc.Descendants("usuario").Count();
                var novoUsuario = new XElement("usuario",
                                  new XElement("id", count + 1),
                                  new XElement("nome", nome),
                                  new XElement("email", email),
                                  new XElement("tel", tel),
                                  new XElement("data_criacao", data_criacao),
                                  new XElement("cod_esp", cod_esp));
                xDoc.Root.Add(novoUsuario);
                xDoc.Save(xml_path + @"\DAL\Usuarios.xml");
            } catch (FileNotFoundException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            
          
        }

    }
}
