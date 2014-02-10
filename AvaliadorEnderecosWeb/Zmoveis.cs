using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliadorEnderecosWeb
{
    class Zmoveis : Site
    {
        public string Dominio()
        {
            return "http://www.zmoveis.com.cl";
        }

        public string Parametro()
        {
            return "i";
        }

        public string Cookie()
        {
            return "zi";
        }
    }
}
