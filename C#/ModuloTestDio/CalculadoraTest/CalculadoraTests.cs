using Calculadora.services;

namespace CalculadoraTest;

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
    int result = _calc.Somar(num1, num2);

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
    int result = _calc.Somar(num1, num2);

    // Assert
    Assert.Equal(20, result);
  }
  [Fact]
  public void DeveVerificarSe4EhParERetornarVerdadeiro()
  {
    // Arrange
    int numero = 4;

    // Act
    bool resultado = _calc.EhPar(numero);

    // Assert
    Assert.True(resultado);
  }
}