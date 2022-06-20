# ORIENTAÇÃO A OBJETOS

- `.Count()` é para contar elementos de uma IEnumerable\<T>, Lista ou ArrayList.
- `Length` é para Array.
- `Rank` é para denotar o número de dimensões de um array.


## Método estático

Funcional somente dentro da classe. Não posso chamar um método não-estático dentro de um método estático. Pode ser chamada sem instanciar um objeto.

São métodos que podem ser chamados diretamente da classe, sem precisar criar um objeto para isso.

A palavra chave `static` faz com que os métodos da classe estejam associados à própria classe e não a um objeto (instância).

Algumas características das classes estáticas:

1. Uma classe estática não pode ser instanciada;
2. Classe estática pode ter somente membros estáticos;
3. Um Membro estático da classe pode ser acessado pelo próprio nome da classe;
4. Uma Classe estática é *sealed*. Dessa forma uma classe estática não pode ser herdada;
5. Uma Classe estática contém apenas os construtores estáticos;
6. Uma Classe estática não pode ter construtores de instância;
7. Uma Classe estática só pode ser herdada a partir de objetos da classe;
8. Uma Classe estática possui a palavra-chave static como modificador;
9. Os Construtores estáticos da classe estática são chamados apenas uma vez;
10. Uma Classe estática possui somente construtores privados;


## Escopo de variável

Uma variável é válida, ou seja, você pode acessar se você estiver dentro do escopo dela.


## Método Construtor

Chamado "construtor" porque serve de molde para "construir" objetos.

Uma classe pode não ter construtores (incomum), ter apenas um ou ter mais de um.

Quando há mais de um construtor, ele identifica o correto através da quantidade de parâmetros passados.

**Sempre** que uma classe ou struct é criada, o construtor é chamado.

Uma classe ou struct podem ter vários construtores que usam argumentos (atributos e métodos) diferentes.

Os construtores permitem que o programador defina valores padrão, limite a instanciação e grave códigos flexíveis e fáceis de ler.

São, simplificadamente, o "título" ou "etiqueta" das informações.

```csharp
public class Person {
    private string last; //atributo
    private string first; //atributo

    public Person (string lastName, string first) { //método construtor
        last = lastName;
        this.first = first; //se usar o "this", pode usar o mesmo nome no parâmetro
    }

   // Restante do código de implementação da classe vai daqui em diante.
}
```

### This

O "this" é um coringa que será substituído pelo objeto que está chamando o método:

```csharp
public static void main(String[] args) { //método principal
    objeto.metodo(); //objeto chamando o método metodo()
}

void metodo() { //método de uma classe
    this.identificador = true; //this será substituído por objeto
    //Logo, o identicador do objeto receberá 'true'
}
```


### Visibilidade de objetos:

- `+`: Público. Classe atual e qualquer outra pode utilizar.
- `-`: Privado. Somente a classe atual pode utilizar.
- `#`: Protegido. Somente classe atual e classes-filhas podem utilizar.


### Diagrama de Classes: Classe

```
    +----------------------+
    |     NomeDaClasse     |    //Classe começa com letra maiúscula
    +----------------------+
    |     + atributos      |
    |     - atributos      |    //atributos começam com minúscula
    |     # atributos      |
    +----------------------+
    | + metodoconstrutor() |
    |     # metodos()      |    //métodos começam com minúsculas e são seguidos de parênteses
    |     - metodos()      |
    +----------------------+
```

> Diagrama de Classe é uma UML (Linguagem de Modelagem Unificada)
