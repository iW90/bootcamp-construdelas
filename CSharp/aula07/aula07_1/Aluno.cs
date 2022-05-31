class Aluno
{
    public string nome; //atributo
    public double n1; //atributo
    public double n2; //atributo
    public double n3; //atributo
    public double n4; //atributo

    public Aluno(string nome, double n1, double n2, double n3, double n4)
    { //metodo construtor
        this.nome = nome;
        this.n1 = n1;
        this.n2 = n2;
        this.n3 = n3;
        this.n4 = n4;
    }

    public double Media()
    { //metodo
        return (n1 + n2 + n3 + n4) / 4;
    }
}