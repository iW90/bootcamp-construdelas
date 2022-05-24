# ANOTAÇÕES REFERENTES À AULA 03

## Date Time:

```
var identificador = newDateTime(ano, mês, dia, hora, minuto, segundo);
var identificador = newDateTime(ano, mês, dia);

Console.WriteLine(identificador.DayOfWeek); // dia da semana
Console.WriteLine(identificador.Day); // dia
Console.WriteLine(identificador.Month); // mês
Console.WriteLine(identificador.Year); // ano

DateTime.Now.Day; // dia atual
DateTime.Now.Month; // mês atual
DateTime.Now.Year; // ano atual
```

## Strings e Concatenação:

É utilizado o sinal de soma `+`, bastando que uma das variáveis seja string para concatenar:

```
string identificador = palavra + " " + palavra;
```

Ou adicionando valores com `Append`:

```
StringBuilder identificador = new StringBuilder();
identificador.Append("Ingrid");
identificador.Append("Wagner");
string str = identificador.ToString();
```

* Necessário inserir `using System.Text;` no início do arquivo para importar a biblioteca.

## Repetição de valores:

Criando uma string cujo valor `*` se repete `n` vezes

```
string identificador = new string('*', n);
```

* `*` é o caractere ou texto que será repetido
* `n` é a quantidade de vezes que vai se repetir

## Interpolação:

```
Console.Write($"Texto {var1}, texto {var2}");
```

* Se usado @ no lugar de $, significa "não interpole"

## Comparações de Strings:

Três formas de comparar strings:

```
Console.WriteLine(a == b);
Console.WriteLine(a.Equals(b));
Console.WriteLine(string.Compare(a, b, true) == 0);
```

* Se usar true, não diferencia maiúsculas e minúsculas.
* Se usar false, diferencia maiúsculas e minúsculas.
<br><br>

```
Console.WriteLine(string.Compare(a, b, true));
```

* Compara letra a letra até que uma venha antes que outra [ a < z || a > z ]
    * Retorna -1 se a < b
    * Retorna 0 se forem iguais
    * Retorna 1 se a > b

## Posicionamento de Strings:

Mostra a posição de um caractere de uma string:

```
var identificador1 = s1.IndexOf(s2);
Console.WriteLine(identificador1);
```

Ou transforma em um array para mostrar o index da letra:

```
var pos = s1.ToCharArray();
Console.WriteLine(pos[n]);
```

* Sendo `n` a posição e lembrando que index começa em 0.

## Cortando Strings:

Corta um pedaço da string

```
var identificador2 = identificador1.Substring(0, 2);
// retorna 2 valores a partir da posição 0
```

## Substituindo trechos em Strings:

```
var identificador2 = identificador1.Replace("substituído", "substituto");
```

## Globalization

* Necessário inserir `using System.Globalization;` no início do arquivo para importar a biblioteca.

```
CultureInfo pt = new CultureInfo("pt-BR");
//Define para qual país serão adaptados os dados

Console.WriteLine(pt.DisplayName);
//mostra o país para onde está definido

Console.WriteLine(pt.DateTimeFormat.FirstDayOfWeek.ToString());
//mostra o dia da semana para o país definido

Console.WriteLine(pt.DateTimeFormat.DateSeparator);
//mostra o separador de data que será usado

Console.WriteLine(pt.NumberFormat.CurrencyDecimalSeparator);
//mostra o seperador de modera que será usado (vírgula ou ponto)

Console.WriteLine(number.ToString("c", pt));
//"c" representa a forma de imprimir números, pt é a referência para o país definido

Console.WriteLine(dateTime.ToString(pt));
```

## Formas de imprimir números:

| Código | Formato |
|:---:|:---|
| ——— | ———————————— |
| c, C | moeda |
| d, D | decimal |
| e, E | exponencial |
| f, F | fixed point |
| g, G | geral |
| n, N | numérico |
| r, R | roundtrip |
| x, X | hexadecimal |

## Interpolação com formatação:

```
Console.Write($"Texto {var:C}");
```

* O valor de "var" será adaptado ao formato C (formato de moeda), exibindo cifrão ou símbolo da moeda.
* Não faz conversão de moeda, apenas formata visualmente.
<br><br>

```
Console.Write($"Texto {var:Dn}");
```

* No lugar de n, informe a quantidade de casas decimais que devem ser exibidas.
<br><br>

```
Console.Write($"Texto {var:X}");
```

* Faz a conversão para o valor em hexadecimal.
<br><br>

```
Console.Write($"Texto {var, N}");
```

* O valor de N define a quantidade de espaços que a string var ocupará.
* Se o texto não preencher, o restante do espaço será preenchido com espaços vazios.
* Um valor positivo deixa os espaços antes do texto e um valor negativo deixa os espaços depois do texto.
* Não vai cortar a string caso N seja menor do que o texto.
<br><br>

```
Console.Write($"Texto {var, N:C}");
```

* Insere espaços e formata como moeda.