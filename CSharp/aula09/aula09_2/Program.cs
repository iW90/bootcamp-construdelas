/* EXERCÍCIO 01:
1. Vamos criar a classe FiguraGeometrica
2. Vamos criar o método virtual TipoDaFigura que vai retornar “indefinido”
3. Vamos criar o método AreaDaFigura que vai retornar areaCalculada
4. Vamos criar o atributo areaCalculada que será um double

5. Vamos criar a classe Retangulo que herda da FiguraGeometrica
6. Vamos sobrescrever o método TipoDaFigura e retornar “Retangulo”
7. Vamos criar o atributo altura e largura, double
8. Vamos criar um construtor que receba a largura e a altura, e no proprio construtor já vamos calcular a área e colocar no atributo da classe base areaCalculada.
9. DICA: Area do retangulo = largura * altura

10. Vamos criar a classe Circulo que herda da FiguraGeometrica
11. Vamos sobrescrever o método TipoDaFigura e retornar “Circulo”
12. Vamos criar o atributo raio, double
13. Vamos criar um construtor que receba o raio do Circulo, e no proprio construtor já vamos calcular a área e colocar no atributo da classe base areaCalculada.
14. DICA: Area do circulo = 3,14 * raio elevado ao quadrado.
15. Math.Pow(raio, 2)
16. 3,14 * raio * raio
*/


var circ = new Circulo(10);
Console.WriteLine(circ.AreaDaFigura());

var ret = new Retangulo(10, 20);
Console.WriteLine(ret.AreaDaFigura());