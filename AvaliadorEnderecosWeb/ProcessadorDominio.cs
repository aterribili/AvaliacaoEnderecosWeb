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

        public String DescobreDominio()
        {
            if (new AvaliadorBuscape(nome).Avalia())
                return new AvaliadorBuscape(nome).Executa();
            if (new AvaliadorBondfaro(nome).Avalia())
                return new AvaliadorBondfaro(nome).Executa();
            if (new AvaliadorZmoveis(nome).Avalia())
                return new AvaliadorZmoveis(nome).Executa();
            else
                return "";
        }
    }
}
