using System;

/*
Classe → Tipo por referência

--- Armazenada no heap.
--- Variáveis guardam referências para o objeto.
--- Quando você passa uma classe para um método, passa uma referência, não uma cópia.

Struct → Tipo por valor

--- Armazenada na stack (na maioria dos casos).
--- Variáveis guardam o valor completo.
--- Quando você passa uma struct para um método, passa uma cópia
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

class Aula44
{
    static void Main()
    {
        Carro c1 = new Carro("FORD", "Taurus", "Preto");
        c1.Info();


    }
}