public class Fantasma
{
    public string Nick;
    public string Cor;
    public string Habilidade;

    public Fantasma(string nick, string cor, string habilidade)
    {
        Nick = nick;
        Cor = cor;
        Habilidade = habilidade;
    }

    public void GerarFantasma()
    {
        Console.WriteLine($"Nick: {Nick}");
        Console.WriteLine($"Cor: {Cor}");
        Console.WriteLine($"Habilidade: {Habilidade}");
    }

    public void Mover(string direcao)
    {
        Console.WriteLine($"{Nick} se moveu para {direcao}.");
    }
}

public class Program
{
    public static void Main()
    {
        Fantasma f1 = new Fantasma("Blinky", "Vermelho", "Perseguição direta");
        Fantasma f2 = new Fantasma("Pinky", "Rosa", "Emboscada/Antecipação");

        f1.GerarFantasma();
        f1.Mover("Esquerda");

        f2.GerarFantasma();
        f2.Mover("Cima");
    }
}
