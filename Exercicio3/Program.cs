//Usando os conceitos de polimorfismo escreva um programa para calcular a área do
//Quadrado, Triângulo e do Circulo
//Fórmulas das áreas
//- Quadrado -> A = lado * lado
//- Triângulo -> A = (base * altura)/2
//- Circulo -> A = Pi * raio * raio ou A = π . r²

Quadrado quadrado = new(2);
quadrado.MostraArea();

Triangulo triangulo = new(4, 6);
triangulo.MostraArea();

Circulo circulo = new(3);
circulo.MostraArea();

Console.ReadKey();

public class Forma
{
    public int area;
    public virtual void MostraArea()
    {
        Console.WriteLine(area);
    }
}

public class Quadrado : Forma
{
    public Quadrado(int lado)
    {
        area = lado * lado;
    }
    public override void MostraArea()
    {
        Console.WriteLine(area);
    }
}

public class Triangulo : Forma
{
    public Triangulo(int _base, int altura)
    {
        area = (_base * altura) / 2;
    }
    public override void MostraArea()
    {
        Console.WriteLine(area);
    }
}

public class Circulo : Forma
{
    public Circulo(int raio)
    {
        area = 3 * raio * raio;
    }
    public override void MostraArea()
    {
        Console.WriteLine(area);
    }
}