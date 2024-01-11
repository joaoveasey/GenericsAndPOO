Console.WriteLine("Herança - Virtual e Override");

Gato gato = new Gato();
gato.Nome = "Mostarda";
gato.Exibir(); //nesse caso vai exibir o ´método da classe Filha (Gato) pois criei o método "VIRTUAL" na PAI, e "OVERRIDE" na FILHA.

Cachorro cao = new Cachorro();
cao.Nome = "Theo";
cao.Exibir(); //nesse caso vai exibir o método da classe Pai (Animal) pois não criei nenhum método em Cachorro

Console.ReadKey();

public class Animal
{
    public string Nome { get; set; }
    public virtual void Exibir()
    {
        Console.WriteLine($"Olá sou {Nome}");
    }
}

public class Gato : Animal
{
    public override void Exibir()
    {
        Console.WriteLine($"Olá sou um gato, meu nome é {Nome}");
    }
}

public class Cachorro : Animal
{

}