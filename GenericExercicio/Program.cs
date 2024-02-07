ClasseGenerica<int> objInt = new ClasseGenerica<int>();

objInt.Adicionar(10);

objInt.Adicionar(20);

objInt.Adicionar(30);

objInt.Adicionar(40);

objInt.Adicionar(50);



for (int i = 0; i < 5; i++)

{

    Console.WriteLine(objInt[i]);

}



Console.ReadKey();



public class ClasseGenerica<T>

{

    T[] obj = new T[5];

    int contador = 0;



    public void Adicionar(T item)

    {

        if (contador < 5)

        {

            obj[contador] = item;

        }

        contador++;

    }



    public T this[int index]

    {

        get { return obj[index]; }

        set { obj[index] = value; }

    }

}