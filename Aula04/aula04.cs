using System;

class Aula04
{
    static int numeroGlobal = 20; // Variável de instância (membro da classe)

    static void Main()
    {
        Console.WriteLine(numeroGlobal);

    }

    void Imprimir()
    {
        int numero = 10;
        Console.WriteLine(numero);
    }

    void ImprimirGlobal()
    {
        Console.WriteLine(numeroGlobal);
    }
}