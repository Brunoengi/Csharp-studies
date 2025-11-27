using System;

public class Jogador
{
    public int energia;
    public bool vivo;
    public string nome;

    public Jogador(string nom)
    {
        energia = 100;
        vivo = true;
        nome = nom;
    }

    Jogador()
    {
        Console.WriteLine("Construtor padrão chamado");
    }
    ~Jogador()
    {
        Console.WriteLine("Destrutor chamado para o jogador: " + nome);
    }
}

class Aula29
{
    static void Main()
    {
        Jogador j1 = new Jogador("PlayerOne");
        Jogador j2 = new Jogador("PlayerTwo");

        Console.WriteLine("Nome: " + j1.nome + " | Energia: " + j1.energia + " | Vivo: " + j1.vivo);
        Console.WriteLine("Nome: " + j2.nome + " | Energia: " + j2.energia + " | Vivo: " + j2.vivo);
    }
}