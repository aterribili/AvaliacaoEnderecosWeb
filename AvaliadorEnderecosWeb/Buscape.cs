using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliadorEnderecosWeb
{
    class Buscape : Avaliacao
    {

        public string DescobreDominio()
        {
            return "http://www.buscape.com.br";
        }

        public string DescobreParametro()
        {
            return "p";
        }

        public string DescobreCookie()
        {
            return "bp";
        }
    }
}
