var alunos = new Dictionary<int, Aluno>()
{
    {1, new Aluno("Maria", 7) },
    {2, new Aluno("Eric", 8) },
    {3, new Aluno("Ana", 9) },
    {4, new Aluno("Alex", 6) },
    {5, new Aluno("Diná", 5) }
};

ExibirColecao(alunos);

do
{
    Console.WriteLine("Informe o código do aluno a ser localizado(99 para sair)");
    int codigo = Int32.Parse(Console.ReadLine());

    if(codigo == 99) 
        break;

    var resultado = alunos.ContainsKey(codigo);
    if (resultado)
    {
        Console.WriteLine("Informe a nota (1 a 10)");
        var nota = Int32.Parse(Console.ReadLine());
        alunos[codigo].Nota = nota;
    }
    else
    {
        Console.WriteLine("Aluno não localizado..");
    }

} while (true);

ExibirColecao(alunos);

Console.WriteLine("Informe o código do aluno a ser removido");
int cod = Int32.Parse(Console.ReadLine());
if (alunos.ContainsKey(cod))
{
    alunos.Remove(cod);
    Console.WriteLine("Aluno removido.");
}
else
{
    Console.WriteLine("Aluno não encontrado..");
}

ExibirColecao(alunos);

Console.WriteLine("Nova nota: ");
int novaNota = Int32.Parse(Console.ReadLine());

Console.WriteLine("Novo nome: ");
string novoNome = Console.ReadLine();

Console.WriteLine("Informe o código do aluno a ser adicionado");
int codAdd = Int32.Parse(Console.ReadLine());
if (!alunos.ContainsKey(codAdd))
{
    alunos.Add(codAdd, new Aluno (novoNome, novaNota));
    Console.WriteLine("Aluno incluído com sucesso.");
}
else
{
    Console.WriteLine("Código ja existe..");
}

ExibirColecao(alunos);

var alunosOrdenados = alunos.OrderBy(x => x.Value.Nome);

foreach (var item in alunosOrdenados)
{
    Console.WriteLine($"{item.Key} - Nome: {item.Value.Nome} | Nota: {item.Value.Nota}\n");
}

Console.ReadKey();

static void ExibirColecao(Dictionary<int, Aluno> alunos)
{
    foreach (var aluno in alunos)
    {
        Console.WriteLine($"{aluno.Key} - Nome: {aluno.Value.Nome} | Nota: {aluno.Value.Nota}\n");
    }
}

alunos.Clear();
Console.WriteLine("Fim do exercício.");

public class Aluno
{
    public Aluno(string? nome, int nota)
    {
        Nome = nome;
        Nota = nota;
    }
    public string? Nome { get; set; }
    public int Nota { get; set; }
}