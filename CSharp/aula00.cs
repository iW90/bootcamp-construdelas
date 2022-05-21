/* ANOTAÇÕES GERAIS

Escrever na mesma linha:
    Console.Write("Texto");

Escrever e passar pra linha seguinte:
    Console.WriteLine("Texto");

Aguardar o usuário pressionar uma tecla:
    Console.ReadKey();

Atalhos barra:
    \n       nova linha
    \t       tabulação
    \b       backspace (apaga o caractere anterior)
    \a       alerta (emite um som de alerta)
    \r       retorno (retorna o cursor pro início da linha)
    \\       exibe a barra
    \"       exibe a aspa

Ler caracteres de forma literal:
    Console.WriteLine(@"\Texto\"); (não funciona para aspas)
    Console.WriteLine("\"Texto\""); (mostra as aspas)

Limpar o console:
    Console.Clear();

Posicionar o cursor na tela:
    Console.SetCursorPosition(Y, X);
    • Considerar como um plano cartesiano, eixos X e Y.
    • (0, 0) é o canto superior esquerdo.

Mudar a cor da letra:
    Console.ForegroundColor = ConsoleColor.Magenta;

Mudar a cor do background:
    Console.BackgroundColor = ConsoleColor.Yellow;

    Cores disponíveis:
        0   Black
        9   Blue
        11  Cyan
        1   DarkBlue
        3   DarkCyan
        8   DarkGray
        2   DarkGreen
        5   DarkMagenta
        4   DarkRed
        6   DarkYellow
        7   Gray
        10  Green
        13  Magenta
        12  Red
        15  White
        14  Yellow

Apagar a formatação das cores:
    Console.ResetColor();
    • O comando Clear não reseta as cores.

Combinação para colorir a tela toda:
    Console.BackgroundColor = ConsoleColor.Blue;
    Console.ReadKey();
    Console.Clear();

Fazer comentários:
    // comentário de uma linha
    /* comentários de várias linhas * /
    /// cria um comentário documentado em XML sobre a linha de código imediatamente abaixo

Entrada de dados:
    Console.ReadLine();

Números aleatórios:
    Random identificador = new Random();
    int n = identificador.Next();
    • Se deixar Next() em branco, será gerado um número enorme indefinido
    • Se colocar um único valor em Next(N), será gerado um número de 0 a N (excluindo o N)
    • Se colocar dois valores em Next(X, Y), será gerado um número de X a Y (excluindo o Y)

Temporizadores:
    Thread.Sleep();
    • O valor de X é em milisegundos
    • Necessário usar a biblioteca "using System.Threading;"



*/