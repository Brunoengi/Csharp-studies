using System;

//Lendo valores do teclado
class Aula08
{
    static void Main()
    {
        int v1, v2, soma;
        string nome;

        // int.Parse é a operação de casting de string para int
        // Console.ReadLine() lê uma linha do teclado e retorna uma string
        Console.Write("Digite o primeiro valor: ");
        v1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo valor: ");
        v2 = int.Parse(Console.ReadLine());

        soma = v1 + v2;
        Console.WriteLine("A soma é: " + soma);
    }
}