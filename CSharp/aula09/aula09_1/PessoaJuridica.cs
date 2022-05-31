class PessoaJuridica : Pessoa
{
    public string cnpj;
    public PessoaJuridica(string nome, string email, string cnpj) : base(nome, email)
    {
        this.cnpj = cnpj;
    }
    public override string ToString()
    {
        return base.ToString() + $"\nCNPJ:{cnpj}";
    }
    public override string TipoDePessoa()
    {
        return "Juridica";
    }
}