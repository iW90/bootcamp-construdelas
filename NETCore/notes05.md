# ANOTAÇÕES API

## ORM (Object Relational Mapping)

É um framework intermediário que fica entre sua aplicação e o banco de dados, então, sempre que você precisar de algum registro do banco, ele mapeia o tabela para sua entidade na aplicação. Em outras palavras, possibilita o mapeamento de classes do nosso projeto com as tabelas do banco de dados.

Em .NET há outros tipos de ORM, mas será usado o EF Core.


### EF Core  (Entity Framework Core)

Ele é uma melhoria do ADO.NET que dá ao desenvolvedor um mecanismo automatizado para acessar e gravar dados no banco de dados.

Podemos trabalhar com o EF Core de duas maneiras: 

- Database-First: Onde se desenvolve primeiro a estrutura do Banco de Dados e depois domínio e contexto.
    - Modelo limitado por não ter suporte design do BD.
- Code-first: Onde se constrói primeiro as entidades, e a partir delas o Banco de Dados.

O EF Core faz o mapeamento de nossas classes através de métodos de extensão ou data annotations (marçaões nas classes que indicam que aquela classe é uma tabela do banco).

