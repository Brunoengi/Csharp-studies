using System;

class Galinha
{
    private string nomeGalinha;
    private int numOvo;
    public Galinha(string nomeGalinha)
    {
        this.nomeGalinha = nomeGalinha;
        numOvo = 0;
    }

    public Ovo botar()
    {
        return new Ovo();
    }
}

class Ovo
{
    public Ovo()
    {
        Console.WriteLine("Ovo criado");
    }
}

class Aula46
{
    static void Main()
    {
        Galinha g1 = new Galinha("Cocoricó");
        Galinha g2 = new Galinha("Cococo");
        g1.botar();
        g1.botar();
        g1.botar();
        g2.botar();
        
    
    }
}