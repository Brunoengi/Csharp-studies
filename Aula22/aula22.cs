using System;

class Aula22
{
    static void Main()
    {
        int[] num = new int[3] { 10, 20, 30 };

        //Utilizando o foreach para exibir os valores do array, a variável tem que ser do mesmo tipo do array
        foreach (int n in num)
        {
            Console.WriteLine(n);
        }

        //Utilizando o for para exibir os valores do array
        for (int i = 0; i < num.Length; i++)
        {
            Console.WriteLine(num[i]);
        }
    }


}