
class Pessoa {
    public string nome;
    public string email;
    public Endereco endereco;
    public Pessoa(string nome, string email) {
        this.nome = nome;
        this.email = email;
    }

    public void ImprimePessoa() {
        Console.WriteLine(ToString());
    }

    public override string ToString() {
        return $"Nome:{nome}\nEmail:{email}\n{endereco}";
    }
}