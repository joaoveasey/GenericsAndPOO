// métodos:

// push() -> inclui um elemento no topo da pilha
// pop() -> remove e retorna o elemento do topo da pilha
// peek() -> retorna o elemento do topo sem removê-lo
// contains() -> verifica se existe (true/false)
// clear() -> remove todos os elementos da pilha
// toarray() -> copia a pilha em um novo array unidimensional

// criação
Stack<int> numeros = new Stack<int>();
numeros.Push(1);

int[] array1 = new int[] { 1, 2, 3, 4 };
Stack<int> pilha1 = new Stack<int>(array1);   

var impares = new Stack<int>(3);
impares.Push(1);

// usando o toarray()
var copia = new Stack<int>(numeros.ToArray());

Console.ReadKey();