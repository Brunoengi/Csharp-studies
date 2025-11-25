using System;

// estudo de if aninhado
class Aula14
{
    static void Main()
    {
        int hora = 14;

        if (hora < 12)
        {
            Console.WriteLine("Bom dia!");
        }
        else
        {
            if (hora < 18)
            {
                Console.WriteLine("Boa tarde!");
            }
            else
            {
                Console.WriteLine("Boa noite!");
            }
        }
    }
}

