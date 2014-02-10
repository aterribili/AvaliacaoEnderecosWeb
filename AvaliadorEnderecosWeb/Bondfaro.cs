using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliadorEnderecosWeb
{
    class Bondfaro : Avaliacao
    {

        public string DescobreDominio()
        {
            return "http://www.bondfaro.com.br";
        }

        public string DescobreParametro()
        {
            return "a";
        }

        public string DescobreCookie()
        {
            return "ba";
        }
    }
}
