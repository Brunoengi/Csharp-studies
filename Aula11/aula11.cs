using System;

//Estudando typecasting
class Aula11
{
    static void Main()
    {
        //Conversão implícita de int para double
        int inteiro = 10;
        double numeroDouble = inteiro;
        Console.WriteLine("Valor double (conversão implícita): " + numeroDouble);

        //Conversão explícita de double para int
        double outroDouble = 9.78;
        int outroInteiro = (int)outroDouble;
        Console.WriteLine("Valor inteiro (conversão explícita): " + outroInteiro);

        //Conversão explícita de char para int
        char caractere = 'A';
        int valorAscii = (int)caractere;
        Console.WriteLine("Valor ASCII de 'A': " + valorAscii);
    }
}