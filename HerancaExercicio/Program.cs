Console.WriteLine("Herança - Exercício");

Cliente clienteContaCorrente = new();

clienteContaCorrente.Id = 1;
clienteContaCorrente.Nome = "João";
clienteContaCorrente.Depositar(1000);
clienteContaCorrente.Sacar(100);
clienteContaCorrente.ExibirSaldo();
clienteContaCorrente.Sacar(2000);

ContaPoupanca clienteContaPoupanca = new();

clienteContaPoupanca.Id = 1;
clienteContaPoupanca.Nome = "José";
clienteContaPoupanca.Depositar(1000);
clienteContaPoupanca.Sacar(100);
clienteContaPoupanca.ExibirSaldo();
clienteContaPoupanca.Sacar(2000);


ContaInvestimento clienteContaInvestimento = new();

clienteContaInvestimento.Id = 3;
clienteContaInvestimento.Nome = "Joca";
clienteContaInvestimento.Depositar(1000);
clienteContaInvestimento.Sacar(100);
clienteContaInvestimento.ExibirSaldo();
clienteContaInvestimento.Sacar(2000);


Console.ReadKey();

public class Cliente
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public double Saldo = 0;
    
    public virtual void Depositar(double valorDeposito)
    {
        Saldo += valorDeposito;
    }
    public virtual void Sacar(double valorSaque)
    {
        Saldo -= valorSaque;
    }
    public virtual void ExibirSaldo()
    {
        Console.WriteLine($"\nOlá {Nome}, seu saldo atual é R${Saldo}\n");
    }
}


public class ContaPoupanca : Cliente
{
    public override void Depositar(double valorDeposito)
    {
        Saldo += valorDeposito;
        double Juros = Saldo * 0.05;
        Saldo += Juros;

        Console.WriteLine($"O rendimento de Juros é {Juros} e seu novo Saldo é {Saldo}");
    }
    public override void Sacar(double valorSaque)
    {
        if (valorSaque > Saldo)
        {
            Console.WriteLine($"Você não pode ficar com saldo negativo. Seu saldo atual é {Saldo}");
        }
        else
        {
            Saldo -= valorSaque;
            Console.WriteLine($"Você sacou R${valorSaque} da sua conta poupança.\nSeu novo Saldo é R${Saldo}");
        }
    }
}

public class ContaInvestimento : Cliente
{
    public override void Depositar(double valorDeposito)
    {
        Saldo += valorDeposito;
        double Juros = Saldo * 0.09;
        Saldo += Juros;

        Console.WriteLine($"O rendimento de Juros é {Juros} e seu novo Saldo é {Saldo}");
    }
    public override void Sacar(double valorSaque)
    {
        if (valorSaque > Saldo)
        {
            //caso o valor do saque seja maior que o saldo, ocorrerá esse erro..
            Console.WriteLine($"Você não pode ficar com saldo negativo. Seu saldo atual é {Saldo}");
        }
        else
        {
            Saldo -= valorSaque;
            double Imposto = Saldo * 0.01;
            Saldo -= Imposto;

            Console.WriteLine($"Você sacou R${valorSaque} da sua conta investimento.\nO valor do Imposto foi R${Imposto} e seu novo Saldo é R${Saldo}");
        }
    }
}

