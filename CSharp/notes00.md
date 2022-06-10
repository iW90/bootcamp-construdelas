# ANOTAÇÕES EXTRAS

## ARRAYS[]

### Declarando arrays

Três exemplos:

```csharp
int[] identificador = new int[4];

int[] identificador = new int[] { 42, 13, 32};

string[] identificador = {"x", "y", "z"};
```

- Por padrão, o índice se inicia em 0.

### Percorrendo array com foreach

```csharp
foreach (int item in identificador) {
    //bloco de código
};
```

- `item` é uma variável que vai receber cada item do array.

### Array Multidimensional

```csharp
string[,] identificador = new string[4, 2]; //declaração
identificador[0, 0] = "valor"; //inserindo um valor
Console.WriteLine(identificador[0, 0]); //acessando um valor
```

Inserindo vários valores:

```csharp
int[,] matriz = new int[3,2] { //[linha, coluna]
    { 00, 01 }
    { 10, 11 }
    { 20, 21 }
};
```

#### For para matrizes

```csharp
for (int i = 0; i < matriz.GetLength(0); i++) { //linha
    for (int j = 0; j <matriz.GetLength(1); j++) { //coluna
        Console.WriteLine(matriz[i, j]);
    }
    Console.WriteLine("\n");
}
```

### Classe Array

A classe oferece vários métodos para trabalhar com arrays, incluindo ordenação.

```csharp
Array.Sort(identificadorArray); //BubbleSort
Array.Copy(identOriginal, identCopia, identOriginal.Length) //Copia um array
```

## COLEÇÕES

- `List<T>`: Lista de objetos acessada pelo índice
- `Dictionary<TKey, TValue>`: Coleção de pares chave-valor (base na key)
- `SortedList<TKey, TValue>`: Coleção de pares chave-valor (base em IComparater\<T>)
- `Queue<T>`: Coleção de objetos em fila FIFO (First In First Out)
- `Stack<T>`: Coleção de objetos em pilha LIFO (Last In First Out)

### Lista

Não é necessário declarar o tamanho da lista previamente. O tamanho é livre.

```csharp
List <string> identificador = new List<string>(); //Declaração
identificador.Add("Value1"); //adicionando um item
identificador.Add("Value2"); //adicionando outro item

Console.WriteLine(identificador[0]); //acessando um valor da mesma forma que array
```

### Dictionary

```csharp
Dictionary<string, string> identificador = new Dictionary<string, string>();
identificador.Add("Key", "Value"); //adicionando chave e valor

foreach (KeyValuePair<string, string> item in identificador) {
    Console.WriteLine($"Chave: {item.Key} e Valor: {item.Value}");
}

identificador[nomeDaKey] = "Atualização"; //atualizando um valor
```

## OPERAÇÕES LINQ (Language-Integrated Query)

É uma maneira de fazer consultas padronizadas nas coleções.

Muito similar a query (SQL), mas suas cláusulas são usadas como métodos. Ambos as formas, Query syntax ou Method syntax funcionam igualmente.

```csharp
int[] identificador = { 5, 6, 7 };

//Query syntax
IEnumerable<int> itemQuery =
    from item in identificador
    where item % 2 == 0
    orderby item
    select item;

//Method syntax
IEnumerable<int> itemQuery = identificador.Where(item => item % 2 == 0).OrderBy(n => n);

Console.WriteLine("Números pares query: " + string.Join(", ", itemQuery));
```

### Valores mínimos, máximos e médios

```csharp
nomeArray.Min();
nomeArray.Max();
nomeArray.Average();
```

===

## Rodando o Terminal no VSCode

Para habilitar a entrada de dados:

Em `.vscode > launch.json` modifique `"console": internalConsole` para `"integratedTerminal"`.