using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desafio.Console.Services;
using Xunit;

namespace Desafio.Tests
{
    public class ValidacoesStringTests
    {
        private ValidacoesString _validacoes = new ValidacoesString();
        [Fact]
        public void DeveRetornar6QuantidadeCaracteresDaPalavraMatrix()
        {
            //Arrange
            var texto = "Matrix";
            var resultadoEsperado = 6;
            //Act
            var resultado = _validacoes.RetornarQuantidadeCaracteres(texto);
            //Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void DeveConterAPalavraQualquerNoTexto()
        {
            //Arrange
            var texto = "Esse é um texto qualquer";
            var textoProcurado = "qualquer";
            //Act
            var resultadoEsperado = _validacoes.ContemCaractere(texto, textoProcurado);
            //Assert
            Assert.True(resultadoEsperado);
        }

        [Fact]
        public void NaoDeveContarAPalavraTesteNoTexto()
        {
            // Arrange
            var texto = "Esse é um texto qualquer";
            var textoProcurado = "teste";
            // Act
            var resultado = _validacoes.ContemCaractere(texto, textoProcurado);
            // Assert
            Assert.False(resultado);
        }

        [Fact]
        public void TextoDeveTerminarComAPalavraProcurado()
        {
            // Arrange
            var texto = "Começo, meio e fim do texto procurado";
            var textoProcurado = "procurado";
            // Act
            var resultado = _validacoes.TextoTerminaCom(texto, textoProcurado);
            // Assert
            Assert.True(resultado);
        }
    }
}