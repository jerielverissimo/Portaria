using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portaria.Model
{
    class Especialidade
    {
        private int cod;
        private string nome;

        public int Cod
        {
            get
            {
                return cod;
            }

            set
            {
                cod = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }
    }
}
