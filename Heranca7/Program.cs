using Heranca7;

Console.WriteLine("Tipos de Herança");

//herança simples: é o tipo de herança que há apenas uma classe base e uma classe derivada

//herança hierárquica: é o tipo de herança que existem várias classes derivadas para uma classe base

//herança multinível: quando uma classe é derivada de outra classe derivada

//herança múltipla: ocorre quando temos uma classe base e uma classe derivada que implementa uma ou mais interfaces

//upcasting e downcasting:

//o upcasting é uma forma de converter uma classe de tipo filha (derivada) para um tipo mais geral (classe base ou pai). -> operação implícita
//exemplo de UPCASTING: (sempre consigo fazer)

//PAI       recebe     FILHO   => com isso o método Desenhar() usado será o de Forma pois 
Forma circulo = new Circulo(10,20);


//o downcasting é uma forma de converter uma classe de tipo geral (base, pai) para um tipo mais específico (classe filha, derivada). -> operação explícita
//exemplo de DOWNCASTING: (nem sempre é possível realizar um downcasting)

Circulo circulo1 = new Circulo(10,10);
Forma forma = circulo1; //upcasting -> implícito

Circulo c = Circulo(forma); //downcasting -> explícito
Console.ReadKey();

public class Forma
{
  protected int xpos, ypos;

  public Forma(){}

  public Forma(xpos,ypos)
  {
    xpos = x;
    ypos = y;
  }

  public virtual void Desenhar()
  {
    Console.WriteLine($"Desenhar - Forma na posição ({xpos},{ypos})");
  }
}

public class Circulo : Forma
{
  public Circulo(){}

  public Circulo(int x, int y) : base(x,y)
  {}

  public override void Desenhar()
  {
    Console.WriteLine($"Desenhar - Círculo na posição ({xpos},{ypos})");
  }

  public void PintarCirculo()
  {
    Console.WriteLine("Pintar o círculo");
  }
}
