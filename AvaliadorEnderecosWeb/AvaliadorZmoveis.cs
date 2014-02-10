using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliadorEnderecosWeb
{
    class AvaliadorZmoveis : Avaliacao
    {
        private readonly String nome;

        public AvaliadorZmoveis(String nome)
        {
            this.nome = nome;
        }

        public bool Avalia()
        {
            return nome == "zmoveis";
        }

        public string DescobreDominio()
        {
            return "http://www.zmoveis.com.cl";
        }


        public string DescobreParametro()
        {
            return "i";
        }

        public string DescobreCookie()
        {
            return "zi";
        }
    }
}
