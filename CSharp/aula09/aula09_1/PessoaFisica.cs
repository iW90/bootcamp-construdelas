class PessoaFisica : Pessoa
{
    public string cpf;
    public PessoaFisica(string nome, string email, string cpf) : base(nome, email)
    {
        this.cpf = cpf;
    }
    public override string ToString()
    {
        return base.ToString() + $"\nCPF:{cpf}";
    }
    public override string TipoDePessoa()
    {
        return "Fisica";
    }
}