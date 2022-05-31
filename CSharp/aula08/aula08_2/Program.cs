// CLASSE COM MAIS DE UM CONSTRUTOR
var pessoa = new Pessoa("thays", "thaystg@gmail.com");
var pessoa2 = new Pessoa("raquel");

Console.WriteLine(pessoa.nome);
Console.WriteLine(pessoa.email);
Console.WriteLine(pessoa2.nome);
Console.WriteLine(pessoa2.email);

class Pessoa
{
    public string nome;
    public string email;

    public Pessoa(string nome, string email)
    {
        this.nome = nome;
        this.email = email;
    }

    public Pessoa(string nome)
    {
        this.nome = nome;
        this.email = "nao informado";
    }
}