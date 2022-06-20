# ORIENTAÇÃO A OBJETOS

## Encapsulamento

Trata do estado e funcionalidade de um objeto, permitindo ou não o acesso por meio de funções.

- `private`: pode ser acessado somente de dentro da classe.
- `public`: pode ser acessado de qualquer lugar.
- `protected`: pode ser acessado somente dentro da classe e das classes filhas.
- `internal`: pode ser acessado de qualquer lugar dentro do mesmo assembly.

[Documentação](https://docs.microsoft.com/pt-br/dotnet/csharp/fundamentals/tutorials/oop)


### Diagrama de Classes: exemplo com interface

```
    +----------------------+
    |    <<interface>>     |
    |     NomeDaInter      |    //Interface começa com letra maiúscula
    +----------------------+
    |     + atributos      |
    |     + atributos      |    //atributos são sempre públicos
    |     + metodos()      |    //métodos são sempre públicos
    +----------------------+

    +----------------------+
    |     NomeDaClasse     |
    +----------------------+
    |     - atributos      |
    |     - atributos      |    //atributos são sempre privados
    |     - atributos      |
    +----------------------+
    | - metodoconstrutor() |    //métodos são sempre privados
    |     - metodos()      |    //métodos são sempre privados
    |    + setMetodo()     |    //métodos set são sempre públicos
    |    + getMetodo()     |    //métodos get são sempre públicos
    +----------------------+
```


## Herança

Uma classe filha pode herdar, estender ou modificar as propriedades da classe pai. A classe cujos membros são herdados é chamada de classe base. A classe que herda os membros da classe base é chamada de classe derivada. O uso dos `:` denota que está sendo usada a herança.

Utiliza-se o `: base()` para chamar o construtor da classe pai. Caso não possua um construtor, não é possível usá-lo.

Se mais de uma classe tem vários atributos em comum, abstraia-os e crie uma classe geral com eles. As demais classes com esses atributos em comum podem herdar a classe geral.

```csharp
class ClasseGeral () {
    //atributos
    //métodos
}

class SubClasse01 : ClasseGeral {
    public Construtor() : base() { //Esse construtor vai chamar o construtor da ClasseGeral
        //code block
    }

    //outros atributos
    //outros métodos
    //mas pode utilizar os métodos e atributos da ClasseGeral
}
```


### Diagrama de Classes: heranças

As subclasses vão ter seus próprios atributos/métodos além dos atributos/métodos da super classe.

```
                    +----------------------+
                    |      SuperClasse     |
                    +----------------------+
                    |     - atributosX     |
                    +----------------------+
                    | # metodoconstrutor() |
                    |     # metodos()      |
                    +----------------------+
                                |
                +—————————————————————————————+
                |                             |
    +----------------------+        +----------------------+
    |      SubClasse01     |        |      SubClasse02     |
    +----------------------+        +----------------------+
    |     - atributos      |        |     - atributos      |
    +----------------------+        +----------------------+
    | - metodoconstrutor() |        | - metodoconstrutor() |
    |     + metodos()      |        |     + metodos()      |
    +----------------------+        +----------------------+
```


## Polimorfismo

Na classe abstrata é inserido um método abstrato. Este método não tem seu código desenvolvido na classe abstrata, mas sim nas subclasses. Cada subclasse pode desenvolver este mesmo método da sua forma, obtendo resultados diferentes. Resumidamente, são várias formas de usar o mesmo método.


### Assinatura dos métodos

A quantidade e os tipos de parâmetros identificam a assinatura de cada método.

> O tipo do valor retornado não é levado em consideração.

```csharp
class ClasseGeral () {
    public abstract nomeMetodo();
}

class SubClasse01 : ClasseGeral {
    public nomeMetodo(int x) {return A};
}

class SubClasse02 : ClasseGeral {
    public nomeMetodo(string y, int z) {return B};
}
```


### Tipos de polimorfismo

- **Polimorfismo Dinâmico ou Sobreposição (overriding)**

Quando sobrescrevemos um mesmo método de uma superclasse na sua subclasse, usando a **mesma assinatura**. Em outras palavras, é a mesma assinatura em **diferentes classes**.

```csharp
class ClasseGeral () {
    public abstract nomeMetodo();
}

class SubClasse01 : ClasseGeral {
    public nomeMetodo(int x)  {return A};
}

class SubClasse02 : ClasseGeral {
    public nomeMetodo(int x)  {return B};
}
```

#### Diagrama de Classes: sobreposição

```
                    +----------------------+
                    |    ClasseAbstrata    |
                    +----------------------+
                    |     - atributos      |
                    +----------------------+
                    |  # abstract ident()  |
                    +----------------------+
                                |
                +——————————————————————————————+
                |                              |
    +----------------------+        +----------------------+
    |        Classe1       |        |        Classe2       |
    +----------------------+        +----------------------+
    |     - atributos      |        |     - atributos      |
    +----------------------+        +----------------------+
    |    + ident() {A}     |        |    + ident() {B}     |
    +----------------------+        +----------------------+
```

- **Polimorfismo Estático ou Sobrecarga (overloading)**

Quando sobrescrevemos um mesmo método de uma superclasse na sua subclasse, usando **assinaturas diferentes**. Em outras palavras, são assinaturas diferentes na **mesma classe**.

```csharp
class ClasseGeral () {
    public abstract nomeMetodo();
}

class SubClasse01 : ClasseGeral {
    public nomeMetodo(int x) {return A};

    public nomeMetodo(string y, int z) {return B};
}
```


#### Diagrama de Classes: sobrecarga

Várias formas de fazer uma mesma coisa.

```
        +----------------------+
        |    ClasseAbstrata    |
        +----------------------+
        |     - atributos      |
        +----------------------+
        |  # abstract ident()  |
        +----------------------+
                    |
                +———+
                |
    +----------------------+
    |        Classe        |
    +----------------------+
    |     - atributos      |
    +----------------------+
    |  + ident(tipo1) {A}  |
    |  + ident(tipo2) {B}  |
    +----------------------+
```