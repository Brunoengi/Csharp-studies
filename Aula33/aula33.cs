//Diferença entre Private e Public

using System;

class Jogador
{
    public int energia;
    private string nome;

    public Jogador(int energia, string nome)
    {
        this.energia = energia;
        this.nome = nome;
    }

    public string getNome(){
        return this.nome;
    }

    public void setNome(string nome)
    {
        this.nome = nome;
    }


}



class Aula33
{
    static void Main()
    {
        Jogador j1 = new Jogador(20,"Caio");
        Console.WriteLine("energia = {0}", j1.energia);

        //Por ser public pode alterar diretamente
        j1.energia = 100;
        Console.WriteLine("energia = {0}", j1.energia);

        //nome é private e não pode ser alterado diretamente
        //Vamos alterar utilizando métodos

        j1.setNome("Carlos");
        Console.WriteLine("nome = {0}", j1.getNome());
    }
}