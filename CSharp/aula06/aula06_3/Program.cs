var retangulo = new Retangulo (10, 30);
Console.WriteLine(retangulo);

class Retangulo {
    public double altura;
    public double largura;

    public Retangulo (double altura, double largura) { //método construto
        this.altura = altura;
        this.largura = largura;
    }

    public double Area() {
        return largura * altura;
    }

    public override string ToString() {
        return $"Com {altura} e {largura}, a área é {Area()}";
    }
}