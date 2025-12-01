using System;

//Estudando classe selada - Não pode ser herdada por outra classe

sealed class Veiculo
{
    
}

//Se Veiculo for sealed, Carro não pode herdar Veiculo
class Carro : Veiculo
{
    
}

class Aula40
{
    static void Main()
    {
        
    }
}