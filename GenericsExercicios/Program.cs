//ex Implementar um programa que simula uma fila de impressão seguindo o seguinte roteiro:

//• Crie uma variável do tipo Queue<string> para representar a fila de impressão.

//• Crie um loop que irá executar até que a fila de impressão esteja vazia.

//• Dentro do loop, verifique se a fila de impressão não está vazia. Se não estiver vazia, remova o primeiro

//elemento da fila usando o método Dequeue() e imprima na tela que o arquivo "X" está sendo impresso.

//• Simule o tempo de impressão com um Thread.Sleep() por um período aleatório de tempo entre 1 e 5

//segundos.

//• Após simular a impressão do arquivo, imprima na tela que o arquivo "X" foi impresso com sucesso.

//• Repita os passos 3 a 5 até que a fila de impressão esteja vazia.



var filaImpressao = new Queue<string>();



filaImpressao.Enqueue("folha 1");

filaImpressao.Enqueue("folha 2");

filaImpressao.Enqueue("folha 3");

filaImpressao.Enqueue("folha 4");

filaImpressao.Enqueue("folha 5");



do

{

    if (filaImpressao.Count > 0)

    {

        Console.WriteLine($"O arquivo {filaImpressao.Peek} esta sendo impresso...");

        filaImpressao.Dequeue();

        Thread.Sleep(3000);

        Console.WriteLine("O arquivo foi impresso com sucesso!");

    }

} while (filaImpressao.Count > 0);







//2)

//Declare um método genérico chamado ReverterEImprimir em uma classe não genérica chamada Exemplo.

//O método recebe como parâmetro um array de qualquer tipo. A seguir declare três tipos diferentes de array :

//um array de int , um array de strings e um array de double

//Invoque o método duas vezes com cada array.

//Na primeira vez invoque o método com um determinado array, onde ele usa explicitamente o

//parâmetro de tipo.

//Na segunda vez, invoque o método onde o tipo é inferido.



int[] arrayInt = new int[4];

string[] arrayString = new string[4];

double[] arrayDouble = new double[4];



Exemplo arrayInt_ = new Exemplo();

Exemplo arrayString_ = new Exemplo();

Exemplo arrayDouble_ = new Exemplo();



arrayInt_.ReverterEImprimir(arrayInt);

arrayString_.ReverterEImprimir(arrayString);

arrayDouble_.ReverterEImprimir(arrayDouble);



public class Exemplo

{

    public void ReverterEImprimir<T>(T[] valor)

    {



    }

}