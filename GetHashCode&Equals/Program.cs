// get hash code retorna um valor inteiro (chamado código hash) com base nas informações do obj

// equals compara o objeto com outro objeto e retorna um boolean indicando se eles são iguais



//string a = "A";

//string b = "A";



//Console.WriteLine(a.Equals(b));



var pessoa1 = new Pessoa(123456, "Erica");

var pessoa2 = new Pessoa(123456, "Erica");

var pessoa3 = new Pessoa(987654, "Erica");



Console.WriteLine("pessoa 1 -> Cpf = 123456 Nome = Erica");

Console.WriteLine("pessoa 2 -> Cpf = 123456 Nome = Erica");

Console.WriteLine("pessoa 3 -> Cpf = 987654 Nome = Erica");



Console.WriteLine("pessoa 1 = " + pessoa1.GetHashCode());

Console.WriteLine("pessoa 2 = " + pessoa2.GetHashCode());

Console.WriteLine("pessoa 3 = " + pessoa3.GetHashCode());





Console.ReadKey();



public class Pessoa

{

    public int CPF { get; set; }

    public string? Nome { get; set; }

    public Pessoa(int cpf, string? nome)

    {

        CPF = cpf;

        Nome = nome;

    }



    public override bool Equals(object? obj)

    {

        if (obj == null)

            return false;

        if (obj is not Pessoa)

            return false;



        var other = (Pessoa)obj;



        return CPF.Equals(other.CPF);

    }



    public override int GetHashCode()

    {

        return CPF.GetHashCode();

    }

}