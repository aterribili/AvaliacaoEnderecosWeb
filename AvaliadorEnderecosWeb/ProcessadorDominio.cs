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
            List<Avaliacao> listaAvaliadores = new List<Avaliacao>();
            listaAvaliadores.Add(new AvaliadorBuscape(nome));
            listaAvaliadores.Add(new AvaliadorBondfaro(nome));
            listaAvaliadores.Add(new AvaliadorZmoveis(nome));

            for (int i = 0; i < listaAvaliadores.Count; i++)
            {
                if (listaAvaliadores[i].Avalia())
                    return listaAvaliadores[i].Executa();
            }

            return "";
        }
    }
}
