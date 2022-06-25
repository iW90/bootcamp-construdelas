# ANOTAÇÕES API

## REST (Representational State Transfer)

Será feita a transferência de dados de uma maneira simbólica. Essa transferência geralmente é feita através do protocolo HTTP (1.1, que permite os [métodos HTTP](#métodos-http).

O REST delimita algumas obrigações nessas transferências de dados.


## RESTFul

Ser RESTFul é aplicar todos os padrões REST.


### Seis necessidades (constraints) para ser RESTFul

- *Client-server*: Separação do cliente e do armazenamento de dados (servidor), dessa forma, poderemos ter uma portabilidade do nosso sistema, usando o React para WEB e React Native para o smartphone, por exemplo.

- *Stateless*: Cada requisição que o cliente faz para o servidor, deverá conter todas as informações necessárias para o servidor entender e responder (RESPONSE) a requisição (REQUEST). Exemplo: A sessão do usuário deverá ser enviada em todas as requisições, para saber se aquele usuário está autenticado e apto a usar os serviços, e o servidor não pode lembrar que o cliente foi autenticado na requisição anterior. Nos nossos cursos, temos por padrão usar tokens para as comunicações.

- *Cacheable*: As respostas para uma requisição, deverão ser explicitas ao dizer se aquela resquição, pode ou não ser cacheada pelo cliente.
    - Cache é um dispositivo de acesso rápido que armazena arquivos temporariamente para que não seja preciso repetir o trabalho de carregá-los.

- *Layered System*: O cliente acessa um [endpoint](#endpoint), sem precisar saber o que acontece no server-side, quais passos estão sendo necessários para o servidor responder a requisição, ou quais outras camadas o servidor estará lidando, para que a requisição seja respondida.

- *Uniform Interface*: Manter uma uniformidade, uma constância, um padrão na construção da interface. Nossa API precisa ser coerente para quem vai consumi-lá. Precisa fazer sentido para o cliente e não ser confusa. Logo, coisas como: o uso correto dos [métodos HTTP](#métodos-http); endpoints coerentes (todos os endpoints no plural, por exemplo); usar somente uma linguagem de comunicação (json) e não várias ao mesmo tempo; sempre enviar respostas aos clientes; são exemplos de aplicação de uma interface uniforme.

- *Code on demand (optional)*: Dá a possibilidade da nossa aplicação pegar códigos, como o javascript, por exemplo, e executar no cliente.


## Parâmetros

Funcionam como filtros e o ideal é que sejam passados como querystring:

Pedindo para retornar os projetos ordenados pelo nome onde o responsável seja o Fulano:

- GET `/projetos?ordenado=nome&responsavel=fulano` 
    - O `&` permite passar mais de um parâmetro
    - Os parâmetros são passados após `?`

```cs
[HttpGet(Name = "caminho/{parametro1}/{parametro2}")] // diretório/param1/param2
public IEnumerable<WeatherForecast> Get(string parametro1, int parametro2) //get parâmetros
{
    //code
}
```
