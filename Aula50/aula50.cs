//Estudo de delegates, objeto que faz referencia a um ou mais métodos dentro de uma classe, contem o endereço na memória do ponto de entrada do método

using System;

delegate int Op(int n1, int n2);

class Mat
{
    public static int soma(int n1, int n2)
    {
        return n1 + n2;
    }
    public static int multiplicacao(int n1, int n2)
    {
        return n1 * n2;
    }
}

class Aula50
{
    static void Main()
    {
        int res;

        Op d1 = new Op(Mat.soma);

        res = d1(10,50);
        Console.WriteLine(res);

        //Agora delegate vai apontar para multiplicação
        d1 = new Op(Mat.multiplicacao);

        res = d1(40,30);
        Console.WriteLine(res);

    }
}