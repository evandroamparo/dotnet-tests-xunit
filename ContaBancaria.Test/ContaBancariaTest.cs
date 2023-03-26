namespace ContaBancaria.Test;

using Banco;

public class ContaBancariaTest
{
    [Fact]
    public void Sacar_Deve_Atualizar_Saldo()
    {
        // arrange
        var saldoInicial = 10;
        var valorSaque = 3;
        var saldoFinal = 7;

        var conta = new ContaBancaria(saldoInicial);

        // act
        conta.Sacar(valorSaque);

        //assert
        Assert.Equal(saldoFinal, conta.Saldo);
    }

    [Fact]
    public void Sacar_Valor_Maior_Que_O_Saldo_Deve_Lancar_Excecao()
    {
        // arrange
        var saldoInicial = 100;
        var valorSaque = 150;
        var conta = new ContaBancaria(saldoInicial);
        
        // act
        var excecao = Record.Exception(() => conta.Sacar(valorSaque));

        // assert
        Assert.IsType<ArgumentOutOfRangeException>(excecao);
    }

    [Fact]
    public void Sacar_Valor_Negativo_Deve_Lancar_Excecao()
    {
        
    }

    [Fact]
    public void Depositar_Deve_Aumentar_O_Saldo()
    {

    }
}