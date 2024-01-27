// herança x composição - exemplo

ComportamentoAndar andar = new ComportamentoAndar();
ComportamentoNadar nadar = new ComportamentoNadar();

Homem homem = new(andar);
homem.Locomocao();

Macaco macaco = new(andar);
macaco.Locomocao();

Sardinha sardinha = new(nadar);
sardinha.Locomocao();

Console.ReadKey();

public class Animal
{
    public int Idade { get; set; }
    public void Comer() { }
    public void Dormir() { }
}

public class ComportamentoAndar
{
    public void Andar()
    {
        Console.WriteLine("Andando....");
    }  
}

public class ComportamentoNadar
{
    public void Nadar()
    {
        Console.WriteLine("Nadando....");
    }
}

public class Homem : Animal
{
    private readonly ComportamentoAndar _comportamentoAndar;

    public Homem(ComportamentoAndar comportamentoAndar)
    {
        _comportamentoAndar = comportamentoAndar;
    }

    public void Locomocao()
    {
        Console.WriteLine(nameof(Homem));
        _comportamentoAndar.Andar();
    }
}

public class Macaco : Animal
{
    private readonly ComportamentoAndar _comportamentoAndar;

    public Macaco (ComportamentoAndar comportamentoAndar)
    {
        _comportamentoAndar = comportamentoAndar;
    }

    public void Locomocao()
    {
        Console.WriteLine(nameof(Macaco));
        _comportamentoAndar.Andar();
    }
}

public class Sardinha : Animal
{
    private readonly ComportamentoNadar _comportamentoNadar;

    public Sardinha(ComportamentoNadar comportamentoNadar)
    {
        _comportamentoNadar = comportamentoNadar;
    }

    public void Locomocao()
    {
        Console.WriteLine(nameof(Sardinha));
        _comportamentoNadar.Nadar();
    }
}
