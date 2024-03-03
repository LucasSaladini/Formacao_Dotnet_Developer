using Calculadora.Services;

namespace CalculadoraTests;

public class CalculadoraTests
{
    private CalculadoraImp _calc;
    public CalculadoraTests()
    {
        _calc = new CalculadoraImp();
    }

    [Fact]
    public void DeveSomar5Com10ERetornar15()
    {
        // Arrange
        int num1 = 5;
        int num2 = 10;

        // Act
        int result = _calc.Sum(num1, num2);

        // Assert
        Assert.Equal(15, result);
    }

    [Fact]
    public void DeveSomar10Com10ERetornar20()
    {
        // Arrange
        int num1 = 10;
        int num2 = 10;

        // Act
        int result = _calc.Sum(num1, num2);

        // Assert
        Assert.Equal(20, result);
    }

    [Fact]
    public void DeveVerificarSe4EParERetornarVerdadeiro()
    {
        // Arrange
        int number = 4;

        // Act
        bool result = _calc.EPar(number);

        // Assert
        Assert.True(result);
    }

    // 2, 4, 6, 8, 10
    [Theory]
    [InlineData(2)]
    [InlineData(4)]
    [InlineData(6)]
    [InlineData(8)]
    [InlineData(10)]
    public void DeveVerificarSeOsNumerosSaoParesERetornarVerdadeiro(int number)
    {
        // Arrange
        // Act
        bool result = _calc.EPar(number);
        // Assert
        Assert.True(result);
    }

    // Refact
    [Theory]
    [InlineData(new int[] { 2, 4 })]
    [InlineData(new int[] { 6, 8, 10 })]
    public void DeveVerificarSeOsNumerosSaoParesERetornarVerdadeiroRefact(int[] numbers)
    {
        // Arrange
        // Act / Assert
        Assert.All(numbers, num => Assert.True(_calc.EPar(num)));
    }
}