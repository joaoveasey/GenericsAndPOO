// o operador AS é usado para realizar a conversão de tipos de referência ou tipos anuláveis compatíveis
// este operador retorna o objeto quando ele é comparável retorna o objeto quando ele é compatível com o tipo dado e retorna null se a conversão não for possível
// ao realizar um downcasting ele avalia o resultado par null ao invés de lançar uma exceção (InvalidCastException) caso não seja possível realizá-la


// o operador IS é um operador booleano, que serve para comparar tipos
// retorna true se o objeto for do mesmo tipo, caso contrário, retorna false (retorna false para tipos nulos tb)

//------exemplo de uso AS:

Object carroObj = new Carro();


var x = carroObj as string; //usando o operador as, se gerar uma exception retornará null

if (x != null)
{
    Console.WriteLine("Converte obj em string");
}
else
{
    Console.WriteLine("Não foi possível converter x é null");
}

//------exemplo de uso IS:

//Circulo circulo = new Circulo();
//Forma forma = circulo;

//if(forma is Circulo) //verifica com o operador IS se forma e circulo são compatíveis
//{
//  Console.WriteLine("Converteu Forma para Círculo\n");
//
//  ((Circulo)forma).PintarCirculo();
//}
//else
//{
//  Console.WriteLine("Operação de downcasting não pode ser feita");
//}

Console.ReadKey();

class Carro { }

