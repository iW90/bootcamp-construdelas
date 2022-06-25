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

---

### Tópicos para pesquisar (não entendi direito)

- Controller
- IActionResult
- ILogger
- [FromBody], [FromQuery], [FromHeader] - pq entre []?
- JS (fetch, .then e .catch, stringify, arrow function)
- JSON
- Result / Response
- Swagger
- Lambda
- _context: esse underline antes da palavra


---

> todolistuser
> 340$Uuxwp7Mcxo7Khy

