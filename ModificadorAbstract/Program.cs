// o modificador abstract indica que o recurso que está sendo modificado tem uma implementação ausente ou incompleta
// pode ser usado com classes, métodos, propriedades, indexadores e eventos
// ao usar o abstract indicamos que a classe destina-se apenas a ser uma classe base de outras classes, não podendo ser instanciada.


using System.ComponentModel;

Console.ReadKey();

public abstract class Forma //a classe base pode possuir métodos comuns e métodos abstratos. / não pode ser instanciada, mas pode ser herdada.
{
    public double Lado { get; set; }
    public double Area { get; set; }
    public double Perimetro { get; set; }

    //método comum
    public void Desenhar()
    { }

    //método abstrato => precisa ser instanciado obrigatoriamente nas classes derivadas de Forma
    public abstract double CalcularArea();
    public abstract double CalcularPerimetro();
}

public class Quadrado : Forma
{
    public override double CalcularArea()
    {
        this.Area = Lado * Lado;
        return this.Area;
    }

    public override double CalcularPerimetro()
    {
        this.Perimetro = 4 * Lado;
        return this.Perimetro;
    }
}