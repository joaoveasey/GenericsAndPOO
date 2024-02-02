LivroFotos livroComum = new();
Console.WriteLine(livroComum.GetNumeroPaginas());

LivroFotos livroComumComPaginas = new(24);
Console.WriteLine(livroComumComPaginas.GetNumeroPaginas());

SuperLivroFotos superLivroFotos = new();
//Console.WriteLine(superLivroFotos.GetNumeroPaginas);

Console.ReadKey();

public class LivroFotos
{
    private int numPaginas;
    public int GetNumeroPaginas()
    {
        return numPaginas;
    }
    public LivroFotos()
    {
        numPaginas = 16;
    }
    public LivroFotos(int _numPaginas)
    {
        numPaginas = _numPaginas;
    }
}

public class SuperLivroFotos
{
    private int numPaginas;
    public int GetNumeroPaginas()
    {
        return numPaginas;
    }
    public SuperLivroFotos()
    {
        numPaginas = 64;
    }
}