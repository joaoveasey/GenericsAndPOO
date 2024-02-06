//Generics



// sintaxe: nomeTipo<T>

// public class ClasseGeneric<T> ou <T1,T2>

//{

//    //código

//}



//posso add uma restrição, exemplo: NomeTipo<T> where T: struct



// benefícios:

// - reutilização de código;

// - segurança do tipo (type safety);

// - desempenho (evita operações de boxing e unboxing).



Teste teste = new Teste();



int i1 = 10;

int i2 = 10;



float f1 = 10;

float f2 = 10;



string s1 = "10";

string s2 = "10";



teste.Comparar(i1, i2);

teste.Comparar(f1, f2);

teste.Comparar(s1, s2);



Console.ReadKey();



public class Teste

{

    public void Comparar<T1, T2>(T1 p1, T2 p2)

    {



        var resultado = p1.Equals(p2);

        Console.WriteLine($"Os tipos {p1.GetType()} e {p2.GetType()}");

        Console.WriteLine($"{p1} é igual a {p2}? {resultado}\n");

    }

    //public void Comparar(int p1, int p2)

    //{

    //    var resultado = p1.Equals(p2);

    //    Console.WriteLine($"{p1} é igual a {p2}? {resultado}");

    //}

    //public void Comparar(float p1, float p2)

    //{

    //    var resultado = p1.Equals(p2);

    //    Console.WriteLine($"{p1} é igual a {p2}? {resultado}");

    //}

    //public void Comparar(string p1, string p2)

    //{

    //    var resultado = p1.Equals(p2);

    //    Console.WriteLine($"{p1} é igual a {p2}? {resultado}");

    //}

}