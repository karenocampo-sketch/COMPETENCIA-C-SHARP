public class CuentaBancaria
{
    private double saldo = 0;

    public void Depositar(double monto)
    {
        saldo += monto;
    }

    public bool Retirar(double monto)
    {
        if (monto > saldo)
        {
            return false;
        }
        saldo -= monto;
        return true;
    }

    public double ObtenerSaldo()
    {
        return saldo;
    }
}
