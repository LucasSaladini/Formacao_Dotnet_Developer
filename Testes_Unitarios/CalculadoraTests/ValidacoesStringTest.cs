using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculadora.Services;

namespace CalculadoraTests
{
    public class ValidacoesStringTest
    {
        private ValidacoesString _validacoes;
        public ValidacoesStringTest()
        {
            _validacoes = new ValidacoesString();
        }

        [Fact]
        public void DeveContar3CaracteresemOlaERetornar3()
        {
            // Arrange
            string text = "Ola";
            // Act
            int result = _validacoes.ContarCaracteres(text);
            // Assert
            Assert.Equal(3, result);
        }
    }
}