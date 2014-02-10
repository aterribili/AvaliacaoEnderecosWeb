using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliadorEnderecosWeb
{
    public class ProcessadorDominio
    {
        private readonly String nome;

        public ProcessadorDominio(String nome)
        {
            this.nome = nome;
        }

        public String ProcessarDominio()
        {
            if (nome == "buscape")
                return "http://www.buscape.com.br";
            if (nome == "bondfaro")
                return "http://www.bondfaro.com.br";
            if (nome == "zmoveis")
                return "http://www.zmoveis.com.cl";
            else
                return "";
        }
    }
}
