public class Pessoa
{
    public string Nome;
    public int Idade;
    public string Cargo;

    public void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos. Sou {Cargo}");
    }

    public void Salario()
    {
        double salario = 0;

        if (Cargo == "Gerente") {
            salario = 10000;
        }
        if (Cargo == "Desenvolvedor") {
            salario = 5000;
        }
        if (Cargo == "Estagiario") {
            salario = 100;
        }

        Console.WriteLine($"Salario = {salario}");
    }

}

public class Program
{
    public static void Main()
    {
        Pessoa p1 = new Pessoa();
        p1.Idade = 30;
        p1.Nome = "Joao";
        p1.Cargo = "Gerente";
        p1.Apresentar();
        p1.Salario();
        
        Pessoa p2 = new Pessoa();
        p2.Idade = 23;
        p2.Nome = "Marcos";
        p2.Cargo = "Desenvolvedor";
        p2.Apresentar();
        p2.Salario();

        Pessoa p3 = new Pessoa();
        p3.Idade = 23;
        p3.Nome = "Teste3";
        p3.Cargo = "Estagiario";
        p3.Apresentar();
        p3.Salario();
    }
}
