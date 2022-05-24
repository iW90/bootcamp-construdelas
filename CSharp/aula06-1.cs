/* using System.Globalization;

CultureInfo pt = new CultureInfo("pt-BR");

Console.Write("Digite a quantidade de pessoas: ");
int quantidadeDePessoas = Convert.ToInt32(Console.ReadLine());
Pessoa[] arrayPessoa = new Pessoa[quantidadeDePessoas];

for (int i = 0; i < quantidadeDePessoas; i++) {
    Console.Write("Digite seu nome: ");
    var nome = Console.ReadLine();

    Console.Write("Digite sua data de nascimento (DD/MM/AAAA): ");
    var dataDeNascimento = Console.ReadLine();

    Console.Write("Digite seu email: ");
    var email = Console.ReadLine();

    var dataDeNascimentoDate = DateTime.Parse(dataDeNascimento, pt);

    var minhaPessoa = new Pessoa(nome, dataDeNascimentoDate, email);

    Console.Write("Digite seu sexo: ");
    minhaPessoa.TrocaSexo(Console.ReadLine());
    
    arrayPessoa[i] = minhaPessoa;
}

foreach (var pessoa in arrayPessoa) {
    Console.WriteLine(pessoa.ToString() + " - " + pessoa.Idade());
}

class Pessoa {
    public string nome;  //atributos
    public DateTime dataDeNascimento; //atributos
    public string email; //atributos
    public string sexo;

    public Pessoa(string nomeParm, DateTime dataDeNascimento, string email) { //metodo construtor
        nome = nomeParm;
        this.dataDeNascimento = dataDeNascimento;
        this.email = email;
    }

    public void TrocaSexo(string sexo) {
        this.sexo = sexo;
    }

    public int Idade() { //metodo
        return DateTime.Now.Year - dataDeNascimento.Year;
    }

    public override string ToString() { //metodo
        return $"{nome} - {dataDeNascimento} - {email}";
    }
}

*/