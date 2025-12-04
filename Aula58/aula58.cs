//Estudando a coleção List

using System;
using System.Collections.Generic;

class Aula58
{
    static void Main()
    {
        List<string>carros = new List<string>();
        List<string>carros2 = new List<string>();

        carros.Add("Golf");
        carros.Add("HRV");

        carros2.Add("Focus");
        carros.Add("HRV");
        carros2.Add("Argo");

        //Inserir dado na posição 1
        carros.Insert(1, "Cruze");
        
        //Pega a posição do último elemento encontrado que coincida
        Console.WriteLine(carros.LastIndexOf("HRV"));

        //Remover um elemento: Remove
        //Remover todos os elementos: RemoveAll
        //Remove na posição indicada: RemoveAt
        //Inverte a lista: Reverse
        //Ordenação dos elementos da lista por ordem alfabética: Sort
        //Tamanho da Lista: Count
        //Retorna a capacidade de elementos que a lista pode armazenar: Capacity;
    }
}