
using System.Configuration;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace Calculadora.Tests
{

    public class CalculadoraTests
    {

        [TestFixture]
        public class CalculadoraSimplesTests
        {
            [Test]
            public void DeveAdicionarDoisNumeros()
            {
                var sut = new CalculadoraSimples();
                var resultado = sut.Adicionar(5, 5);
                Assert.That(resultado, Is.EqualTo(10));

            }


            [Test]
            public void DeveMultiplicarDoisNumeros()
            {
                var sut = new CalculadoraSimples();
				
                var resultado = sut.Multiplicar(5, 3);
                
                Assert.That(resultado, Is.EqualTo(15));
            }
        }
    }
}
