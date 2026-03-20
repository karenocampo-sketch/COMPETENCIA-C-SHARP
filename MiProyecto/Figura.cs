public abstract class Figura
{
    public abstract double CalcularArea();
}

public class Circulo : Figura
{
    private double radio;

    public Circulo(double radio)
    {
        this.radio = radio;
    }

    public override double CalcularArea()
    {
        return Math.Round(Math.PI * radio * radio, 2);
    }
}

public class Rectangulo : Figura
{
    private double base_;
    private double altura;

    public Rectangulo(double base_, double altura)
    {
        this.base_ = base_;
        this.altura = altura;
    }

    public override double CalcularArea()
    {
        return base_ * altura;
    }
}
