public class ContaBancaria
{
    public string Titular;
    public string NumeroConta;
    public double Saldo;

    public void Depositar(double valor)
    {
        if (valor > 0)
        {
            Saldo += valor;
            Console.WriteLine($"Depósito de R$ {valor:N2} realizado com sucesso para {Titular}.");
        }
    }

    public void Sacar(double valor)
    {
        if (valor > Saldo)
        {
            Console.WriteLine($"Erro: Saldo insuficiente para o saque de R$ {valor:N2} (Saldo atual: R$ {Saldo:N2}).");
        }
        else
        {
            Saldo -= valor;
            Console.WriteLine($"Saque de R$ {valor:N2} realizado. Novo saldo: R$ {Saldo:N2}");
        }
    }

    public void ExibirSaldo()
    {
        Console.WriteLine($"--- Extrato --- \nConta: {NumeroConta} | Titular: {Titular} | Saldo: R$ {Saldo:N2}\n");
    }
}

public class ProgramBancario
{
    public static void Main()
    {
        ContaBancaria c1 = new ContaBancaria { Titular = "Marcos", NumeroConta = "123", Saldo = 500.00 };
        c1.ExibirSaldo();
        c1.Depositar(200);
        c1.Sacar(100);
        c1.ExibirSaldo();

        ContaBancaria c2 = new ContaBancaria { Titular = "Paulo", NumeroConta = "456", Saldo = 100.00 };
        c2.ExibirSaldo();
        c2.Sacar(150.00);
        c2.ExibirSaldo();
    }
}
