using System;

//Estudo de passagem de parâmetros por valor e por referência em C#

class Aula25
{
    static void Main()
    {
        int numero = 10;
        Console.WriteLine("Antes de Dobrar por Valor: " + numero);
        Dobrar(numero);
        Console.WriteLine("Depois de Dobrar por Valor: " + numero);

        //Variável numero permanece 10, pois foi passada por valor
        Console.WriteLine(numero);

        int numero2 = 20;
        Console.WriteLine("Antes de Dobrar por Referência: " + numero2);
        DobrarRef(ref numero2);
        Console.WriteLine("Depois de Dobrar por Referência: " + numero2);

        //Variável numero2 agora é 40, pois foi passada por referência
        Console.WriteLine(numero2);
    }

    static void Dobrar(int valor)
    {
        valor *= 2;
    }

    static void DobrarRef(ref int valor)
    {
        valor *= 2;
    }
}