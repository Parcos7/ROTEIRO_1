public class Produto
{
    public string Nome;
    public double Preco;
    public int Quantidade;

    public void Dados()
    {
        Console.WriteLine($"Produto: {Nome} | Preço: R$ {Preco:N2} | Estoque: {Quantidade}");
    }

    public double Total()
    {
        return Preco * Quantidade;
    }
}

public class Program
{
    public static void Main()
    {
        Produto p1 = new Produto { Nome = "Teclado Mecânico", Preco = 250.00, Quantidade = 10 };
        Produto p2 = new Produto { Nome = "Mouse Gamer", Preco = 150.00, Quantidade = 5 };
        Produto p3 = new Produto { Nome = "Monitor 144hz", Preco = 1200.00, Quantidade = 2 };

        Completa(p1);
        Completa(p2);
        Completa(p3);
    }

    static void Completa(Produto p)
    {
        p.Dados();
        Console.WriteLine($"Valor total em estoque: R$ {p.Total():N2}\n");
    }
}
