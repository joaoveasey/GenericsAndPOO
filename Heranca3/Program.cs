Console.WriteLine("Herança - Classe Object");

//toda classe é derivada da classe Object, e, a classe Object não deriva de nenhuma classe; ou seja ela é a classe Pai de todas as classes.
//os métodos definidos na classe Object estão disponíveis em todos os objetod do sistema e as classes derivadas podem substituir alguns desses métodos:

//- Equals: suporta comparação entre objetos;
//- GetHashCode: gera um hash para o objeto;
//- ToString: retorna a representação do objeto como uma string;
//- GetType: retorna informação sobre o tipo.

Nada nada = new();

//nada. => herda de Object todos os 4 métodos (GetHashCode,ToString,GetType e Equals)

Console.ReadKey();

public class Nada
{

}

//public class Classe1
//{

//}
//public class Classe2
//{

//}
//public class ClasseDerivada : Classe1 
//{

//}