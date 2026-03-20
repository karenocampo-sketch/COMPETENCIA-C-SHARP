using Xunit;

public class ContadorTests
{
    [Fact]
    public void Incrementar_RetornaUno_PrimerLlamado()
    {
        var contador = new Contador();
        int resultado = contador.Incrementar();
        Assert.Equal(1, resultado);
    }

    [Fact]
    public void Incrementar_AcumulaValor()
    {
        var contador = new Contador();
        contador.Incrementar();
        int resultado = contador.Incrementar();
        Assert.Equal(2, resultado);
    }

    [Fact]
    public void Decrementar_RetornaMenunosUno_DesdeCero()
    {
        var contador = new Contador();
        int resultado = contador.Decrementar();
        Assert.Equal(-1, resultado);
    }

    [Fact]
    public void Decrementar_AcumulaValor()
    {
        var contador = new Contador();
        contador.Incrementar();
        contador.Incrementar();
        int resultado = contador.Decrementar();
        Assert.Equal(1, resultado);
    }
}
