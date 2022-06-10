
Console.Write("Digite a quantidade de clientes que você deseja cadastrar: ");
int qtd = Convert.ToInt32(Console.ReadLine());

var clientesArr = new Pessoa[qtd];

for (int i = 0; i < qtd; i++) {
    Console.Write("Digite o nome do cliente: ");
    string nomeDoCliente = Console.ReadLine();
    Console.Write("Digite o email do cliente: ");
    string emailDoCliente = Console.ReadLine();
    clientesArr[i] = new Pessoa(nomeDoCliente, emailDoCliente);
    Console.WriteLine("Digite o logradouro:");
    string logradouro = Console.ReadLine();
    Console.WriteLine("Digite o numero:");
    int numero = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite o complemento:");
    string complemento = Console.ReadLine();
    clientesArr[i].endereco = new Endereco(logradouro, numero, complemento);
}

Console.WriteLine("esses são os seus clientes:");
foreach (var item in clientesArr) {
    item.ImprimePessoa();
}
