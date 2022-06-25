# ANOTAÇÕES API

## .NET vs .NET Core

A partir do .NET5+ é chamado de .NET Core, e funciona em qualquer plataforma (windows, linux, mac, etc);

As versões anteriores são conhecidas como .NET Framework, e só funciona no Windows;

UWP (Universal Windows Platform) é usado para construção de aplicativos desktop;

.NET Standard é apenas uma especificação de API que permite desenvolver bibliotecas para .NET;


## Paralelo sobre API

Traçando um paralelo entre um cliente solicitando dados a uma API e um cliente solicitando um prato em um restaurante:

- Cliente: client/user
- Garçom: API
- Cozinha: server
- Bloquinho de notas do garçom: HTTP/resources


## API (Application Programming Interface)

É uma interface de aplicações que pode comunicar-se com outros sistemas, ou seja, um intermediário que permite que duas ou mais aplicações sejam integradas entre si.

> Trata-se de um conjunto de rotinas e padrões estabelecidos, e documentados por uma aplicação, para que outras aplicações consigam utilizar suas funcionalidades, sem precisar conhecer detalhes da implementação. Em outras palavras, a comunicação entre aplicações e entre os usuários.

- Responsável por estabelecer comunicação entre diferentes serviços.
- Meio de campo entre as tecnologias.
- Intermediador para troca de informações.


## HTTP

O protocolo HTTP é um conjunto de regras de transmissão de dados que permitem que máquinas com diferentes configurações possam se comunicar com um mesmo "idioma".

<span align="center">

![URI](https://upload.wikimedia.org/wikipedia/commons/thumb/f/ff/URI_Venn_Diagram.svg/180px-URI_Venn_Diagram.svg.png)

</span>

- **URL (Uniform Resource Locator):** Se refere ao local, o Host que você quer acessar determinado recurso. O objetivo da URL é associar um endereço remoto com um nome de recurso na Internet. Pode conter protocolo, IP ou DNS (domínio), porta (opcional), caminho, identificador (opcional)
    - https://dominio.com.br
- **URN (Uniform Resource Namepermalink):** É o nome do recurso que será acessado
    - home.html
    - /contato
    - urn:isbn:0572248854 (para identificar um livro através de seu número ISBN)
- **URI (Uniform Resource Identifier):** - além de identificador, ela diz também como acessar ele, por meio do protocolo https. A URI une o Protocolo (https://) a localização do recurso (URL: dominio.com.br) e o nome do recurso (URN: /contato) para que você acesse as coisas na Web.
    - https://dominio.com.br/contato
    - mailto:John.Doe@example.com
    - ftp://ftp.is.co.za/rfc/rfc1808.txt


### Resources

são os arquivos em um servidor. É um objeto ou entidade, possuindo uma série de métodos para operá-lo, os métodos HTTP.

Em http://localhost:3000/clients, neste caso o `clients` é o Resource.


### Endpoint

É o endereço da API que iremos chamar pra obter um resource. 

O endereço é utilizado para comunicação entre uma API e um sistema externo, como uma URI mapeada. Geralmente é o "final" da URI. Exemplos de endpoints:

- **GET:** /topicos
- **GET:** /topicos/id
- **POST:** /topicos
- **PUT:** /topicos
- **DELETE:** /topicos/id


### Métodos HTTP

Entre outros, estes são os mais utilizados:

- **GET**: Receber dados de um Resource.
    - Não possui body e os dados devem ser passados para o servidor via parâmetro na rota ou querystring.
- **POST**: Enviar novos dados ou informações para serem processados por um Resource.
    - Os dados devem ser passados para o servidor pelo body.
- **PUT**: Atualizar dados de um Resource.
    - Os dados a serem atualizados devem ser passados para o servidor pelo body.
- **DELETE**: Deletar um Resource.
    - Não possui body e os dados devem ser passados para o servidor via parâmetro na rota ou querystring.


## HTTP Status Code

- **100 a 199:** Respostas de informação
- **200 a 299:** Respostas de sucesso
    - **200:** OK
    - **201:** Criado
    - **204:** Não tem conteúdo (mas a rota funciona, diferente do 404)
- **300 a 399:** Redirecionamento
- **400 a 499:** Client Error
    - **400:** Bad Request
    - **404:** Not found!
- **500 a 599:** Server Error
    - **500:** Internal Server Error

Erros detalhados: [Documentação](https://developer.mozilla.org/pt-BR/docs/Web/HTTP/Status)


## Header HTTP

Permite que o cliente e o servidor passem informações adicionais em suas requisições ou respostas. Ele é composto por um nome seguido de `:` e um valor sem quebras de linha.

> Cabeçalhos personalizados podem ser adicionados usando o prefixo `X-`, mas essa convenção foi descontinuada em Junho de 2012.

Fica oculto do restante da requisição e pode conter os valores de segurança.


### Swagger

Uma das formas mais famosas de documentar uma API é via **Swagger** (framework), que utiliza a especificação **Open API**. E Open API é um padrão usado por ferramentas que geram documentos para exibir os contratos da API \(entradas e saídas).



## Novo projeto

Crie um novo projeto/solução no Visual Studio

> ASP.NET Core Web API

Ou, digite no terminal do VSCode:

`dotnet new webapi -n "Nome"`

E F5 executa a aplicação.


Acesse o endereço:

https://localhost:44370/swagger

A porta você 44370 você vê em *launchSettings.json*, `sslPort": 44370`.

Para chamar uma API usamos a URL com o endereço (rota). Exemplo: https://alunos.com

Para trazer as informações da aluna "Ingrid", é necessário chamar por: https://alunos.com/alunos/nome=Ingrid

Na API padrão do .NET podemos observar que ele carrega num endereço: https://localhost:[porta]/swagger, porém o swagger é apenas a documentação de sua API.


## WeatherForecastController em Controllers

`[Route("[controller/caminho]")] //é possível mudar o endereço da rota aqui`

