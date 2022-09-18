# PROJETO FINAL CONSTRUDELAS 2022 (BACKEND .NET)

## Descrição

Este projeto se refere ao módulo de backend do Bootcamp ConstruDelas 2022. Foi realizado pelo grupo Bertha Lutz, tratando-se de uma API de loja virtual, desenvolvida em .NET5.

> A Juntos Somos Mais está construindo uma nova plataforma de e-commerce e precisa deuma API para gerenciar os pedidos, catálogode produtos e cadastro de usuário. Utilize suas novas habilidades adquiridas na academia! O sistema deve permitir cadastro de novos clientes, incluindo dados pessoais e dados para contato, além de ser possível fazer a compra de produtos e associar a um pedido para o cliente cadastrado, e o histórico de pedido deve ser consultado.

## ENIAC Squad

**Mentora:** Mariana Ribeiro

- Adrizia Silva da Paixão
- Cleide Conceição
- Ingrid Wagner
- Kelly Cristiane Vieira da Silva
- Raphaela Joana Vieira de Sousa
- Tamires Cristina de Souza

## Materiais de Apoio

- [Asana](https://asana.com/pt) para criar uma lista de tarefas;

---

## Comandos Migrations

Cria o Migrations (é necessário executar na raiz da Solution — **não na Infra**):

```
dotnet ef --startup-project ./BerthaStore.API/BerthaStore.API.csproj  migrations add ProductTable -p ./BerthaStore.Infra/BerthaStore.Infra.csproj
```

Atualiza a tabela do Migrations (é necessário executar na raiz da Solution — **não na Infra**):

```
dotnet ef database update --project ./BerthaStore.API
```
