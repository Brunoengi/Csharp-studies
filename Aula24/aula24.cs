using System;

// Aula 24 - Métodos em C#
class Aula24
{
    static void Main()
    {
        Ola();
        Printarnumero(10);
        Printarnumero(20);
        int soma = RetornaSoma(5, 15);
        Console.WriteLine("Soma: " + soma);
    }

    static void Ola()
    {
        Console.WriteLine("Olá Mundo!");
    }

    static void Printarnumero(int n)
    {
        Console.WriteLine("Número: " + n);
    }

    static int RetornaSoma(int n1, int n2)
    {
        int resultado = n1 + n2;
        return resultado;
    }
}