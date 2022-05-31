class Pessoa {
    public string nome;
    public string email;
    public Pessoa(string nome, string email) {
        this.nome = nome;
        this.email = email;
    }

    public void ImprimePessoa() {
        Console.WriteLine(ToString());
    }

    public virtual string TipoDePessoa() {
        return "indefinido";
    }
    
    public override string ToString() {
        return $"TipoDePessoa:{TipoDePessoa()}\nNome:{nome}\nEmail:{email}";
    }
}