//Trabalhando com indexadores de Classes

using System;

class Carro
{
    private int[] velMax = new int[5] { 80, 120, 160, 240, 300 };
    public int this[int i]
    {
        get
        {
            return velMax[i];
        }
        set
        {
            if (value < 0)
            {
                velMax[i] = 0;
            }
            else
            {
                velMax[i] = value;
            }

        }
    }
}

class Aula42
{
    static void Main()
    {
        Carro c1 = new Carro();
        c1[4] = 200;
        Console.WriteLine(c1[4]);

    }
}
