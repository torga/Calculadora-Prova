namespace CalculatorService.Tests;

public class UnitTest1
{
    private readonly CalculadoraService calc = new CalculadoraService();


    [Fact]
    public void TestarDivisaoComNaN()
    {
        // Arrange
        double a = 2.0;
        double b = double.NaN;

        // Act
        double resultado = calc.Divisao(a, b);

        // Assert
        Assert.True(double.IsNaN(resultado));
    }
}