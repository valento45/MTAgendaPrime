using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuncoesAuxiliares
{
    public static class FuncoesAuxiliares
    {
        public static bool ValidaCPF(string cpf)
        {
            if (cpf.Length < 11)
            {
                MessageBox.Show("Obrigatório 11 digítos para o CPF !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            //declaração das variáveis 
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;

            //calculo dos numeros usando variavel multiplicador 1 e 2
            tempCpf = cpf.Substring(0, 9);
            soma = 0;
            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = resto.ToString();
            tempCpf = tempCpf + digito;

            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }
        /// <summary>
        /// Verifica em uma cadeia de string se tem caracteres numerais.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool VerificaSeTemNumero(string value)
        {
            bool capturou = false;

            if (value == null || value == string.Empty)
                return capturou;

            else
                for (int i = 0; i < value.Length; i++)
                    if (char.IsNumber(value[i]))
                        capturou = true;
            return capturou;
        }
    }
}
