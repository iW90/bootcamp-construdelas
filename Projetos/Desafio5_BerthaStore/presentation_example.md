# Demonstração da API Bertha Lutz Store

1. Cadastrar cliente:

```json
{
  "userName": "Joel Evelino de Souza",
  "email": "jo.souza@hotmail.com",
  "phone": "",
  "address": "Rua das Tulipas, 902A"
}
```

2. Listar todos os clientes.

3. Listar todos os produtos.

4. Listar todos os pedidos.

5. Fazer novo Pedido:

```json
{
  "idUser": 217,
  "paymentType": "Crédito",
  "orderedItems": [
    {
      "idProduct": 34,
      "quantity": 2,
      "unitPrice": 41.59
    },
    {
      "idProduct": 43,
      "quantity": 3,
      "unitPrice": 32.00
    }
  ]
}
```

6. Listar todos os pedidos.

7. Atualizar pedido.

```json
{
  "idOrder": 53,
  "paymentType": "Pix",
  "orderedItems": [
    {
      "idProduct": 34,
      "quantity": 1,
      "unitPrice": 42
    }
  ]
}
```

8. Buscar pedido por Id. `53`

9. Deletar cliente. `217`

10. Deletar pedido. `53`

11. Buscar pedido por Id. `53`

12. Deletar cliente. `217`

13. Buscar todos clientes.
