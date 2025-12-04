using System;
using System.Collections.Generic;

class Aula59
{
    static void Main()
    {
        string[] veiculos = {"Carro", "Moto", "Navio"};

        //Uma opção de inicialização
        Queue<string>veiculos = new Queue<string>(veiculos);

        veiculos.Enqueue("Avião");

        Console.WriteLine("Tamanho Fila: {0}",veiculos.Count);

        //Pega o primeiro elemento, retorna e remove da fila
        Console.WriteLine("Primeiro Veículo: {0}",veiculos.Dequeue());     

        Console.WriteLine("Tamanho Fila: {0}",veiculos.Count); 

        //Retorna o primeiro elemento mas não remove
        Console.WriteLine("Primeiro Veículo sem remover: {0}",veiculos.Peek());                                               
    }
}