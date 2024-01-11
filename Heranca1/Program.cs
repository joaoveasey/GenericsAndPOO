Console.WriteLine("Herança - Comportamentos");

ClasseDerivada cd = new();
cd.VerificaAcesso();


Console.ReadKey();
public class ClasseDerivada : ClasseBase
{
    public void VerificaAcesso()
    {
        Public_Membro();
        Protected_Membro();
        Protected_Internal_Membro();
        Internal_Membro();
        //Private_Membro();

        //acessando a variavelPrivada da classe ClasseBase a partir da propriedade publica criada
        Console.WriteLine(acessoVariavelPrivada);
    }
}

public class ClasseBase
{
    //acessando campo private com uso das propriedades:
    private int variavelPrivada = 4; //criação do campo privado

    public int acessoVariavelPrivada //a partir dessa propriedade eu posso acessar essa variavelProvada em outra classe
    {
        get { return variavelPrivada; }
        set { variavelPrivada = value; }
    }

    public void Public_Membro()
    {
        Console.WriteLine("ClasseBase - Método Public");
    }
    protected void Protected_Membro()
    {
        Console.WriteLine("ClasseBase - Método Protected");
    }
    internal void Internal_Membro()
    {
        Console.WriteLine("ClasseBase - Método Internal");
    }
    protected internal void Protected_Internal_Membro() 
    {
        Console.WriteLine("ClasseBase - Método Protected Internal");
    }
    private void Private_Membro()
    {
        Console.WriteLine("ClasseBase - Método Private");
    }
}
