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