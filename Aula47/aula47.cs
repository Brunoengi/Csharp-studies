using System;

//Sobrecarga de métodos para aceitar vários tipos
class Calc
{
    public int Soma(params int[]n)
    {
        int soma = 0;
        for(int i = 0; i<n.Length; i++)
        {
            soma+=n[i];
        }
        return soma;
    }

      public double Soma(params double[]n)
    {
        double soma = 0;
        for(int i = 0; i<n.Length; i++)
        {
            soma+=n[i];
        }
        return soma;
    }

}
class Aula47
{
    static void Main()
    {
        Calc calc = new Calc();
        double resSoma = calc.Soma(5.2,3.4, 1.2);
        Console.WriteLine(resSoma);
    }
}