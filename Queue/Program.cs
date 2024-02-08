// métodos e propriedades:

// count -> retorna o total de itens na fila
// enqueue -> inclui um item no final da fila
// dequeue -> retorna o item do início e remove da lista 
// peek -> retorna o item do início sem removê-lo
// clear -> limpa os elementos da fila
// contains -> verifica se um elemento existe na fila

// criação:

Queue<string> diasSemana = new Queue<string> ();
diasSemana.Enqueue("Segunda");

int[] array = { 1, 2, 3 };
Queue<int> queue = new Queue<int> (array);

var impares = new Queue<int> (3);



Console.ReadKey();