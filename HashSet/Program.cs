
//criando coleção de hashset com itens

var numeros = new HashSet<int>() { 1, 2, 3, 4, 5 };

var frutas = new HashSet<string>() { "uva", "banana", "pera" };

HashSet<int> pares = new HashSet<int>();

for (int i = 0; i < 6; i++)
{
    pares.Add(i* 2);
}

//construtor usando IEnumerable
var list1 = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
var conjunto = new HashSet<int>(list1);

var list2 = new List<string> { "uva", "banana", "pera" };
HashSet<string> minhasFrutas = new HashSet<string>(list2);

var impares = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
HashSet<int> meuHashSet = new HashSet<int>(impares);

Console.ReadKey();