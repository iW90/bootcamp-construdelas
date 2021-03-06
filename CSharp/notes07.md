# ORIENTAÇÃO A OBJETOS

## Enumeradores

Para o caso de haver valores pré-definidos, cria-se equivalentes numéricos para tornar mais rápida a comparação (já que compara números ao invés da string).

```csharp
enum Estacao {
    Primavera //valor 0
    Verao //valor 1
    Outono //valor 2
    Inverno //valor 3
}
```

## Namespaces

É uma forma de organizar um espaço com classes relacionadas dentro. Pode ser declarado usando `{}`, inserindo-se todas as classes dentro, ou pode declarar para todo o documento.

```csharp
namespace NomeDoNameSpace;
        //ou
namespace NomeDoNameSpace { class{} e etc. }
```

E para usar o namespace em outro lugar, importa-se da mesma forma que bibliotecas:

```csharp
using NomeDoNameSpace;
```

Ou então é preciso chamar antes da classe:

```csharp
NomeDoNameSpace.Class.metodo
```

Caso seja declarado o mesmo Namespace em outro arquivo.cs, é possível continuar utilizando os recursos que estiverem no mesmo em outro arquivo2.cs


## Tipos de Class

* `partial`: Divide a classe em dois arquivos. Útil para arquivos muito grandes.
* `sealed`: Não pode ser herdada.
* `static`: Para constantes. Não pode criar novos objetos ("new", "this"), só pode ser chamado.
* `abstract`: Não permite criar novos objetos ("new"). Serve apenas para herdar outra classe. Também significa que o código não será desenvolvido ali dentro (ex.:  métodos em interfaces), mas sim em outro lugar (ex.:  métodos em classes).
* `override`: Usado para sobrescrever o método virtual.
* `virtual`: Permite que override o sobrescreva.
* `interface`: Similar a abstract, mas não pode conter atributos. Fala sobre métodos e propriedades.