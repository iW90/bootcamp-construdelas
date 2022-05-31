enum Sexo {
    Feminino,
    Masculino,
    NaoInformado
}

class Pessoa {
    public string nome;  //atributos
    public DateTime dataDeNascimento; //atributos
    public string email; //atributos
    public Sexo sexoDaPessoa; //atributos
    public Pessoa(string nomeParm, DateTime dataDeNascimento, string email, string sexo) { //metodo construtor
    
        nome = nomeParm;
        this.dataDeNascimento = dataDeNascimento;
        this.email = email;
        switch (sexo) {
            case "feminino":
                this.sexoDaPessoa = Sexo.Feminino;
                break;
            case "masculino":
                this.sexoDaPessoa = Sexo.Masculino;
                break;
            default:
                this.sexoDaPessoa = Sexo.NaoInformado;
                break;
        }
    }
}