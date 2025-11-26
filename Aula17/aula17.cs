using System;

//Array unidimensional ou Vetor 
class Aula17
{
    static void Main()
    {
        int n1, n2, n3, n4, n5;

        //Array vazio
        int[] n = new int[5];

        //Populando Array
        n[0] = 10;
        n[1] = 20;
        n[2] = 30;
        n[3] = 40;
        n[4] = 50;

        //Imprimindo valores do Array
        Console.WriteLine(n[0]);

        //Array já populado - Forma 1
        int[] num = new int[5] { 11, 22, 33, 44, 55 };
        Console.WriteLine(num[0]);

        //Array já populado - Forma 2
        int[] numeros = { 111, 222, 333, 444, 555 };
        Console.WriteLine(numeros[0]);
    
        //Trabalhando com vetores de string
        //Forma 1 - com new
        string[] carros = new string[3];
        carros[0] = "BMW";
        carros[1] = "Audi";
        carros[2] = "Mercedes";
        Console.WriteLine(carros[0]);

        //Forma 2 - sem new
        string[] motos = { "Honda", "Yamaha", "Suzuki" };
        Console.WriteLine(motos[0]);

        
    }
}