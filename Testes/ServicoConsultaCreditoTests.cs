using Moq;
using Xunit;
using Testes;

public class ServicoConsultaCreditoTests
{
    [Fact]
    public void TesteConsultaCreditoAprovado()
    {
        var mock = new Mock<IServicoConsultaCredito>();
        mock.Setup(servico => servico.ConsultarCredito("12345678900")).Returns(true);

        bool resultado = mock.Object.ConsultarCredito("12345678900");
        Assert.True(resultado);
    }
}
