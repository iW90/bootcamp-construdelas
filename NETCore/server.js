        /* MODELO PARA ESTUDO */

const express = require('express'); //instalar o express com o yarn
const app = express(); //instanciar essa variável app


// Inicia o servidor na porta 3000, acessável em http://localhost:3000/
app.listen(3000, function() {
	console.log("Server is running");
});
//usar 'node server.js' para rodar. Está vazio, apenas com texto no console.

// Em http://localhost:3000/clients o clients seria o endpoint e também o resource.

// Usar o endpoint nos verbos http, boa prática não usar barra no final
// O express permite a callback function, que vai processar a requisição
// Quando especificada uma id, será processado somente um cliente, não todos

// Pesquisa geral em clientes
app.get("/clients", function(req, res){
    //anotar os objetos em JSON aqui
    res.json(data); //data é o nome do arquivo: data.json onde os dados são manipulados
});

// Pesquisa de cliente pela id
app.get("/clients/:id", function(req, res){
    const { id } = req.params; //seleciona o parâmetro id dentro da requisição
    const client = data.find(cli => cli.id == id); //encontra o cliente cujo id foi selecionado e coloca na const client

    //sempre dê uma resposta, boa prática.
    if (!client) return res.status(204).json(); //status 204 é "conteúdo não encontrado", mas a rota existe (senão seria 404)
    res.json(data);
});

// Inclusão de novo cliente
app.post("/clients", function(req, res){
    const { name, email } = req.body; //pega o nome e o email do body e lança

    res.json({ name, email }); //resposta é o conteúdo novo
});

// Alteração de cliente já existente pela id
app.put("/clients/:id", function(req, res){
    const { id } = req.params; //seleciona o parâmetro id dentro da requisição
    const client = data.find(cli => cli.id == id); //encontra o cliente cujo id foi selecionado e coloca na const client

    if (!client) return res.status(204).json(); //status 204 é "conteúdo não encontrado", mas a rota existe (senão seria 404)

    const { name } = req.body;
    client.name = name;

    res.json(client); //resposta é o conteúdo novo
});

// Exclusão de cliente pela id
app.delete("/clients/:id", function(req, res){
    const { id } = req.params; //seleciona o parâmetro id dentro da requisição
    const clientsFiltered = data.filter(cli => cli.id != id); //encontra todo cliente exceto o cujo id foi selecionado e coloca na const client

    if (!client) return res.status(204).json(); //status 204 é "conteúdo não encontrado", mas a rota existe (senão seria 404)

    res.json(clientsFiltered); //resposta é o conteúdo novo
});

