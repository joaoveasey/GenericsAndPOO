//Add(TKey key, TValue value):
//adiciona um par de chave/valor ao dicionário.

//Remove(TKey key):
//remove a entrada correspondente à chave especificada do dicionário, se existir.

//ContainsKey(TKey key):
//verifica se o dicionário contém uma chave específica.

//ContainsValue(TValue value):
//verifica se o dicionário contém um valor específico.

//Clear():
//remove todos os pares chave/valor do dicionário.

//Count:
//retorna o número de pares chave/valor no dicionário.

//TryGetValue(TKey key, out TValue value):
//tenta obter o valor associado à chave especificada. Retorna true se a chave existir, false caso contrário.

//Keys:
//retorna uma coleção contendo as chaves no dicionário.

//Values:
//retorna uma coleção contendo os valores no dicionário.

//GetEnumerator():
//retorna um enumerador que itera pelos pares chave/valor no dicionário.

Dictionary <int,int> dic1 = new Dictionary<int, int> ();
var dic2 = new Dictionary<int ,int> ();
dic2.Add(2, 200);
dic2.Add(4, 400);
dic2.Add(3, 400);


var dic3 = new Dictionary<int, int>()
{
    {1,100 },
    {2,200 },
    {3,200 }
};

try
{
    dic3.Add(2, 232);
}
catch(Exception ex)
{
    Console.WriteLine (ex.Message);
    Console.WriteLine (ex.ToString());
}