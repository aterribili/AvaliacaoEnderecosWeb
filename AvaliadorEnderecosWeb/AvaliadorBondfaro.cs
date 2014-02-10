using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliadorEnderecosWeb
{
    class AvaliadorBondfaro : Avaliacao
    {
        private readonly String nome;

        public AvaliadorBondfaro(String nome)
        {
            this.nome = nome;
        }

        public bool Avalia()
        {
            return nome == "bondfaro";
        }

        public string Executa()
        {
            return "http://www.bondfaro.com.br";
        }
    }
}
