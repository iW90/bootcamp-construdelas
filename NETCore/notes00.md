# ANOTAÇÕES API

## Boas Práticas

- Utilizar métodos HTTP para nossas requisições.
- Utilizar plural ou singular na criação dos endpoints? Quando se tratar de um arquivo ou vários.
- Não utilizar nomes de ações na URL.
- Não deixar barra no final do endpoint.
- Nunca deixe o cliente sem resposta!
- Recomendado usar o PATCH ao invés de PUT quando nem todos os atributos de um resource forem alterados.
- Apenas até três parâmetros e mais que isso é melhor criar um objeto.
- Criar versionamento para não quebrar os endpoints: `http://api.com/v2/endpoint`


## Segurança

Importante o uso de SSL nas conexões das APIs, ou seja, todos os dados serão criptografados usando o protocolo HTTPS.


## Comandinhos

- `Z + Ctrl + .`: Remove as bibliotecas não utilizadas.
- Clicar sobre a camada API e selecionar "Set as Startup Project" para que seja iniciada por ela a execução.


---

### Tópicos para pesquisar

- JS (fetch, .then e .catch, stringify, arrow function)
- JSON
- Result / Response
- Lambda
- Injeção de Dependência (feita na Startup)
- Propriedade de navegação
- T Genérico
- Quando usar async e await


---

> todolistuser
> 340$Uuxwp7Mcxo7Khy
