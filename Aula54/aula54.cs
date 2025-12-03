using System;
using Calculadora;


//Namespace controla o escopo

namespace Calculadora
{
    class Area
    {
        public static void Quad()
        {
            Console.WriteLine("Simulando 1");
        }
        public static void Quad2()
        {
            Console.WriteLine("Simulando 2");
        }
    }

    class Perimetro
    {
        public static void Per()
        {
            Console.WriteLine("Simulando 3");
        }
        public static void Per2()
        {
            Console.WriteLine("Simulando 4");
        } 
    }
}


class Aula54
{
    static void Main()
    {
        Perimetro.Per();
        Perimetro.Per2();
        Area.Quad();
        Area.Quad2();
    }
}