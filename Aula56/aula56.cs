// Lista duplamente encadeada é uma lista em que cada elemento tem o link do elemento anterior e posterior

using System;
using System.Collections.Generic;

class Aula56
{
    static void Main()
    {
        LinkedList<string> transp = new LinkedList<string>();

        //Adiciona no início da lista
        transp.AddFirst("Carro");
        transp.AddFirst("Avião");
        transp.AddFirst("Navio");
        transp.AddFirst("Motocicleta");

        //Adiciona no fim da lista
        transp.AddLast("Jato");

        //Adiciona após encontrar o registro
        //Baseado na posição que se quer colocar após, após navio será dicionado patinete
        LinkedListNode<string> no;
        no = transp.FindLast("Navio");
        transp.AddAfter(no, "Patins");

        //Adicionar antes
        transp.AddBefore(no, "Carruagem");

        //Limpa tudo
        //transp.Clear();

        //Limpa 1 registro
        //trans.Remove("Navio")
        //RemoveFirst e RemoveLast
        
        foreach(string t in transp)
        {
            Console.WriteLine("Transporte: {0}", t);
        }
    }
}