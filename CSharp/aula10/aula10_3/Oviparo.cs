abstract class Oviparo : Animal {

    public void Procriar() {
        Console.WriteLine("Botei ovo");
    }

    public virtual void SeMovimentar() {
        //obrigatório implementar todos os métodos da interface, mesmo que este fique em branco.
        throw new NotImplementedException(); //faz o programa ser interrompido
    }
}