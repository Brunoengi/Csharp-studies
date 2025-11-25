using System;

//Formatando saída do console
class Aula06
{
    static void Main()
    {
        int n1, n2, n3;
        n1 = 10;
        n2 = 20;
        n3 = 30;

        double  valorCompra = 1500.50;
        double valorVenda = 2500.99;
        double lucro = 0.1;

        // Utilizando índices
        Console.WriteLine("Números: n1 = {0}, n2 = {1}, n3 = {2}", n1, n2, n3);
        
        //Quebrando linhas
        Console.WriteLine("Números: \n n1 = {0}, \n n2 = {1}, \n n3 = {2}", n1, n2, n3);

        // Tabulação
        Console.WriteLine("Números: \t n1 = {0}, \t n2 = {1}, \t n3 = {2}", n1, n2, n3);
    
        // 15 -> espaçamento, c -> Formatação de dinheiro
        Console.WriteLine("Valor de Compra: {0,15:c}", valorCompra);

        // 15 -> espaçamento, p -> Porcentagem
        Console.WriteLine("Valor de Compra: {0,15:p}", lucro);
    }
}