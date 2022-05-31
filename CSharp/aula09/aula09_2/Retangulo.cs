public class Retangulo : FiguraGeometrica {
    public double altura;
    public double largura;
    public override string TipoDaFigura() {
        return "retangulo";
    }
    public Retangulo(double altura, double largura) : base(altura * largura) {
        this.altura = altura;
        this.largura = largura;
    }
}