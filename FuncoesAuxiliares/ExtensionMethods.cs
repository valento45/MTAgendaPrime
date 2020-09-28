using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncoesAuxiliares
{
    public static class ExtensionMethods
    {
        public static string SomenteNumeros(this string value)
        {
            if (value == null || value == "")
                return value;

            string result = "";
            try
            {
                foreach (char c in value)
                    if (char.IsNumber(c))
                        result += c;
            }
            catch { }
            return result;

        }


        
    }
}
