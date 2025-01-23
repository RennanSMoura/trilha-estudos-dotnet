using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Unidade 3.TiposEspeciais.MetodoExtensao
{
    public static class IntExtensions
    {
        // Ao utilizar 
        public static bool EhPar(this int numero)
        {
            return numero % 2 == 0;
        }
    }
}