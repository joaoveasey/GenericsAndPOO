Console.WriteLine("Herança - Conceito e Sintaxe\n");

//herança é um conceito no qual uma classe (conhecida como classe derivada ou subclasse) pode adquirir propriedades e métodos de outra classe (conhecida como classe base ou superclasse)

//a classe base é capaz de reutilizar código, assim, evitando duplicação de código e permitindo a especialização de comportamentos

//sintaxe:

//class nome_da_classe_derivada : nome_da_classe_base
//{
//    //declaração dos membros da classe derivada
//}

//benefícios da herança: 
//- reutilização de código;
//- especialização de classes;
//- extensibilidade de comportamentos sem afetar outras partes do código;
//- encapsulamento.

//desvantagens da herança:
//- acoplamento forte;
//- herança profunda pode se tornar difícil de entender e manter o código;
//- herança com reutilização excessiva;
//- rigidez do design faz com que uma pequena alteração em uma classe se torne um ajuste extensivo em todas as classes derivadas

Funcionario funci = new();
funci.Nome = "José";
funci.Email = "jose@gmail";
funci.Empresa = "Google Inc.";
funci.Salario = 9000;

Console.WriteLine("Funcionário");
Console.WriteLine(funci.Empresa);
Console.WriteLine(funci.Salario);
funci.Identificar();



Aluno aluno = new();
aluno.Nome = "João";
aluno.Email = "joao@gmail";
aluno.Curso = "Desenvolvimento de Software";
aluno.Nota = 9;

Console.WriteLine("\nAluno");
Console.WriteLine(aluno.Curso);
Console.WriteLine(aluno.Nota);
aluno.Identificar();

Console.ReadKey();


//classe pai Pessoa
public class Pessoa
{
    public string? Nome { get; set; }   
    public string? Email { get; set; }
    public void Identificar()
    {
        Console.WriteLine($"{Nome} - {Email}\n");
    }
}

//classes filhas de Pessoa
public class Funcionario : Pessoa
{
    public string? Empresa { get; set; }
    public decimal Salario { get; set; }
}

public class Aluno : Pessoa
{
    public string? Curso { get; set; }
    public int Nota { get; set; }
}