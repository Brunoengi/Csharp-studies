using System;

class Aula03
{
    static void Main(string[] args)
    {
        char caracter = 'A';
        float valor = 5.3f;
        int num = -10;
        byte b = 255; // byte armazena valores de 0 a 255
        string texto = "Olá, Mundo!";

        var aux = 100; // O compilador infere que 'aux' é do tipo int O tipo é definido no ato da compilação

        int num1, num2, num3; // Declaração múltipla de variáveis do mesmo tipo
        num1= 10;

        Console.WriteLine("Valor inteiro: " + num);
        Console.WriteLine("Valor inteiro: " + num + " Concatenado" + texto);
    }
}