using System;

// Estudo dos métodos virtuais -> Método que tem o mesmo nome da classe base porem vai executar uma ação diferente
//Na classe base é necessário colocar virtual no método e na classe derivada é necessário colocar override
class Base
{
    public Base()
    {
        Console.WriteLine("Construtor da classe Base");
    }

    virtual public void Info()
    {
        Console.WriteLine("Info da classe Base");
    }
}

class Derivada1 : Base
{
    public Derivada1()
    {
        Console.WriteLine("Construtor da Derivada1");
    }

    override public void Info()
    {
        Console.WriteLine("Info da classe Derivada1");
    }
}

class Derivada2: Derivada1
{
    public Derivada2()
    {
        Console.WriteLine("Construtor da Derivada2");
    }

    override public void Info()
    {
        Console.WriteLine("Info da classe Derivada2");
    }
}

class Aula38
{
    static void Main()
    {
        Derivada2 d2 = new Derivada2();
        d2.Info();

        Derivada1 d1 = new Derivada1();

        // É possível acessar um método sobrescito com a palavra reservada Ref, associe Ref a classe que se quer utilizar o método
        Base Ref;
        Ref = d1;
        Ref.Info();
    }
}