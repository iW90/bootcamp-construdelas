/* EXERCÍCIO 01
1. Crie um programa que peça pro usuário digitar 0 se a forma geométrica for quadrado, 1 se a forma geométrica for retângulo. (main) (tentem usar enum)
2. Crie uma classe chamada Retangulo com 2 construtores. (retangulo)
3. Um construtor vai receber somente o valor da largura e atribuir o mesmo valor para a altura, já que em um quadrado os lado são iguais. (retangulo)
4. O outro construtor vai receber o lado da altura e da largura para o retângulo.
5. Crie um método que calcule a área de retângulo chamado AreaDoRetangulo. (retangulo)
6. Peça para o usuário digitar o lado do quadrado e crie um objeto do tipo Retangulo caso seja um quadrado. (main)
7. Peça para o usuário digitar a largura e a altura e crie um objeto do tipo Retangulo caso seja um retangulo. (main)
8. Chame o método AreaDoRetangulo e imprima a área do retângulo. (main)
*/


Console.WriteLine("Digite 0 se for quadrado, 1 se for retangulo");
string formaStr = Console.ReadLine();
int formaInt = Convert.ToInt32(formaStr);

//FormaDaFigura forma = (FormaDaFigura) formaInt; // forma alternativa para o if abaixo. (FormaDaFigura) é uma coerção de dados para o tipo enum FormaDaFigura.

FormaDaFigura forma; //FormaDaFigura é um dataType criado mais abaixo, o enum. E "forma" é o nome da variável.
if (formaInt == 0)
    forma = FormaDaFigura.Quadrado;
else
    forma = FormaDaFigura.Retangulo;
    Retangulo ret;


if (forma == FormaDaFigura.Quadrado) {
    Console.WriteLine("digite o lado do quadrado");
    int lado = Convert.ToInt32(Console.ReadLine());
    ret = new Retangulo(lado);
}
else {
    Console.WriteLine("digite a altura do retangulo");
    int altura = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("digite a largura do retangulo");
    int largura = Convert.ToInt32(Console.ReadLine());
    ret = new Retangulo(altura, largura);
}
Console.WriteLine($"A Area é {ret.AreaDoRetangulo()}");