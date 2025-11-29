using System;

//Estudando como extender uma classe, herança
class Veiculo
{
    public int velMax;
    public bool ligado;

    public void Ligar()
    {
        ligado = true;
    }

    public void Desligar()
    {
        ligado = false;
    }

    public Veiculo(int velMax, bool ligado)
    {
        this.velMax = velMax;
        this.ligado = ligado;

    }

}

class Carro : Veiculo
    {
        public Carro(int velMax, bool ligado) : base(velMax, ligado)
        {

        }
    }
        
class Aula34
        {
            static void Main()
            {
                Carro c1 = new Carro(30, true);
                Console.WriteLine(c1.velMax);
                Console.WriteLine(c1.ligado);
            }
        }