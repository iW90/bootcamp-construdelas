# ORIENTAÇÃO A OBJETOS - REFERENTE À AULA 06

> Apenas uma unidade de compilação pode ter instruções de nível superior.

Ou seja, declarações fora de um objeto só pode existir na Main, e não nos demais arquivos.cs


## Classe

Classe é uma forma de organizar os conteúdos de um código, separando por "família".

Dentro da classe, podemos criar Os atribtutos (variáveis) e métodos (funções) que servirão de molde para criação de objetos.

Toda classe é em camelCase e iniciada por letra maiúscula.

```csharp
class NomeDaClasse {
    //atributos são as variáveis
    int identificador1;
    int identificador2;

    //funções são os métodos, que recebem um tipo ou void
    void metodo() {
        //código para montar o novo objeto
    }
}
```


## Objeto

Sempre que 'instanciarmos' um objeto (utiliza-se o "new" relacionando a uma classe), estaremos criando um novo objeto de acordo com as características da classe referenciada.

```csharp
NomeDaClasse objeto = new NomeDaClasse(); //NomeDaClasse funciona como um tipo.
Integer num = new Integer(3); //Integer é classe (Wrapper Class)
```


## Diferença Struct x Class:

* Struct passa por valor;

* Class passa por referência;


## Método Construtor

Chamado "construtor" porque serve de molde para "construir" objetos.

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


## UML - Linguagem de Modelagem Unificada

### Diagrama de Classes

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

### Visibilidade de objetos:

- `+`: Público.Classe atual e qualquer outra pode utilizar.
- `-`: Privado. Somente a classe atual pode utilizar.
- `#`: Protegido. Somente classe atual e classes-filhas podem utilizar.

