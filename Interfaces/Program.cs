// INTERFACE é um tipo de classe que pode conter as assinaturas de métodos, eventos, propriedades, indexadores, e, também pode conter métodos públicos e estáticos
// que contém uma implementação

// os membros da interface são públicos por padrão, e você pode especificar explicitamente modificadores de acessibilidade, como private, protected, etc.

// um membro private deve ter uma implementação padrão 

// uma interface não ode conter campos de instância, construtores de instância ou finalizadores.

// para implementar um membro de interface, o membro correspondente da classe de implementação deve ser público, não estático e ter o mesmo nome e assinatura do membro da interface

IControle d = new Demo();
d.Name = "Teste";
d.Desenhar();
d.Exibir();


Console.ReadKey();

interface IControle
{
    //public IControle() { } --> não posso fazer um construtor na interface
    //int status; --> não pode conter um campo de instância

    public string Name { get; set; }
    void Desenhar(); // nesse caso eu sou obrigado a implementar esse método na classe
    public void Exibir()
    {
        Console.WriteLine("Teste"); // nesse caso eu NÃO sou obrigado a implementar esse método na classe, por conter uma implementação
    }
}

interface IGrafico
{
    void Pintar();
}

public class Demo : IControle, IGrafico
{
    public string Name { get; set; } = string.Empty;

    public void Desenhar()
    {
        Console.WriteLine("Desenhando.....");
    }

    public void Pintar()
    {
        Console.WriteLine("Pintando.....");
    }
}