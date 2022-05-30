# ORIENTAÇÃO A OBJETOS - REFERENTE À AULA 07

## Enum:

Para o caso de haver valores pré-definidos, cria-se equivalentes numéricos para tornar mais rápida a comparação (já que compara números ao invés da string).

```
enum Estacao {
    Primavera //valor 0
    Verao //valor 1
    Outono //valor 2
    Inverno //valor 3
}
```

## Namespace:

É uma forma de organizar um espaço com classes relacionadas dentro. Pode ser declarado usando `{}`, inserindo-se todas as classes dentro, ou pode declarar para todo o documento.

    namespace NomeDoNameSpace;
        //ou
    namespace NomeDoNameSpace { class{} e etc. }

E para usar o namespace em outro lugar, importa-se da mesma forma que bibliotecas:

    using NomeDoNameSpace;

Ou então é preciso chamar antes da classe:

    NomeDoNameSpace.Class.metodo

Caso seja declarado o mesmo Namespace em outro arquivo.cs, é possível continuar utilizando os recursos que estiverem no mesmo em outro arquivo2.cs

## Tipos de Class:

* `partial`: Divide a classe em dois arquivos. Útil para arquivos muito grandes.
* `sealed`: Não pode ser herdada.
* `static`: Para constantes. Não pode criar novos objetos ("new"), só pode ser chamado.
* `abstract`: Não permite criar novos objetos ("new"). Serve para herdar.