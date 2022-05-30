/*
var pessoaArray = new List<Pessoa>();

var pessoa = new Pessoa("Thays", new DateTime(1985, 12, 17), "thaystg@gmail.com", "feminino");
pessoaArray.Add(pessoa);

pessoa = new Pessoa("Jamile", new DateTime(2004, 12, 17), "jamile@gmail.com", "feminino");
pessoaArray.Add(pessoa);

pessoa = new Pessoa("Leone", new DateTime(1985, 10, 18), "leone@gmail.com", "masculino");
pessoaArray.Add(pessoa);

foreach (var item in pessoaArray) {
    if (item.sexoDaPessoa == Sexo.Feminino)
        Console.WriteLine(item.nome);
}


// OUTRO ARQUIVO.CS: (salvei no mesmo arquivo para organização)
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
*/