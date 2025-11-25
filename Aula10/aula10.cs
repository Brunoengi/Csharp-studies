using System;

class Aula10
{

// Não é necessário atribuir valores aos elementos do enum, pois eles são atribuídos automaticamente começando do zero mas pode ser feito se desejado.
    enum DiasSemana
    {
        Domingo = 0,
        Segunda = 1,
        Terca = 2,
        Quarta = 3,
        Quinta = 4,
        Sexta = 5,
        Sabado = 6
    }

    static void Main()
    {
        DiasSemana diaAtual = DiasSemana.Quarta;
        Console.WriteLine("Dia atual da semana: " + diaAtual);

        //Convertendo um valor inteiro para o enum
        DiasSemana diaFavorito = (DiasSemana)0;
        Console.WriteLine("Dia favorito: " + diaFavorito);

        //Convertendo um enum para um valor inteiro
        int valorDia = (int)DiasSemana.Sexta;
        Console.WriteLine("Valor inteiro de Sexta: " + valorDia);
    }
}