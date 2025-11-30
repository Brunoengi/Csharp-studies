using System;

// A ordem de execução dos contrutores é primeiro a classe base e depois a derivada
class Veiculo
{
    public string marca;
    public int ano;

    public Veiculo(string marca, int ano)
    {
        this.marca = marca;
        this.ano = ano;
        Console.WriteLine("Construtor de Veiculo");
    
    }
}

class Carro : Veiculo
{
    public string modelo;

    public Carro(string marca, int ano, string modelo) : base(marca, ano)
    {
        Console.WriteLine("Construtor de Carro");
        this.modelo = modelo;
    }
    
}

class Aula37
{
    public static void Main()
    {
        Carro c1 = new Carro("Peugeot", 2020, "208");
    }
}