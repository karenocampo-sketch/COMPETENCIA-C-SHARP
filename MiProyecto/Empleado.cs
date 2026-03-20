public class Empleado
{
    public string Nombre { get; set; }

    public Empleado(string nombre)
    {
        Nombre = nombre;
    }

    public virtual double CalcularSalario()
    {
        return 0;
    }
}

public class EmpleadoFijo : Empleado
{
    private double salarioFijo;

    public EmpleadoFijo(string nombre, double salarioFijo) : base(nombre)
    {
        this.salarioFijo = salarioFijo;
    }

    public override double CalcularSalario()
    {
        return salarioFijo;
    }
}

public class EmpleadoPorHoras : Empleado
{
    private double horas;
    private double valorHora;

    public EmpleadoPorHoras(string nombre, double horas, double valorHora) : base(nombre)
    {
        this.horas = horas;
        this.valorHora = valorHora;
    }

    public override double CalcularSalario()
    {
        return horas * valorHora;
    }
}
