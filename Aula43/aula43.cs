//Estudando Interfaces

using System;

public interface IVeiculo
{
    void Ligar();
    void Desligar();
    void Info();
}

public interface ICombate
{
    void Disparar();
}

// A maneira como se utiliza interface é a mesma se fosse uma classe com herança
class Carro: IVeiculo, ICombate
{
    public bool ligado;
    public int balas = 100;

    public Carro()
    {
        
    }

    public void Disparar()
    {
        this.balas --;
    }

    public void Ligar()
    {
        this.ligado = true;
    }

    public void Desligar()
    {
        this.ligado = false;
    }

    public void Info()
    {
        Console.WriteLine("Informações do Carro, O carro está ligado?: {0}", ligado);
        Console.WriteLine("Número de balas: {0}", balas);
    }
}

class Aula43
{
    static void Main()
    {
        Carro c1 = new Carro();
        c1.Ligar();
        c1.Disparar();
        c1.Info();
    }
}