public class Circulo : FiguraGeometrica {
    public double raio;
    public override string TipoDaFigura() {
        return "circulo";
    }
    public Circulo(double raio) {
        this.raio = raio;
        this.areaCalculada = 3.14 * Math.Pow(raio, 2);
    }
}