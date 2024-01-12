Console.WriteLine("Herança - Modificador Sealed");

//o modificador sealed impede que outras classes herdem dela 

//sintaxe:

//sealed class MinhaClasseSealed
//{

//}

//também podemos usar o modificador sealed em métodos ou propriedades que substitui um método ou propriedade virtual em uma classe base.
//com isso você permite que classes sejam derivadas de sua classe e evita que outros devs que estejam usando suas classes substituam métodos e propriedades virtuais específicos.

Cliente cliente = new();

//cliente.Nome = "José";
cliente.ExibirNome();


Console.ReadKey();

sealed class Pessoa
{
    public string Nome { get; set; }
    public void ExibirNome()
    {
        Console.WriteLine($"Meu nome é {Nome}");
    }
}

class Cliente// : Pessoa
{
    public void ExibirNome()
    {
        //Console.WriteLine($"Meu nome é {Nome} e sou cliente");
    }
}

class ClasseBase
{
    protected virtual void Metodo1()
    {
        Console.WriteLine("ClasseBase.Metodo1");
    }
    protected virtual void Metodo2()
    {
        Console.WriteLine("ClasseBase.Metodo2");
    }
}

class Classe1 : ClasseBase
{
    sealed protected override void Metodo1()
    {
        Console.WriteLine("ClasseBase.Metodo1");
    }
    protected override void Metodo2()
    {
        Console.WriteLine("ClasseBase.Metodo2");
    }
}

class CLasse2 : Classe1
{
    //protected override void Metodo1()  ==> nesse caso não podemos sobrescrever esse método por estar como sealed na Classe1
    //{
    //    Console.WriteLine("ClasseBase.Metodo1");
    //}
    protected override void Metodo2()
    {
        Console.WriteLine("ClasseBase.Metodo2");
    }
}