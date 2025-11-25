using System;

//Estudo de operadores Bitwise

class Aula09
{
    static void Main()
    {
        int a = 60;     // 60 = 0011 1100 
        int b = 13;     // 13 = 0000 1101
        int resultado;

        // AND
        resultado = a & b;       // 12 = 0000 1100
        Console.WriteLine("a & b = " + resultado);

        // OR
        resultado = a | b;       // 61 = 0011 1101
        Console.WriteLine("a | b = " + resultado);

        // XOR
        resultado = a ^ b;       // 49 = 0011 0001
        Console.WriteLine("a ^ b = " + resultado);

        // NOT
        resultado = ~a;          // -61 = 1100 0011
        Console.WriteLine("~a = " + resultado);

        // Deslocamento à esquerda
        resultado = a << 2;     // 240 = 1111 0000
        Console.WriteLine("a << 2 = " + resultado);

        // Deslocamento à direita
        resultado = a >> 2;     // 15 = 0000 1111
        Console.WriteLine("a >> 2 = " + resultado);
    }

}