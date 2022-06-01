abstract class Mamifero : Animal {

    public void Procriar() {
        Console.WriteLine("Estou grávida");
    }

    public virtual void SeMovimentar() { //virtual porque mais pra frente será usado o "override"
        //obrigatório implementar todos os métodos da interface, mesmo que este fique em branco.
        throw new NotImplementedException(); //faz o programa ser interrompido
    }
}