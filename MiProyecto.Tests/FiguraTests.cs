using Xunit;

public class FiguraTests
{
    [Fact]
    public void Circulo_CalcularArea_RetornaAreaCorrecta()
    {
        var circulo = new Circulo(5);
        double resultado = circulo.CalcularArea();
        Assert.Equal(78.54, resultado);
    }

    [Fact]
    public void Rectangulo_CalcularArea_RetornaAreaCorrecta()
    {
        var rectangulo = new Rectangulo(4, 3);
        double resultado = rectangulo.CalcularArea();
        Assert.Equal(12, resultado);
    }

    [Fact]
    public void Circulo_EsFigura()
    {
        var circulo = new Circulo(3);
        Assert.IsAssignableFrom<Figura>(circulo);
    }

    [Fact]
    public void Rectangulo_EsFigura()
    {
        var rectangulo = new Rectangulo(2, 5);
        Assert.IsAssignableFrom<Figura>(rectangulo);
    }
}
