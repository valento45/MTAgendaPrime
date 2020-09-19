using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncoesAuxiliares
{
    public static class ExtensionMethods
    {
        public static void SomenteNumeros(this string value)
        {
            value = value.Replace("-", "").Replace(".", "").Replace(",", "");
        }
    }
}
