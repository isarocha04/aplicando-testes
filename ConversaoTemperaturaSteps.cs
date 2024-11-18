using TechTalk.SpecFlow;

[Binding]
public class ConversaoTemperaturaSteps
{
    private double _fahrenheit;
    private double _resultado;

    [Given(@"uma temperatura de (.*) graus Fahrenheit")]
    public void DadoUmaTemperatura(double fahrenheit)
    {
        _fahrenheit = fahrenheit;
    }

    [When(@"a conversão é realizada")]
    public void QuandoAConversaoERealizada()
    {
        _resultado = Conversor.FahrenheitParaCelsius(_fahrenheit);
    }

    [Then(@"o resultado será (.*) graus Celsius")]
    public void EntaoOResultado(double esperado)
    {
        Assert.Equal(esperado, _resultado);
    }
}