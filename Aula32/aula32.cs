//Estudando o this

using System;

//Usa o this para entender quando a propriedade tem o mesmo nome do parametro. Nesse caso é necessário o this
class Calculos
{
    public int n1;
    public int n2;

    public void Calcular(int n1, int n2)
    {
        this.n1 = n1;
        this.n2 = n2;
    }
}

class Aula32
{
    static void Main()
    {
        Calculos ex1 = new Calculos();
        ex1.Calcular(5,3);
        Console.WriteLine("n1 = {0}, n2 = {1}", ex1.n1, ex1.n2);
    }
}