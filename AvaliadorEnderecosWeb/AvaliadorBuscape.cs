using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliadorEnderecosWeb
{
    class AvaliadorBuscape : Avaliacao
    {
        private readonly String nome;

        public AvaliadorBuscape(String nome)
        {
            this.nome = nome;
        }

        public bool Avalia()
        {
            return nome == "buscape";
        }

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
