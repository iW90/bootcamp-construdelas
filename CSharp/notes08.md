# ORIENTAÇÃO A OBJETOS - REFERENTE À AULA 08

## Construtores:

Uma classe pode não ter construtores, ter apenas um ou mais.

Quando há mais de um construtor, ele identifica o correto através da quantidade de parâmetros passados.


## Método estático:

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


## Escopo de variável:

Uma variável é válida, ou seja, você pode acessar se você estiver dentro do escopo dela.