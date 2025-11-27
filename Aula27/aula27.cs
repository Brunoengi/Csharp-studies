using System;

//Estudo de params
class Aula27
{
    static void Main()
    {
        SomaParams(1,2,3,4,5);
    }

//Método que soma uma quantidade definida de números
    static void Soma(int n1, int n2)
    {
        int res = n1 + n2;
        Console.WriteLine("Soma: " + res);
    }

//Método que soma uma quantidade variável de números usando params
    static void SomaParams(params int[] numeros)
    {
        int res = 0;
        for (int i = 0; i < numeros.Length; i++)
        {
            res += numeros[i];
        }
        Console.WriteLine("Soma com params: " + res);
    }
}