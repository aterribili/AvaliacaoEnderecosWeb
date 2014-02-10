using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliadorEnderecosWeb
{
    public class ProcessadorSite
    {
        private readonly String site;

        public ProcessadorSite(String site)
        {
            this.site = site;
        }

        public Site AvaliaDominio()
        {
            if (site == "buscape")
                return new Buscape();
            if (site == "bondfaro")
                return new Bondfaro();
            if (site == "zmoveis")
                return new Zmoveis();
            throw new Exception("Nao foram encontrados registros.");
        }
    }
}
