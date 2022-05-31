/* EXERCÍCIO 01
1. Faça um programa principal, que leia quantos alunos tem na sala de aula e guarde na variável qtdeAlunos do tipo int.
2. Faça um loop para ler o nome do aluno, a nota1, nota2, nota3, nota4 do aluno. (notas tipo double)
3. Crie uma classe chamada Aluno em outro arquivo que não seja onde está o programa principal.
4. A classe aluno terá um construtor que receberá o nome do aluno e as notas do aluno como parâmetro.
5. A classe também terá um método que calculará a média anual do aluno e retornará um double.
6. Crie um objeto do tipo Aluno e armazene em um array chamado alunoArray
7. Depois disso imprima o nome de cada aluno e APROVADO caso a média dele seja maior ou igual a 7. */


Console.Write("Quantidade de alunos: ");
int qtdeAlunos = Convert.ToInt32(Console.ReadLine);
var alunoArray = new Aluno[qtdeAlunos];

for (int i = 0; i < qtdeAlunos; i++) {
    Console.Write("Nome do aluno: ");
    string nome = Console.ReadLine();

    Console.Write("Primeira nota (n1): ");
    double.TryParse(Console.ReadLine(), out double n1);

    Console.Write("Segunda nota (n2): ");
    double.TryParse(Console.ReadLine(), out double n2);

    Console.Write("Terceira nota (n3): ");
    double.TryParse(Console.ReadLine(), out double n3);

    Console.Write("Quarta nota (n4): ");
    double.TryParse(Console.ReadLine(), out double n4);

    var aluno = new Aluno(nome, n1, n2, n3, n4);

    alunoArray[i] = aluno;
}

foreach (var aluno in alunoArray) {
    if (aluno.Media() >= 7) {
        Console.WriteLine($"O aluno {aluno.nome} foi aprovado");
    }
}