using Crosscutting;
using Domain;
using FluentAssertions;
using Moq;
using Xunit;

namespace Test.Domain;

public class TesteServiceTests
{
    private readonly TesteService _sut;
    private readonly Mock<ICombinadorDeStringService> _combinadorDeStringServiceMock;

    public TesteServiceTests()
    {
        _combinadorDeStringServiceMock = new Mock<ICombinadorDeStringService>();
        _sut = new TesteService(_combinadorDeStringServiceMock.Object);
    }

    [Fact]
    public void TesteMetodo_QuandoSucesso_DeveRetornarStringCombinada()
    {
        //Arrange
        var requisicao = new TesteRequisicaoDto
        {
            Primeira = "ola",
            Segunda = "Testando",
            Terceira = "Bom dia"
        };

        var partes = new List<string>
        {
            "ola", "Testando", "Bom dia"
        };

        var resultadoEsperado = "ola,Testando,Bom dia";

        _combinadorDeStringServiceMock
            .Setup(x => x.CombinarPartes(partes))
            .Returns(resultadoEsperado);
        
        //Act
        var resultado = _sut.TesteMetodo(requisicao);
        
        //Assert
        resultado.Should().Be(resultadoEsperado);
    }
}