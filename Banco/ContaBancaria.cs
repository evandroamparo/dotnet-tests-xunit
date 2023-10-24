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
        if (valor < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(valor), "O valor do saque não pode ser negativo.");
        }

        if (valor > Saldo)
        {
            throw new ArgumentOutOfRangeException(nameof(valor), "O valor do saque não pode ser maior que o saldo.");
        }
        Saldo -= valor;
    }
}
