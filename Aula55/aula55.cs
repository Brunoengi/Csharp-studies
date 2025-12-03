using System;
using System.Collections.Generic;

class Aula55
{
    static void Main()
    {
        Dictionary <int, string> veiculos = new Dictionary <int, string>();
        veiculos.Add(10, "Carro");
        veiculos.Add(5, "Avião");
        veiculos.Add(15, "Bike");
        veiculos.Add(20, "Moto");

        Console.WriteLine("Tamanho do dicionário {0}", veiculos.Count);

        //Verifica se o dicionário tem um elemento com a chave especificada
        int chave = 20;
        Console.WriteLine("Dicionário tem a chave {0}? {1}", chave, veiculos.ContainsKey(chave));

        //Verifica se o dicionário tem um valor espcificado
        string value = "Bike";
        Console.WriteLine("Dicionário tem a chave {0}? {1}", value, veiculos.ContainsValue(value));

        //Substituindo um valor tendo a sua chave
        veiculos[15] = "Bocicleta";
    }
}