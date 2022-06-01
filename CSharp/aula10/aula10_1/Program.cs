interface IExemploDeInterface {
    void MetodoExemplo();
}

class ImplementacaoDaClasse : IExemploDeInterface {
    // implementar explicitamente o metodo da interface:
    void IExemploDeInterface.MetodoExemplo() {
        // implementacao do método
    }

    static void Main() {
        // declare uma interface e crie um objeto da classe que implementa a interface
        IExemploDeInterface obj = new ImplementacaoDaClasse();

        // chamar o método
        obj.MetodoExemplo();
    }
}