using System;

/*
Array de estruturas
*/

struct Carro
{
    public string marca;
    public string modelo;
    public string cor;

    public Carro(string marca, string modelo, string cor)
    {
        this.marca = marca;
        this.cor = cor;
        this.modelo = modelo;
    }

    public void Info()
    {
        Console.WriteLine("Marca:{0}", this.marca);
        Console.WriteLine("Cor:{0}", this.cor);
        Console.WriteLine("Modelo:{0}", this.modelo);
    }
}

class Aula45
{
    static void Main()
    {

        Carro[] carros = new Carro[2];
        carros[0] = new Carro("FORD", "Taurus", "Preto");
        carros[1] = new Carro("FORD", "Camaro", "verde");
        carros[0].Info();
        carros[1].Info();
    


    }
}