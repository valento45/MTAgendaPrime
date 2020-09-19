using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;
using NUnit;
using NUnit.Framework;

namespace AgendaTDD
{
    [TestFixture]
    public class ClienteTDD
    {
        string value;
        
       //SetUp defina o local onde será executado antes do teste propriamente.
       //Muito útil para organizar dados necessários
       [SetUp]
        public void SetUp()
        {
             value = "123";            
        }

        [Test]
        public void VerificaSeTemNumeros()
        {
            bool capturou = false;
            for (int i = 0; i < value.Length; i++)
                if (char.IsNumber(value[i]))
                    capturou = true;


            Assert.IsTrue(capturou);
        }



    }
}
