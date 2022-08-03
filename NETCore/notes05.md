# ANOTAÇÕES API

## ORM (Object Relational Mapping)

É um framework intermediário que fica entre a aplicação e o banco de dados, então, sempre que for preciso algum registro do banco, ele mapeia a tabela para a entidade na aplicação. Em outras palavras, possibilita o mapeamento de classes do projeto com as tabelas do banco de dados.

Em .NET há outros tipos de ORM, mas será usado o EF Core no Desafio 3.


### EF Core  (Entity Framework Core)

Ele é uma melhoria do ADO.NET que dá ao desenvolvedor um mecanismo automatizado para acessar e gravar dados no banco de dados.

Podemos trabalhar com o EF Core de duas maneiras: 

- Database-First: Onde se desenvolve primeiro a estrutura do Banco de Dados e depois domínio e contexto.
    - Modelo limitado por não ter suporte design do BD.
- Code-first: Onde se constrói primeiro as entidades, e a partir delas o Banco de Dados.

O EF Core faz o mapeamento de nossas classes através de métodos de extensão ou data annotations (marçaões nas classes que indicam que aquela classe é uma tabela do banco).

Executando o EF:

```
dotnet ef migrations add NomeTabela -p .\Diretorio.csproj
```
```
dotnet ef database update
```


## Data Annotations (Anotações de Dados)

São um conjunto de atributos que permitem realizar a configuração e a validação de nossos modelos. São uma espécie de tag, sinalizadas entre colchetes `[AtributoDaAnnotation]`, e que são colocadas sobre uma classe ou uma propriedade para especificar que estas estarão agora sujeitas às regras ou funcionalidades da DataAnnotation citada. As Data Annotations sobrescrevem outras convenções, e também devem ser referenciadas no início do arquivo.

Atributos disponívels pelo `System.ComponentModel.DataAnnotations`:

- Key
- TimeStamp
- ConcurrencyCheck
- Required
- MaxLength
- StringLength

Modelo:

```csharp
using System.ComponentModel.DataAnnotations; //deve ser referenciado no início do arquivo
using System.ComponentModel.DataAnnotations.Schema; //outra Data Annotation

[Table("NewUsers")] //atributo Table aplicado à classe, e que mapeia para a tabela NovosProdutos
public class User
{
	[Key] //atributo aplicado à propriedade Id, informando que Id agora é uma chave primária
	[Required] //é possível mapear mais de um atributo
	public int Id { get; set }
}
```


### Model Bindings

Trata-se de um DataAnnotation que define os métodos para passar os parâmetros à requisição.

- **\[FromQuery]**: Funciona como um filtro, passando-se parâmetros pela URL (via get).
- **\[FromRoute]**: Os parâmetros são passados pela rota na url (via get).
- **\[FromForm]**: Obtém valores de campos de formulário postados (via post).
- **\[FromBody]**: Obtém valores do corpo da solicitação, normalmente no formato JSON (via post).
- **\[FromHeader]**: Obtém valores de cabeçalhos HTTP.
- **\[FromServices]**: Injeta os valores usando a injeção de dependência.
