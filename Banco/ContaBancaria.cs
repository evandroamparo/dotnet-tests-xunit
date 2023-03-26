namespace Banco;

public class ContaBancaria
{
    public double Saldo { get;  private set; }

    public ContaBancaria(double saldoInicial)
    {
        Saldo = saldoInicial;
    }

    public void Sacar(double valor)
    {
        if (valor > Saldo)
        {
            throw new ArgumentOutOfRangeException(nameof(valor));
        }
        Saldo -= valor;
    }
}