using Xunit;

public class ConversorTests
{
    [Theory]
    [InlineData(32, 0)]
    [InlineData(212, 100)]
    public void TesteConversaoFahrenheitParaCelsius(double fahrenheit, double esperado)
    {
        double resultado = Conversor.FahrenheitParaCelsius(fahrenheit);
        Assert.Equal(esperado, resultado);
    }
}