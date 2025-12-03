using System;
using System.Collections.Generic;

class Aula57
{
    static void Main()
    {
        List<string>carros = new List<string>();
        List<string>carros2 = new List<string>();

        carros.Add("Golf");
        carros.Add("HRV");

        carros2.Add("Focus");
        carros2.Add("Argo");

        //Adicionar todos todos os carros da variável carros em carros2
        carros2.AddRange(carros);

        foreach (string c in carros)
        {
            Console.WriteLine(c);
        }
        foreach (string c in carros2)
        {
            Console.WriteLine(c);
        }

        //Verifica se está na lista
        Console.WriteLine(carros.Contains("Golf"));

        //Retorna o indece do primeiro elemento pesquisado que coincide 
        string ca = "HRV";
        int posicao = 0;
        posicao = carros.IndexOf(ca);
        Console.WriteLine("carro {0} está na posição {1}", ca, posicao);
    }
}