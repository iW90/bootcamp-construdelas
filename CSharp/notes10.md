# ORIENTAÇÃO A OBJETOS - REFERENTE À AULA 10

## Polimorfismo

## Abstração

## Interface

Uma interface contém definições para um grupo de funcionalidades de uma class ou struct. É como uma classe base abstrata com apenas membros abstratos. Contém apenas as assinaturas de métodos, propriedades, eventos e indexadores.

Uma classe ou struct que implementa a interface deve implementar todos os seus membros.

Com a interface também é possível desenvolver condicionais através de parâmetros:

```csharp
interface IExemplo {
    condicional: 'option1' | 'option2' | 'option3;
} //ao atribuir um valor para a condicional, só será possível escolher uma das três opções.
```


## Hackerranks

- [Desafio 03](https://www.hackerrank.com/challenges/apple-and-orange/problem?isFullScreen=true)
- [Desafio 04](https://www.hackerrank.com/challenges/grading/problem?isFullScreen=true)
