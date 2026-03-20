using Xunit;

public class CuentaBancariaTests
{
    [Fact]
    public void SaldoInicialEsCero()
    {
        var cuenta = new CuentaBancaria();
        Assert.Equal(0, cuenta.ObtenerSaldo());
    }

    [Fact]
    public void Depositar_AumentaElSaldo()
    {
        var cuenta = new CuentaBancaria();
        cuenta.Depositar(500);
        Assert.Equal(500, cuenta.ObtenerSaldo());
    }

    [Fact]
    public void Retirar_DescuentaElSaldo_CuandoHaySuficiente()
    {
        var cuenta = new CuentaBancaria();
        cuenta.Depositar(1000);
        bool resultado = cuenta.Retirar(400);
        Assert.True(resultado);
        Assert.Equal(600, cuenta.ObtenerSaldo());
    }

    [Fact]
    public void Retirar_RetornaFalse_CuandoNoHaySuficiente()
    {
        var cuenta = new CuentaBancaria();
        cuenta.Depositar(100);
        bool resultado = cuenta.Retirar(500);
        Assert.False(resultado);
    }

    [Fact]
    public void Retirar_NoModificaSaldo_CuandoNoHaySuficiente()
    {
        var cuenta = new CuentaBancaria();
        cuenta.Depositar(100);
        cuenta.Retirar(500);
        Assert.Equal(100, cuenta.ObtenerSaldo());
    }
}
