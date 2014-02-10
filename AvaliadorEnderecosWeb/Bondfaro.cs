using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliadorEnderecosWeb
{
    class Bondfaro : Site
    {

        public string Dominio()
        {
            return "http://www.bondfaro.com.br";
        }

        public string Parametro()
        {
            return "a";
        }

        public string Cookie()
        {
            return "ba";
        }
    }
}
