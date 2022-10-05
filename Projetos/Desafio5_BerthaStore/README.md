# PROJETO FINAL CONSTRUDELAS 2022 (BACKEND .NET)

## Descrição

Este projeto se refere ao módulo de backend do Bootcamp ConstruDelas 2022. Foi realizado pelo grupo Bertha Lutz, tratando-se de uma API de loja virtual, desenvolvida em .NET5.

> A Juntos Somos Mais está construindo uma nova plataforma de e-commerce e precisa deuma API para gerenciar os pedidos, catálogode produtos e cadastro de usuário. Utilize suas novas habilidades adquiridas na academia! O sistema deve permitir cadastro de novos clientes, incluindo dados pessoais e dados para contato, além de ser possível fazer a compra de produtos e associar a um pedido para o cliente cadastrado, e o histórico de pedido deve ser consultado.

## BERTHA LUTZ Squad

**Mentora:** Mariana Ribeiro

- Adrizia Silva da Paixão
- Cleide Conceição
- Ingrid Wagner
- Kelly Cristiane Vieira da Silva
- Raphaela Joana Vieira de Sousa
- Tamires Cristina de Souza

## Endpoints

|—————| PEDIDOS | PRODUTOS | USUÁRIOS |
|---|------|------|------|
| Adicionar | `POST/api/Order` | `POST/api/Product` | `POST/api/User` |
| Atualizar | `PUT/api/Order` | `PUT/api/Product` | `PUT/api/User` |
| Buscar | `GET/api/Order` | `GET/api/Product` | `GET/api/User` |
| Deletar | `DELETE/api/Order/{orderId}` | `DELETE/api/Product/{productId}` | `DELETE/api/User/{userId}` |
| Listar | `GET/api/Order/ListAll` | `GET/api/Product/ListAll` | `GET/api/User/ListAll` |

## Pacotes e ferramentas

- EFCore
- Fluent Validation
- AutoMapper
- Swagger
- SQL Server

## Materiais de Apoio

- [Asana](https://app.asana.com/0/1202815787915229/list) para criar uma lista de tarefas (privado);
- [Trello](https://trello.com/b/4INf7Cre/bertha-lutz-store) para criar lista de tarefas (público);
- [Visual Paradigm](https://online.visual-paradigm.com/community/share/berthastore) para criar o diagrama de classes;
- [Google Slides](https://docs.google.com/presentation/d/1enJGkYUwS0T8osIr7QW2ijDcwnbvtMcVYFphugSm4H0/preview?slide=id.p) para slides de apresentação.

---

## Conexão com o Banco de Dados

Por questões de compatibilidade, são necessários alguns passos para que a API tenha acesso ao banco de dados:

1. É necessário ter instalado o SQL Server.
2. Ao se conectar no banco, escolha a opção `Windows Autentication` em "Authentication".
3. Caso seu "Server name" seja diferente de `localhost\SQLEXPRESS`, será necessário trocar esta expressão pelo seu *Server name* no arquivo "appsettings.json".
4. Uma vez conectado, crie uma nova database chamada `BerthaLutzStore` através do comando:

```sql
CREATE DATABASE [BerthaLutzStore];
```

5. Pode haver conflitos com relação à data do arquivo de migração, portanto, se necessário, execute novamente o comando abaixo:

> é necessário executar na pasta raiz onde se encontram todos os projetos da solution.

```
dotnet ef --startup-project ./BerthaLutzStore.API/BerthaLutzStore.API.csproj  migrations add AllTable -p ./BerthaLutzStore.Infra/BerthaLutzStore.Infra.csproj
```

### Outros modelos de configuração do BD

- [Connections Strings](https://www.connectionstrings.com)
