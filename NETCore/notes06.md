# AULA DE REFORÇO E OUTROS MATERIAIS (baguncinha)

Esquema de pastas:

- NomeDoProjeto.**API || App**: Faz a comunicação com o frontend.
	- NomeDoProjeto.**API**: PROJETO, não pasta. Onde configuraremos requisições HTTP ou HTTPS (CRUD).
	- **Controller**: Os arquivos.cs dentro desta pasta precisam terminar com "Controller". São arquivos que respondem às requisições.
- NomeDoProjeto.**Services || Application**: Fornece serviços para a API, como UseCases. É onde colocaremos as regras de negócio (como os dados devem ser tratados).
	- **Services**: Interfaces dos serviços. Usamos injeção de dependência para não ficar vinculada à Infra.
- NomeDoProjeto.**Core || Domain**: Onde serão desenvolvidas as entidades e suas regras próprias, usada por todas as demais pastas. Não pode ser dependente de nenhuma outra pasta.
	- NomeDoProjeto.**Domain**: PROJETO Class Library, não pasta.
	- **Entities**: É onde colocamos os arquivos.cs para cada entidade, definindo seus métodos construtores e seguindo o diagrama de classes.
	- **Interfaces**: São os contratos modelo definidos para cada método. Define como vai ser, e não o que ou como vai fazer.
		- **Repository**: Apenas as interfaces dos repositories, referentes a cada classe.
		- **Services**: Interfaces para a pasta de Services. Funciona de forma semelhante ao Repository.
- NomeDoProjeto.**Infra**: Faz o acesso ao Banco de Dados.
	- **Repositories**: São as classes que assinam os contratos da interface. Os arquivos.cs possuem o mesmo nome que na `Interface > Repository`, mas sem o I na frente.

Outras:

- **Dal (Data Access Layer)**: Camada de Acesso aos Dados. Em estruturas mais simples, de apenas uma camada.
	- **Repositories**: Sempre ficam as interfaces dentro.
- **Models || Data**: É um modelo que espelha o formato da tabela de dados. Criamos um arquivo.cs para cada entidade, e definimos somente as propriedades, sem dar um comportamento para cada uma.


## Passo a passo

1. Modelagem de domínio: Primeiro identificamos o problema que vamos resolver, e depois identificamos as entidades que serão necessárias. Começamos uma API identificando a estrutura e montando no domain, seguindo nosso Diagrama de Classes.

2. Criar uma Class Library: Dentro de Domain, criamos um PROJETO (não pasta) com o mesmo nome de Domain: NomeDoProjeto.Domain

3. Dentro de Domain, criamos uma nossa primeira pasta chamada `Entities`, onde adicionaremos um arquivo do tipo class para cada entidade que criarmos.

- Quando uma classe é do tipo "internal", ela só pode ser usada dentro de seu próprio projeto. E para que possa ser usada fora, em qualquer lugar da solução, deverá ser do tipo "public".

- Uma vez que uma classe é criada, é necessário que ela tenha um construtor, e todo o processo normal que temos no C#.

4. Criar um projeto web dentro da pasta API.

Modelo:

```csharp
public class User
{
	public User(string nome, string email)
	{
		Id = Guid.NewGuid(); //cria uma nova Id automaticamente
		Nome = nome;
		Email = email;
	}

	public Guid Id { get; private set; } //Guid (Global Unique Identifier) é um código único. Trata-se de um int de 16 bytes.
	public string Nome { get; private set; }
	public string Email { get; private set; }
}
```


### Listas

```csharp
public class User : Identifier
{
		public User(string nome, string email)
	{
		Nome = nome;
		Email = email;
	}

	public string Nome { get; private set; }
	public string Email { get; private set; }

	//três 
	public Address Endereco { get ; set } //Adress era um tipo referente a IP, hoje obsoleto
	public List<Adress> Enderecos { get; set } //uma lista de endereços, representada por List<type>
	public IEnumerable<Adress> Enderecos { get; set } //uma lista de endereços IEnumerable vem de uma interface
}
```


### Using

Sempre que formos usar as classes do Core, teremos que referenciar com o using, seguindo o "caminho" das pastas, separado por pontos.

```csharp
using NomeDoProjeto.Domain.Entities //sendo Domain uma pasta, e Entities outra pasta dentro de Domain
```


### Interfaces em Domain

As interfaces em Domain podem definir vários métodos, mas quem vai explicar como os métodos acontecem, será a Infra e Services (que herdarão as interfaces).
Quem assinar esses contratos, serão obrigados a seguir as regras do método.

```csharp
//arquivo: IUserRepository.cs, em Domain > Interfaces > Repository
public interface IUserRepository
{
	public IEnumerable<User> GetAll();
	public User GetById(Guid id);
	public void DeleteById(Guid id);
	public User Update (User user);
}

//arquivo: UserRepository.cs, em Infra > Repository
using NomeDoProjeto.Domain.Interfaces.Repository;

public class UserRepository : IUserRepository //nome da classe é igual a interface, mas sem o I
{
	//agora aqui implementamos a interface criada. Ctrl + . = "implement interface" cria automaticamente.
	public IEnumerable<User> GetAll()
	{
		//Lógica para buscar todos os usuários no banco de dados
		return _userRepository.GetAll();
	}
	public User GetById(Guid id)
	{
		//Lógica para buscar um usuário pela id
		return _userRepository.GetById();
	}
}
```


### Services

> Quando usamos uma propriedade private, o nome pode ser iniciado em letra minúscula:

```csharp
public class UserService : IUserService
{
	private IUserRepository _userRepository;
	//não é necessário incluir { get ; set }
	//por ser private, pode ser iniciada com letra minúscula
	//o tipo, ao invés de string, int, etc, é a interface criada
	//usamos o underline para diferenciar quando criamos o método construtor abaixo

	public UserService(IUserRepository userRepository)
	{
		_userRepository = userRepository;
	}
}
```


Trazendo um único fornecedor:
Task<Model.Fornecedor> GetFornecedor(string id)

- `string id` parâmetro a ser recebido
- `GetFornecedor();` nome do método
- `Task<Model.Fornecedor>` Tipo de retorno

Trazendo uma lista de fornecedores:
Task<List<Model.Fornecedor>> GetFornecedor(string id)

- `List<>` Lista



## CRUD por Rotas

No Controller, o tipo de arquivo não é um class, mas sim um "Controler API".

Sempre herdam de ControllerBase, que é uma classe pronta, embutida no .NET, com muitas propriedades que podem ser usadas.

Indicamos a rota logo antes da classe nos arquivos.cs da pasta Controller:

```csharp
[ApiController] //DataAnnotation que informa que se trata de um controller
[Route("api/[controller]")]  //Data Annotation que vai definir uma rota
```

Por padrão, quando temos [controller] indicado, a rota será `api/NomeDoController`, excluindo-se a própria palavra 'controller'.

Então, para a rota: `api/fornecedor`, temos:

```csharp
[ApiController]
[Route("api/[controller]")]
public class FornecedorController : ControllerBase
{
	private readonly IFornecedor _fornecedor;
	public FornecedorController(IFornecedor fornecedor)
	{
		this._fornecedor = fornecedor; //construtor
	}
}
```

Agora os tipos Get e Post:

```csharp
[HttpGet] //não precisa de parâmetro
public Task<List<Model.Fornecedor>> Get()
{
	return _fornecedor.GetFornecedores();
}

[HttpGet("{id}")] //precisa de parâmetro, no caso id, que vem pela URL já que se trata de um método get
public Task<List<Model.Fornecedor>> Get(string id)
//apesar do nome ser igual ao método anterior, ele recebe um parâmetro, fazendo com que tenham assinaturas diferentes
{
	return _fornecedor.GetFornecedores(id);
}

[HttpPost] //método post, usando o corpo (frombody) lá do postman ou outro meio com formulário
public string Post([FromBody] Model.Fornecedor fornecedor) => _fornecedor.AddFornecedor(fornecedor);
//recebe os parâmetros definidos no método AddFornecedor através do formulário
```


## Builders

Adicionado em startup.cs (.NET5-) ou em program.cs (.NET6+), para que haja uma segurança inicial onde não seja possível acionar diretamente a lógica do método, mas sim sua interface.

Também é necessário referenciar no arquivo.

- `builder.Services.AddControllersWithViews()` é responsável por liberar o serviço para rotas;
- `builder.Services.AddTransiente<Ifornecedor, Fornecedor>();` e inclui o serviço e mapeia a interface com a classe, por exemplo: IFornecedor com Fornecedor;
- E configuração das Rotas para que funcione o api/fornecedor, por exemplo:

```csharp
app.MapControllerRoute(
	name: "default,
	pattern: "{controller=Home}/{action=Index}/{id?}");
```


## Classes e métodos do Csharp

- `ActionResult`: É uma classe do csharp que representa uma resposta da API, sendo um pouco mais flexível. Aceita como retorno um método, o que permite diferentes tipos.
- `Logger`: 
- `Enumerable`: 
- `Ok()`: Retorna 200.
- `BadRequest()`: Retorna um erro.
- `Any()`: Método para listas, o qual verifica se há conteúdo nela, retornando verdadeiro ou falso.
- `Count()`: Conta quantos elementos tem uma lista.