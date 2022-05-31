enum FormaDaFigura
{
    Quadrado = 0,
    Retangulo = 1,
    Circulo = 2,
    Trapezio = 3
}

class Retangulo
{
    public int largura;
    public int altura;
    public Retangulo(int largura, int altura)
    {
        this.largura = largura;
        this.altura = altura;
    }

    public Retangulo(int lado)
    {
        this.largura = lado;
        this.altura = lado;
    }

    public int AreaDoRetangulo()
    {
        return largura * altura;
    }
}