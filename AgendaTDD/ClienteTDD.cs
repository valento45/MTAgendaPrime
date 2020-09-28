using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;
using NUnit;
using NUnit.Framework;
using System.Windows.Forms;

namespace AgendaTDD
{
    [TestFixture]
    public class ClienteTDD
    {

        //   string value;

        //SetUp defina o local onde será executado antes do teste propriamente.
        //Muito útil para organizar dados necessários
        [SetUp]
        public void SetUp()
        {
            // value = "123";           [

        }

        [Test]
        [TestCase("123", true)]
        [TestCase("absd1cdsdddddddddsa", true)]
        [TestCase("abdasdas", false)]
        [TestCase("", false)]
        [TestCase(null, false)]        
        public void VerificaSeTemNumeros(string value, bool esperadoValue)
        {
            bool capturou = false;
            if (value == null || value == string.Empty)
                capturou = false;

            else
                for (int i = 0; i < value.Length; i++)
                    if (char.IsNumber(value[i]))
                    {
                        capturou = true;
                        break;
                    }

            Assert.IsTrue(capturou == esperadoValue);
        }

        [Test]
        [TestCase("abcdefghijklmnoprstuvwxyz123456", "123456")]
        [TestCase("#3!###################################################!tuvwxyz123456", "3123456")]
        [TestCase("#1#######!tuvwxyz123456", "1123456")]
        [TestCase("#1## ,.xz###  ,.;/'##!t         uvwxyz123456", "1123456")]
        public void SomenteNumeros(string value, string expectedValue)
        {
            string result = "";
            try
            {
                foreach (char c in value)
                    if (char.IsNumber(c))
                        result += c;
            }
            catch { }
            
            Assert.IsTrue(result == expectedValue);
        }


        [Test]
        [TestCase("000,000,000-00")]
        public void DefineMaskTextBox(string mask)
        {
            MaskedTextBox txtMask = new MaskedTextBox();
            txtMask.Mask = mask;

            Assert.IsTrue(txtMask.Mask == mask);
        }

        //[Test]
        //[TestCase("41980759804", true)]
        //[TestCase("12346578996", false)]
        //[TestCase("1423", false)]
        //[TestCase(null, false)]
        //public void TesteValidaCpf(string cpf, bool resultExpected)
        //{
        //    bool resultObtained = false;
        //    if (cpf == null || cpf.Length < 11)
        //    {
        //        return;
        //    }
        //    //declaração das variáveis 
        //    int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
        //    int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
        //    string tempCpf;
        //    string digito;
        //    int soma;
        //    int resto;

        //    //calculo dos numeros usando variavel multiplicador 1 e 2
        //    tempCpf = cpf.Substring(0, 9);
        //    soma = 0;
        //    for (int i = 0; i < 9; i++)
        //        soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

        //    resto = soma % 11;
        //    if (resto < 2)
        //        resto = 0;
        //    else
        //        resto = 11 - resto;

        //    digito = resto.ToString();
        //    tempCpf = tempCpf + digito;

        //    soma = 0;
        //    for (int i = 0; i < 10; i++)
        //        soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

        //    resto = soma % 11;
        //    if (resto < 2)
        //        resto = 0;
        //    else
        //        resto = 11 - resto;

        //    digito = digito + resto.ToString();

            
        //    resultObtained = cpf.EndsWith(digito);            
        //    Assert.IsTrue(resultExpected == resultObtained);
        //}


       
    }
}
