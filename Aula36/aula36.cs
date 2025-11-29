using System;
// classe base
class Veiculo
{
    public int velAtual;
    private int velMax;
    protected bool ligado;

    public Veiculo(int velMax)
    {
        this.velAtual = 0;
        this.velMax = velMax;
        this.ligado = false;
    }
}

class Carro : Veiculo
{
    public Carro(int velMax): base(velMax)
    {
        //Consigo acessar o que for protected mas não consigo acessar o que é private, ou seja, não consigo acessar velMax
        this.velAtual = 10;
    }
}

//Propriedade Protected pode ser acessado pelas classes derivadas mas não pela instância

class Aula36
{
    static void Main()
    {
        Carro c1 = new Carro(40);
        //Só consigo acessar o que for public, no caso velAtual
        Console.WriteLine(c1.velAtual);
    }
}