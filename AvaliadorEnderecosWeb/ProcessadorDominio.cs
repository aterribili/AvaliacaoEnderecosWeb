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

        public Avaliacao AvaliaDominio()
        {
            if (nome == "buscape")
                return new Buscape();
            if (nome == "bondfaro")
                return new Bondfaro();
            if (nome == "zmoveis")
                return new Zmoveis();
            throw new Exception("Nao foram encontrados registros.");
        }
    }
}
