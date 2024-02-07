//criando um sort dictionary
var brics = new SortedDictionary<int, string>()
{
    {20, "Brasil" },
    {10, "China" },
    {40, "India" },
    {30, "URSS" }
};

//add um novo elemento
if (brics.ContainsKey(70))
{
    Console.WriteLine("Chave já existe");
}
else
{
    brics.Add(70, "Africa");
}

//qtd de elementos
Console.WriteLine(brics.Count());

//acessando elemento pela chave 
Console.WriteLine(brics[20]);

//removendo elemento pela chave
brics.Remove(10);

//verificando se um valor existe
Console.WriteLine(brics.ContainsValue("URSS")); //--> true ou false

//obtendo o valor de uma chave
if(brics.TryGetValue(30, out string? valor))
{
    Console.WriteLine(valor);
}
else Console.WriteLine("chave não existe");

//percorrendo a coleção
foreach(var pais in brics)
{
    Console.WriteLine($"{pais.Key} - {pais.Value}");
}

Console.ReadKey();