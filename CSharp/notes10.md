# ORIENTAÇÃO A OBJETOS - REFERENTE À AULA 10

## Polimorfismo

## Abstração

## Interface

Uma interface contém definições para um grupo de funcionalidades de uma class ou struct. É como uma classe base abstrata com apenas membros abstratos. Contém apenas as assinaturas de métodos, propriedades, eventos e indexadores.

Uma classe ou struct que implementa a interface deve implementar todos os seus membros.

Com a interface também é possível herdar outra interface:

```csharp
interface IExemplo {
    //bloco de código
}

interface IExemplo2 : IExemplo {
    //bloco de código
}
```


## Hackerranks

- [Desafio 03](https://www.hackerrank.com/challenges/apple-and-orange/problem?isFullScreen=true)
- [Desafio 04](https://www.hackerrank.com/challenges/grading/problem?isFullScreen=true)
