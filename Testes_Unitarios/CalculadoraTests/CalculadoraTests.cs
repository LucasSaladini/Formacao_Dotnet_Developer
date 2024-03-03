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
}