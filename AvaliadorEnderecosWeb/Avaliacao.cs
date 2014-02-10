using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliadorEnderecosWeb
{
    public interface Avaliacao
    {
        String DescobreDominio();

        String DescobreParametro();

        String DescobreCookie();
    }
}
