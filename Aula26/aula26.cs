using System;

//Estudando o argumento out

class Aula26
{
    static void Main()
    {
        int dividendo, divisor, quociente, resto;
        dividendo = 10;
        divisor = 5;
        quociente = Divide(dividendo, divisor, out resto);

        Console.WriteLine("{0}/{1} = {2} com resto {3}", dividendo, divisor, quociente, resto);
    }
    static int Divide(int dividendo, int divisor, out int resto)
    {
        int quociente = dividendo / divisor;
        resto = dividendo % divisor;
        return quociente;
    }
}