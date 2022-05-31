Console.WriteLine("Digite a quantidade de clientes que você deseja cadastrar");
int qtd = Convert.ToInt32(Console.ReadLine());
var clientesArr = new Pessoa[qtd];

for (int i = 0; i < qtd; i++)
{
    Console.WriteLine("Digite 0 se for pessoa fisica e 1 se for pessoa juridica");
    int tipoCliente = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite o Nome do Cliente:");
    string nomeDoCliente = Console.ReadLine();
    Console.WriteLine("Digite o email do Cliente:");
    string emailDoCliente = Console.ReadLine();
    if (tipoCliente == 0)
    {
        Console.WriteLine("Digite o CPF do Cliente:");
        string cpfDoCliente = Console.ReadLine();
        clientesArr[i] = new PessoaFisica(nomeDoCliente, emailDoCliente, cpfDoCliente);
    }
    else
    {
        Console.WriteLine("Digite o CNPJ do Cliente:");
        string cnpjDoCliente = Console.ReadLine();
        clientesArr[i] = new PessoaJuridica(nomeDoCliente, emailDoCliente, cnpjDoCliente);
    }
}
Console.WriteLine("esses são os seus clientes:");
foreach (var item in clientesArr)
{
    item.ImprimePessoa();
}