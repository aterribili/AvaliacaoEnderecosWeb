using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliadorEnderecosWeb
{
    class Buscape : Site
    {

        public string Dominio()
        {
            return "http://www.buscape.com.br";
        }

        public string Parametro()
        {
            return "p";
        }

        public string Cookie()
        {
            return "bp";
        }
    }
}
