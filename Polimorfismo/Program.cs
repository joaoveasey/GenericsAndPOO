// polimorfismo = as classes derivadas de uma mesma classe base podem invocar métodos que tem a mesma assinatura mas comportamentos distintos, que são
// especializados para cada classe derivada, usando para tanto uma referência a um objeto do tipo da classe base.

using System.Net.Http.Headers;

//polimorfismo com herança : 

//var figuras = new List<Figura>
//{
//    new Triangulo(),
//    new Circulo()
//};

//foreach (var figura in figuras)
//{
//    figura.Desenhar();
//}

//Console.ReadKey();

//public class Figura
//{
//    public virtual void Desenhar()
//    {
//        Console.WriteLine("Desenhando na classe base...");
//    }
//}

//public class Circulo : Figura
//{
//    public override void Desenhar()
//    {
//        Console.WriteLine("Desenhando um círculo...");
//    }
//}

//public class Triangulo : Figura
//{
//    public override void Desenhar()
//    {
//        Console.WriteLine("Desenhando um triângulo...");
//        base.Desenhar();
//    }
//}


//polimorfismo em tempo de compilação (sobrecarga de métodos) :

Calcular calc = new();

Console.WriteLine(calc.Somar(30,40));
Console.WriteLine(calc.Somar(30,40,50));

Console.ReadKey();

public class Calcular
{
    public int Somar(int num1, int num2)
    {
        return num1+num2;   
    }

    public int Somar(int num1, int num2 , int num3)
    {
        return num1+num2 + num3;
    }
}
