// agregação

// a parte e o todo são independentes, ou seja, a parte pode existir sem um todo
Professor prof1 = new("Carlos", "Química");
Professor prof2 = new("Jose", "Química");
Professor prof3 = new("Antonio", "Química");
Professor prof4 = new("Percival", "Matemática");

Departamento dep1 = new("Exatas");

dep1.IncluirProfessores(prof1);
dep1.IncluirProfessores(prof4);

dep1.ListaProfessores();

Console.ReadKey();

public class Professor
{
    public string? Nome { get; set; }
    public string? Disciplina { get; set; }
    public Professor(string? nome, string? disciplina)
    {
        Nome = nome;
        Disciplina = disciplina;
    }
}

public class Departamento
{
    public string? Nome { get; set; }
    private List<Professor> professores { get; set; }
    public Departamento(string? nome)
    {
        Nome = nome;
        professores = new List<Professor>();
    }
    public void IncluirProfessores(Professor professor)
    {
        professores?.Add(professor);
    }
    public void ListaProfessores()
    {
        Console.WriteLine($"\nDepartamento de: {Nome}\n");

        foreach(var prof in professores)
        {
            Console.WriteLine($"{prof.Nome} - {prof.Disciplina}");
        }
    }
}
