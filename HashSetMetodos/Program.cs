
var timesSP = new HashSet<string>(){ "Santos", "São Paulo", "Palmeiras"};

var timesRJ = new HashSet<string>(){"Vasco", "Flamengo", "Fluminense"};

var timesBA = new HashSet<string>() { "Juazeiro", "Bahia", "Vitória" };

var timesMundiais = new HashSet<string>(){ "Palmeiras", "Vasco", "Santos", "São Paulo"};

//if (!timesSP.Contains("Corinthians"))
//{
//    timesSP.Add("Corinthians");
//}

// -------------analisa de os elementos

//if (timesSP.IsSubsetOf(timesMundiais))
//{
//    Console.WriteLine("timesSP é um subconjunto de timesMundiais");
//}

//if (timesMundiais.IsSupersetOf(timesSP))
//{
//    Console.WriteLine("timesMundiais é um superconjunto de timesSP");
//}

//if (timesRJ.Overlaps(timesMundiais))
//{
//    Console.WriteLine("Pelo menos um time do RJ está no timesMundiais");
//}

//if (!timesSP.SetEquals(timesRJ))
//{
//    Console.WriteLine("timesSP e timesRj não contém os mesmos elementos");
//}

// ------------métodos de junção de conjuntos

//timesSP.UnionWith(timesRJ);
//timesSP.UnionWith(timesBA);

//ExibirColecao(timesSP);

//Console.WriteLine("\ntimes ordenados: \n");

//var todosTimes= new SortedSet<string>(timesSP);

//ExibirColecao(todosTimes);

// -----------interseção de dois hashset<T>

//timesSP.IntersectWith(timesMundiais);
//ExibirColecao(timesSP);

// -----------diferença de valores entre dois hashset<T>

//timesMundiais.ExceptWith(timesSP);
//ExibirColecao(timesMundiais);

timesMundiais.Clear();
ExibirColecao(timesMundiais);

Console.ReadKey();

static void ExibirColecao<T>(IEnumerable<T> colecao)
{
    foreach (var item in colecao)
    {
        Console.WriteLine($"{item} ");
    }
}