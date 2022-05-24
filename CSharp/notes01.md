# ANOTAÇÕES GERAIS

## Escrever na mesma linha:

    Console.Write("Texto");

## Escrever e passar pra linha seguinte:

    Console.WriteLine("Texto");

## Aguardar o usuário pressionar uma tecla:

    Console.ReadKey();

## Atalhos barra:

*    `\n`       nova linha
*    `\t`       tabulação
*    `\b`       backspace (apaga o caractere anterior)
*    `\a`       alerta (emite um som de alerta)
*    `\r`       retorno (retorna o cursor pro início da linha)
*    `\\`       exibe a barra
*    `\"`       exibe a aspa

## Ler caracteres de forma literal:

    Console.WriteLine(@"\Texto\");

* não exibe aspas

    Console.WriteLine("\"Texto\"");

* exibe as aspas

## Limpar o console:

    Console.Clear();

## Posicionar o cursor na tela:

    Console.SetCursorPosition(Y, X);

* Considerar como um plano cartesiano, eixos X e Y.
* (0, 0) é o canto superior esquerdo.

## Mudar as cores no console:

### Cores disponíveis:

| Nº | Color | Hex |
|:--:|:--:|:---:|
| ——— | —————————— | ————— |
| 0 | Black | #000000 |
| 1 | DarkBlue | #000080 |
| 2 | DarkGreen | #008000 |
| 3 | DarkCyan | #008080 |
| 4 | DarkRed | #800000 |
| 5 | DarkMagenta | #800080 |
| 6 | DarkYellow | #808000 |
| 7 | Gray | #C0C0C0 |
| 8 | DarkGray | #808080 |
| 9 | Blue | #0000FF |
| 10 | Green | #00FF00 |
| 11 | Cyan | #00FFFF |
| 12 | Red | #FF0000 |
| 13 | Magenta | #FF00FF |
| 14 | Yellow | #FFFF00 |
| 15 | White | #FFFFFF |

### Fonte: 

    Console.ForegroundColor = ConsoleColor.Magenta;

### Background:

    Console.BackgroundColor = ConsoleColor.Yellow; 

### Combinação para colorir a tela toda:

    Console.BackgroundColor = ConsoleColor.Blue;
    Console.ReadKey();
    Console.Clear();

## Apagar a formatação das cores:

    Console.ResetColor();

* O comando Clear não reseta as cores.

## Fazer comentários:

    // comentário de uma linha

    /* comentários de várias linhas */

    /// cria um comentário documentado em XML sobre a linha de código imediatamente abaixo

## Entrada de dados:

    Console.ReadLine();

## Números aleatórios:

    Random identificador = new Random();
    int n = identificador.Next();

* Se deixar `Next()` em branco, será gerado um número enorme indefinido
* Se colocar um único valor em `Next(N)`, será gerado um número de 0 a N (excluindo o N)
* Se colocar dois valores em `Next(X, Y)`, será gerado um número de X a Y (excluindo o Y)

## Temporizadores:

    Thread.Sleep();

* O valor de X é em milisegundos
* Necessário usar a biblioteca "using System.Threading;"



