using System;

//Estudando classes e objetos em C#

/*
Especificação de acesso: (Define a visibilidade de classes e membros)
- public: Acesso de qualquer outra classe
- private: Acesso somente dentro da própria classe
- protected: Acesso dentro da própria classe e classes derivadas

- abstract: Classe que não pode ser instanciada diretamente, apenas herdada
- sealed: Classe que não pode ser herdada
- static: Classe que não pode ser instanciada e contém membros estáticos
- virtual: Método que pode ser sobrescrito em classes derivadas
- override: Método que sobrescreve um método virtual da classe base
*/

public class Jogador
{
    public int energia = 100;
    public bool vivo = true;

    static void Main()
    {
        Jogador j1 = new Jogador();
        Jogador j2 = new Jogador();
        Jogador j3 = new Jogador();

        Console.WriteLine("Energia do jogador 1: " + j1.energia);
        
        //Alterando a energia do jogador 1
        j1.energia = 50;
        Console.WriteLine("Energia do jogador 1 após alteração: " + j1.energia);

        //Cada jogador é independente
        Console.WriteLine("Energia do jogador 2: " + j2.energia);
        Console.WriteLine("Energia do jogador 3: " + j3.energia);

    }

}