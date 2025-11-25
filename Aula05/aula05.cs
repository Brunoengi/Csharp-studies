using System;

//Operadores e Operações

class Aula05
{
    static void Main()
    {
        int res = 10 + 5; //Operador de atribuição e adição
        int res2 = res - 3; //Operador de subtração
        int res3 = res2 * 2; //Operador de multiplicação
        int res4 = res3 / 2; //Operador de divisão
        int res5 = res4 % 3; //Operador módulo (resto da divisão)
        res5++; //Operador de incremento
        res5--; //Operador de decremento
        res5 += 10; //Operador de atribuição composto (adição)
        res5 -= 5; //Operador de atribuição composto (subtração)
        res5 *= 2; //Operador de atribuição composto (multiplicação)
        res5 /= 3; //Operador de atribuição composto (divisão)

        bool resultado = (20 > 10); //Operador relacional (maior que) do tipo booleano
        bool resultado2 = (5 <= 3); //Operador relacional (menor ou igual a)
        bool resultado3 = (10 == 10); //Operador de igualdade
        bool resultado4 = (15 != 5); //Operador de diferença
        bool resultado5 = (true && false); //Operador lógico E
        bool resultado6 = (true || false); //Operador lógico OU
        bool resultado7 = !resultado6; //Operador lógico de negação
    
        Console.WriteLine(5 > 3 || 1 > 2);
    }
}