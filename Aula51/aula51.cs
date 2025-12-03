//Argumentos de entrada para o programa

using System;

class Aula51
{
    static void Main(string[] args)
    {
        if (args.Length > 0)
        {
            Console.WriteLine("Qtde de argumentos:{0}", args.Length);

            //Lendo a lista de argumentos
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("Argumento na posição {0}: {1}", i, args[i]);
            }

        }
        else
        {
            Console.WriteLine("Nenhum argumento passado");
        }
    }
}