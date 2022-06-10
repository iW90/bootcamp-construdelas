/* EXERCÍCIO 01
1. Pergunte ao usuário se tem complemento o endereco dele, S/N
2. Caso ele responda N, chame o construtor de endereco que você vai escrever que recebe somente 2 parametros
3. Caso ele responda S, pergunte o complemento e chame o construtor que já existe na classe endereco
*/


Console.Write("Digite a quantidade de clientes que você deseja cadastrar: ");
int qtd = Convert.ToInt32(Console.ReadLine());

var clientesArr = new Pessoa[qtd];

for (int i = 0; i < qtd; i++) {
    Console.Write("Digite o nome do cliente: ");
    string nomeDoCliente = Console.ReadLine();
    Console.Write("Digite o email do cliente: ");
    string emailDoCliente = Console.ReadLine();
    clientesArr[i] = new Pessoa(nomeDoCliente, emailDoCliente);
    Console.Write("Digite o logradouro: ");
    string logradouro = Console.ReadLine();
    Console.Write("Digite o numero: ");
    int numero = Convert.ToInt32(Console.ReadLine());

    Console.Write("Possui complemento? (S/N): ");
    string confirmacao = Console.ReadLine().ToUpper();

    if (confirmacao == "S") {
        Console.Write("Digite o complemento: ");
        string complemento = Console.ReadLine();
        clientesArr[i].endereco = new Endereco(logradouro, numero, complemento);
    } else {
        clientesArr[i].endereco = new Endereco(logradouro, numero);
    }
}

Console.WriteLine("Esses são os seus clientes: ");
foreach (var item in clientesArr) {
    item.ImprimePessoa();
}
