# ORIENTAÇÃO A OBJETOS - REFERENTE À AULA 09

- `.Count()` é para contar elementos de uma IEnumerable\<T>, Lista ou ArrayList.
- `Length` é para Array.
- `Rank` é para denotar o número de dimensões de um array.


## Herança:

Uma classe filha pode herdar, estender ou modificar as propriedades da classe pai. A classe cujos membros são herdados é chamada de classe base. A classe que herda os membros da classe base é chamada de classe derivada. O uso dos `:` denota que está sendo usada a herança.

Utiliza-se o `:base()` para chamar o construtor da classe pai. Caso não possua um construtor, não é possível usá-lo.


## Encapsulamento:

Ocultando o estado interno e a funcionalidade de um objeto e permitindo apenas o acesso por meio de um conjunto público de funções.

- `private`: pode ser acessado somente de dentro da classe.
- `public`: pode ser acessado de qualquer lugar.
- `protected`: pode ser acessado somente dentro da classe e das classes filhas.
- `internal`: pode ser acessado de qualquer lugar dentro do mesmo assembly.

[Documentação](https://docs.microsoft.com/pt-br/dotnet/csharp/fundamentals/tutorials/oop)


## Hackerranks:

[Desafio 01](https://www.hackerrank.com/challenges/birthday-cake-candles/problem?isFullScreen=true)
[Desafio 02](https://www.hackerrank.com/challenges/grading/problem?isFullScreen=true)