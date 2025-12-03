using System;

class Aula52
{
    static void Main()
    {
        int n1, n2, res;
        
        n1 = 10;
        n2 = 0;

        try
        {
            res = n1/n2;    
        }
        catch (Exception error)
        {
            Console.WriteLine(error.Message);
        } finally
        {
            Console.WriteLine("Uma mensagem que sempre irá acontecer com o sem erro");
        }
        

        // Console.WriteLine("{0}/{1}={2}", n1, n2, res);
    }
}