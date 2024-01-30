using System.Security.Cryptography.X509Certificates;

Carro carro = new(0);
carro.Abastecer(0, 10);
carro.Dirigir(10);


Console.ReadKey();
public interface IVeiculo
{
    public void Dirigir(int qtdInicialGasolina);
    public bool Abastecer(int qtdInicialGasolina, int qtdGasolina);

}

public class Carro : IVeiculo
{
    public void Dirigir(int qtdInicialGasolina) 
    {
        if(qtdInicialGasolina > 0)
        {
            Console.WriteLine("Dirigindo..");
        }
        else
        {
            Console.WriteLine("Sem gasolina..");
        }
    }
    public bool Abastecer(int qtdInicialGasolina, int qtdGasolina)
    {
        qtdInicialGasolina += qtdGasolina;
        return true;
    }
    public Carro(int qtdInicialGasolina)
    {
        
    }
}
