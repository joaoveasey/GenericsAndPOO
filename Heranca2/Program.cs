Console.WriteLine("Herança - Construtores");

Aluno aluno = new Aluno();

Console.ReadKey();

class Pessoa
{
    public Pessoa()
    {
        Console.WriteLine("Construtor Classe Pessoa");
    }
    public Pessoa(string nome)
    {
        Console.WriteLine("Construtor Classe Aluno com parâmetro");
    }
}

class Aluno : Pessoa
{
    public Aluno() : base() //invoca o construtor SEM parâmetros da classe base
    {
        Console.WriteLine("Construtor Classe Aluno");
    }
    public Aluno(string nome) : base(nome) //invoca o construtor COM parâmetros da classe base
    {
        Console.WriteLine("Construtor Classe Aluno com parâmetro");
    }
}