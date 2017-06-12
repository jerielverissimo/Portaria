using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Portaria.Model;
using System.Xml.Linq;
using System.IO;

namespace Portaria.DAL
{
    class ExternoDAL
    {

        private string xml_path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;

        public List<Externo> carregaExterno()
        {
            List<Externo> externos = new List<Externo>();

            var xDox = XDocument.Load(xml_path + @"\DB\Externos.xml");

            foreach (XElement xe in xDox.Descendants("externo"))
            {
                Externo externo = new Externo();

                //externo.Id_usuario = Convert.ToInt32(xe.Element("id_usuario").Value);
                externo.Cpf = xe.Element("cpf").Value;
                
                externos.Add(externo);
            }

            return externos;
        }

        public void salvar(string nome, string email, string tel, string data, string esp)
        {
            try
            {
                var xDoc = XDocument.Load(xml_path + @"\DB\Externos.xml");
                var count = xDoc.Descendants("externo").Count();
                var novoElemento = new XElement("especialidade",
                                   new XElement("id", count +1),
                                   //new XElement("id_usuario", cod),
                                   new XElement("nome", nome),
                                   new XElement("email", email),
                                   new XElement("telefone", tel),
                                   new XElement("data_criacao", data),
                                   new XElement("esp", esp));

                xDoc.Root.Add(novoElemento);
                xDoc.Save(xml_path + @"\DB\Externos.xml");
            }catch (FileNotFoundException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
