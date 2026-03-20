using Xunit;

public class ISonidoTests
{
    [Fact]
    public void Perro_HacerSonido_RetornaGuau()
    {
        ISonido animal = new Perro();
        Assert.Equal("Guau", animal.HacerSonido());
    }

    [Fact]
    public void Gato_HacerSonido_RetornaMiau()
    {
        ISonido animal = new Gato();
        Assert.Equal("Miau", animal.HacerSonido());
    }

    [Fact]
    public void Vaca_HacerSonido_RetornaMuuu()
    {
        ISonido animal = new Vaca();
        Assert.Equal("Muuu", animal.HacerSonido());
    }
}
