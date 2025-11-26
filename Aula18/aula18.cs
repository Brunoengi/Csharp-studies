using System;

//Estudando Matrizes / Vetores Multidimensionais

class Aula18
{
    static void Main()
    {
        //Array com 3 linhas e 5 colunas
        int[,] matriz = new int[3, 5];

        /*Um exemplo de atribuição de valores
        10, 20, 30, 40, 50
        15, 25, 35, 45, 55
        27, 29, 37, 49, 59
        */

        matriz[0, 0] = 10;
        matriz[0, 1] = 20;
        matriz[0, 2] = 30;
        matriz[0, 3] = 40;
        matriz[0, 4] = 50;

        matriz[1, 0] = 15;
        matriz[1, 1] = 25;
        matriz[1, 2] = 35;
        matriz[1, 3] = 45;
        matriz[1, 4] = 55;

        matriz[2, 0] = 27;
        matriz[2, 1] = 29;
        matriz[2, 2] = 37;
        matriz[2, 3] = 49;
        matriz[2, 4] = 59;

        //Outra forma de declarar e inicializar uma matriz  
        int[,] matriz2 = { { 10, 20, 30, 40, 50 },
                           { 15, 25, 35, 45, 55 },
                           { 27, 29, 37, 49, 59 } };

        //Exibindo os valores da matriz
        for (int i = 0; i < 3; i++) //Percorre as linhas
        {
            for (int j = 0; j < 5; j++) //Percorre as colunas
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine(); //Pula para a próxima linha após exibir uma linha completa
        }

    }
}