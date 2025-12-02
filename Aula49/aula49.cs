using System;

class Mat
{
    public static double pi = 3.1415;
    public static int dobro(int n)
    {
        return n * 2;
    }
}

class Aula49
{
    static void Main()
    {
        double valorPi = Mat.pi;
        int valordobrado = Mat.dobro(20);
        Console.WriteLine(valorPi);
        Console.WriteLine(valordobrado);
    }
}