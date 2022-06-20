# ORIENTAÇÃO A OBJETOS

## Interface

Uma interface contém definições para um grupo de funcionalidades de uma class ou struct. É como uma classe base abstrata com apenas membros abstratos. Contém apenas as assinaturas de métodos, propriedades, eventos e indexadores.

Uma classe ou struct que implementa a interface deve implementar todos os seus membros.


### Diagrama de Classes: Interface

```
    +----------------------+
    |    <<interface>>     |
    |     NomeDaInter      |    //Interface começa com letra maiúscula
    +----------------------+
    |     + atributos      |
    |     + atributos      |    //atributos são sempre públicos
    |     + metodos()      |    //métodos são sempre públicos e abstratos
    +----------------------+
```


## Pilares da Orientação a Objetos

- ***Abstração**: Em algumas bibliografias não é considerado um pilar, mas uma parte do encapsulamento.*
- **Encapsulamento**: Encapsular não é obrigatório, mas é uma boa prática para produzir Classes mais eficientes. O encapsulamento é uma estrutura que protege o código, e um bom objeto encapsulado possui uma interface bem definida.
    - Torna mudanças invisíveis
    - Facilita a reutilização de códigos
    - Reduzir os efeitos colaterais.
- **Herança**: 
- **Polimorfismo**: 


## Abstração

O conceito de abstração consiste em esconder os detalhes de algo, no caso, os detalhes desnecessários. Utiliza-se apenas conteúdos relevantes.

Dentro da Orientação a Objetos temos diversos conceitos de abtração, como por exemplo as interfaces e classes que escondem algo.

Um exemplo é depender de abstrações (interfaces) e não de implementações (classes). Este motivo deve-se ao fato de uma interface poder conter várias implementações, enquanto uma classe não tem essa habilidade.
