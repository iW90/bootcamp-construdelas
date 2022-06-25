# ANOTAÇÕES API

## Requisições Síncrona x Assíncrona

As requisições síncronas acontecem em sequência, sendo necessário que a anterior termine antes que a próxima seja iniciada.

Já as requisições assíncronas podem acontecer em paralelo.

O código é executado sempre de forma síncrona, e para que seja assíncrono, usamos o atributo `async`.

```csharp
public async Task<IActionResult> Identificador([FromBody] IdentModel model) {
    //code
    var ident2 = await model.Identificador3(); //await faz essa linha esperar um retorno
}
```


### Deadlocks

É um problema que acontece quando há um impasse em processos que ficam bloqueados por esperar outros. Acontece o erro por "tempo de execução", pois ultrapassou o tempo limite de espera.


## DTO (data transfer object)

Padrão de objetos usado para transportar dados entre diferentes partes do sistema.

Contém dados, porém diferentemente de uma classe comum, não possui lógica. Podemos usá-lo para retornar dados de um banco de dados.


## Entity

É um objeto cuja identidade é importante (diferente do DTO, que serve somente para transferir dados).

Cada uma possui um id exclusivo, e elas podem ser mutáveis.

Se houver um cadastro de funcionários, a classe Funcionário é considerada uma Entidade, pois representa algo no processo.

Entidades podem conter lógica do domínio a qual representam (modelo rico). Se uma entidade apenas possui atributos, esta é considerada anêmica (modelo anêmico).

Não se usa a entidade para trafegar entre as camadas, ela deve ficar mais próxima do banco de dados.


## Layer Architecture

Também conhecida como N-Tiered, é outra arquitetura além da MVC, e é a mais utilizada atualmente.

Cada camada possui uma responsabilidade (e a quantidade pode variar). Cria-se uma abstração entre suas necessidades e podem existir barreiras entre elas (ex.: camadas superiores só conversam com camadas inferiores)

> Exemplo: O layer de apresentação tem os arquivos da interface.


## NuGet

É um gerenciador de pacotes para .NET.

Através dele conseguimos criar pacotes para serem distribuídos ou baixar pacotes já existentes para o funcionamento de nossa aplicação (https://www.nuget.org).

Para instalar um pacote em nosso projeto podemos fazer de três maneiras:

- Linha de comando .NET CLI
    - `dotnet add package nomepacote`
    - Exemplo: `dotnet add package Newtonsoft.Json`


- Package Manager Console (tipo outro console no VS)
    - `Install-Package nomepacote -ProjectName nomeprojeto`
 
- Através do projeto no Visual Studio.
    - Clique com o botão direito em cima do projeto e selecione a opção: Manage Nuget Packages.
    - A tela ao lado irá abrir e de lá você poderá gerenciar seus pacotes.

