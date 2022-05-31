public class FiguraGeometrica {
    public double areaCalculada;
    public virtual string TipoDaFigura() {
        return "indefinido";
    }
    public double AreaDaFigura() {
        return areaCalculada;
    }
    public FiguraGeometrica(double areaCalculada) {
        this.areaCalculada = areaCalculada;
    }
    public FiguraGeometrica() {
    }
}