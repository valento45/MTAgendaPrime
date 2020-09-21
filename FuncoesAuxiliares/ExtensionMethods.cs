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
            for(int i = 0; i < value.Length; i++)
            {
                if (!(Char.IsNumber(value[i])))
                    value = value.Replace(value[i].ToString(), " ");
            }
            value = value.Replace(" ", "").Trim();
        }


        
    }
}
