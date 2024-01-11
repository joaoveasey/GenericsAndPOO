Console.WriteLine("Herança - Modificador New");

//esse modificador serve para quando criarmos um membro de mesmo nome na classe Pai e na classe Filha, para isso adicionamos o modificador new no membro da classe filha
//para que a compilador saiba que a gente está querendo realmente ocultar o membro da classe Pai.

Console.ReadKey();

public class Pessoa
{
    public string? Nome { get; set; }
    public string Saudacao() => $"Oi, seu nome é {Nome}";
}

public class Aluno : Pessoa
{
    public string? Curso { get; set; }
    public new string Saudacao() => $"Oi, aluno {Nome} do curso {Curso}"; 
    //=> acima utilizamos o "public new string Saudacao()" para identificar que sabemos que repetimos o membro e queremos ocultar o da classe Pai (Pessoa).
}