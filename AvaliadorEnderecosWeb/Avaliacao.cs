using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliadorEnderecosWeb
{
    interface Avaliacao
    {
        bool Avalia();

        String DescobreDominio();

        String DescobreParametro();

        String DescobreCookie();
    }
}
