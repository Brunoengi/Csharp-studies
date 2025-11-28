using System;

// Quando eu declaro uma classe como static eu não posso instanciar um objeto dela, não permite construtures, nem destrutores
// Se a classe for static, todos os seus membros também devem ser static
// Um classe não static pode conter membros static e não static
static public class Jogador
{
    static public int energia;
    static public bool vivo;
    static public string nome;

    static public void Iniciar(string n )
    {
        energia = 100;
        vivo = true;
        nome = n;
    }

}

class Aula31
{
    static void Main()
    {
        Jogador.Iniciar("PlayerStatic");
        
        Console.WriteLine("Nome: " + Jogador.nome + " | Energia: " + Jogador.energia + " | Vivo: " + Jogador.vivo);
    }
}