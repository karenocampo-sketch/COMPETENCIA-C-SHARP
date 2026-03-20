using Xunit;

public class EmpleadoTests
{
    [Fact]
    public void EmpleadoFijo_CalcularSalario_RetornaSalarioFijo()
    {
        var empleado = new EmpleadoFijo("Ana", 3000);
        Assert.Equal(3000, empleado.CalcularSalario());
    }

    [Fact]
    public void EmpleadoPorHoras_CalcularSalario_RetornaHorasPorValor()
    {
        var empleado = new EmpleadoPorHoras("Luis", 40, 25);
        Assert.Equal(1000, empleado.CalcularSalario());
    }

    [Fact]
    public void EmpleadoFijo_TieneNombre()
    {
        var empleado = new EmpleadoFijo("Ana", 3000);
        Assert.Equal("Ana", empleado.Nombre);
    }

    [Fact]
    public void EmpleadoPorHoras_TieneNombre()
    {
        var empleado = new EmpleadoPorHoras("Luis", 40, 25);
        Assert.Equal("Luis", empleado.Nombre);
    }

    [Fact]
    public void EmpleadoFijo_EsEmpleado()
    {
        var empleado = new EmpleadoFijo("Ana", 3000);
        Assert.IsAssignableFrom<Empleado>(empleado);
    }

    [Fact]
    public void EmpleadoPorHoras_EsEmpleado()
    {
        var empleado = new EmpleadoPorHoras("Luis", 40, 25);
        Assert.IsAssignableFrom<Empleado>(empleado);
    }
}
