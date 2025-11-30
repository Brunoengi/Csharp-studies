using System;

//Classe abstrata é uma classe de referência para outras classes que vão herdar a outra classe
//Métodos abstratos em classe abstratas não são implementados, é inserido o protótipo.. quem herdar implementa o método

//Classe base abstrata
abstract class Veiculo
{
    protected int velMaxima;
    protected int velAtual;
    protected bool ligado;

    public Veiculo()
    {
        ligado = false;
        velAtual = 0;
    }

    public void SetLigado(bool ligado)
    {
        this.ligado = ligado;
    }

    abstract public void Aceleracao();

    public int GetVelAtual()
    {
        return velAtual;
    }
}

class Carro: Veiculo
{
    public Carro(): base()
    {
        velMaxima = 200;
    }

    override public void Aceleracao()
    {
        velAtual += 10;
    
    }
}

class Aula39
{
    static void Main()
    {
        Carro c1 = new Carro();
        c1.SetLigado(true);
        c1.Aceleracao();

        Console.WriteLine(c1.GetVelAtual());
    }
}