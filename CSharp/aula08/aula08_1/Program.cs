// CLASSE SEM CONSTRUTOR
var pessoa = new Pessoa();
pessoa.nome = "ingrid";
pessoa.email = "ingrid@gmail.com";

Console.WriteLine(pessoa.nome);
Console.WriteLine(pessoa.email);

class Pessoa{
    public string nome;     //atributos
    public string email;    //atributos
}