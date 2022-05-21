using System.Text;
using System.Globalization;

class aulasB {
    public static void aula03a() {
        Console.WriteLine("\n\tTeste de Date Time: ");

        var date = new DateTime();
        Console.WriteLine(date);

        var date1 = DateTime.Now;
        Console.WriteLine(date1);

        var date2 = DateTime.UtcNow;
        Console.WriteLine(date2);

        var date3 = new DateTime(2022, 05, 15, 22, 33, 44);
        Console.WriteLine(date3);
        Console.WriteLine(date3.Month);

        date3 = date3.AddDays(2); //adiciona 2 dias ao date3
        Console.WriteLine(date3.Day);
    }

    public static void aula03b() {
        Console.WriteLine("\n\tExercício 05: ");
        /* Exercício:
        1. Pergunte o dia, mês e ano do aniversário de uma pessoa.
        2. Exiba no console o dia da semana em que a pessoa nasceu.
        3. Exiba no console o dia do ano em que a pessoa nasceu.*/

        Console.WriteLine("Digite o dia: ");
        String niverDia = Console.ReadLine();

        Console.WriteLine("Digite o mês: ");
        String niverMes = Console.ReadLine();

        Console.WriteLine("Digite o ano: ");
        String niverAno = Console.ReadLine();

        // var niver = new DateTime(Convert.ToInt32(niverAno), Convert.ToInt32(niverMes), Convert.ToInt32(niverDia));
        // Console.WriteLine(niver.DayOfWeek);
        // ou:

        Console.WriteLine(new DateTime(Convert.ToInt32(niverAno), Convert.ToInt32(niverMes), Convert.ToInt32(niverDia)).DayOfWeek + new DateTime(Convert.ToInt32(niverAno), Convert.ToInt32(niverMes), Convert.ToInt32(niverDia)).DayOfYear);

        String novo = Console.ReadLine();
    }

    public static void aula03c() {
        Console.WriteLine("\n\tTeste de Strings e Concatenação: ");

        string minhaString = "Ingrid";
        Console.WriteLine(minhaString);

        string minhaNovaString = minhaString + "Wagner";
        Console.WriteLine(minhaNovaString);

        minhaString += "Wagner";
        Console.WriteLine(minhaString);

        StringBuilder sb = new StringBuilder(); //necessário inserir "using System.Text;" no início do arquivo para importar a biblioteca.
        sb.Append("Ingrid");
        sb.Append("Wagner");
        string str = sb.ToString();
        Console.WriteLine(sb);

        // Criando strings com elementos repetidos:
        string s1 = new string('*', 20);
    }

    public static void aula03d() {
        Console.WriteLine("\n\tTeste de Comparação de Strings: ");

        var a = "minha string";
        var b = "Minha String";

        Console.WriteLine(a == b); //diferencia maiúsculas de minúsculas
        Console.WriteLine(a.Equals(b)); //diferencia maiúsculas de minúsculas
        Console.WriteLine(string.Compare(a, b, true) == 0); //true: não diferencia maiúsculas de minúsculas e false: diferencia maiúsculas de minúsculas
    }

    public static void aula03e() {
        Console.WriteLine("\n\tTeste de Posicionamento: ");

        string s1 = "Trabalhar com C# é demais!";
        string s2 = "demais";

        var pos = s1.IndexOf(s2);
        Console.WriteLine(pos);

        // var pos = s1.ToCharArray();
        // Console.WriteLine(pos[10]);
    }

    public static void aula03f() {
        Console.WriteLine("\n\tExercício 02: ");
        /* Exercício:
        1. Digite duas frases (a primeira precisa conter a segunda).
        2. Concatene ambas.
        3. Mostre a posição da segunda frase na primeira.
        4. Mostre a terceira letra.*/

        Console.WriteLine("Digite a primeira frase: ");
        String texto1 = Console.ReadLine();

        Console.WriteLine("Digite a segunda frase: ");
        String texto2 = Console.ReadLine();

        Console.WriteLine(texto1 + " e " + texto2);

        var position = texto1.IndexOf(texto2);
        Console.WriteLine(position);

        var textoArray = texto1.ToCharArray();
        Console.WriteLine(textoArray[2]);
    }

    public static void aula03g() {
        Console.WriteLine("\n\tTeste de Alteração de Strings: ");

        var frase = Console.ReadLine();
        var strRet = frase.Replace("teste", "legal"); //substitui "teste" por "legal"
        var strRet2 = frase.Substring(0, 2); // retorna 2 valores a partir da posição 0
    }

    public static void aula03h() {
        Console.WriteLine("\n\tExercício 03: ");
        /*Exercício:
        1. Peça uma frase.
        2. Exiba as 10 primeiras letras da frase.
        3. Substitua todas as letras "a" por letras "u".*/

        Console.WriteLine("Digite uma frase: ");
        String texto1 = Console.ReadLine();

        var textoAlterado = texto1.Substring(0, 9);
        Console.WriteLine(textoAlterado);

        textoAlterado = texto1.Replace('a', 'u');
        Console.WriteLine(textoAlterado);
    }

    public static void aula03i() {
        Console.WriteLine("\n\tTeste de Globalização: ");

        CultureInfo pt = new CultureInfo("pt-BR");
        Console.WriteLine(pt.DisplayName);
        Console.WriteLine(pt.DateTimeFormat.FirstDayOfWeek.ToString());
        Console.WriteLine(pt.DateTimeFormat.DateSeparator);
        Console.WriteLine(pt.NumberFormat.CurrencyDecimalSeparator);

        var number = 10000;
        Console.WriteLine(number.ToString("c", pt));  //transforma uma variável numa string, formatando conforme o "pt" no formato "c"

        var dateTime = DateTime.Now;
        Console.WriteLine(dateTime.ToString(pt)); //transforma uma variável numa string, formatando conforme o "pt"
    }

    public static void aula03j() {
        Console.WriteLine("\n\tExercício 04: ");
        /* Exercício:
        1. Pergunte a cidade
        2. Pergunte o valor da gasolina
        3. Exiba no console:
            - A cidade
            - A data (de acordo com o formato do país pt-BR ou en-US)
            - O preço (de acordo com o formato do país pt-BR ou en-US)*/

        CultureInfo pt = new CultureInfo("en-US"); //pt-BR se for Brasil, en-US se for EUA.

        Console.WriteLine("Em qual cidade você mora: ");
        String cidade = Console.ReadLine();

        decimal gas = 0;
        Console.WriteLine("Qual o valor da gasolina: ");
        decimal.TryParse(Console.ReadLine(), out gas);

        Console.WriteLine(cidade + ", " + (DateTime.Now.ToString(pt)) + ".\nO preço da gasolina é: " + gas.ToString("c", pt));
    }


    public static void aula03k() {
        Console.WriteLine("\n\tExercício 05: ");
        /* Desafio:
        1. Peça para o user digitar o aniversário de uma pessoa no formato: DD/MM/AAAA
        2. Crie uma data e exiba no console o dia da semana em que a pessoa nasceu.*/

        Console.WriteLine("Digite a data de nascimento no formato DD/MM/AAAA: ");
        String niver = Console.ReadLine();

        var niverDia = niver.Substring(0, 2);
        var niverMes = niver.Substring(3, 2);
        var niverAno = niver.Substring(6, 4);

        Console.WriteLine(new DateTime(Convert.ToInt32(niverAno), Convert.ToInt32(niverMes), Convert.ToInt32(niverDia)).DayOfWeek);
    }
}


/*  DATE TIME
        var identificador = newDateTime(ano, mês, dia, hora, minuto, segundo);
        var identificador = newDateTime(ano, mês, dia);

        Console.WriteLine(identificador.DayOfWeek); // dia da semana
        Console.WriteLine(identificador.Day); // dia
        Console.WriteLine(identificador.Month); // mês
        Console.WriteLine(identificador.Year); // ano

        DateTime.Now.Day; // dia atual
        DateTime.Now.Month; //mês atual
        DateTime.Now.Year; //ano atual

    STRINGS E CONCATENAÇÃO
    É utilizado o sinal de soma [+], bastando que uma das variáveis seja string para concatenar:
        string identificador = palavra + " " + palavra;

    Ou adicionando valores com Append:
        StringBuilder identificador = new StringBuilder();
        identificador.Append("Ingrid");
        identificador.Append("Wagner");
        string str = identificador.ToString();
        • Necessário inserir "using System.Text;" no início do arquivo para importar a biblioteca

    REPETIÇÃO DE VALORES:
    Criando uma string cujo valor * se repete n vezes
        string identificador = new string('*', n);
        • * é o caractere ou texto que será repetido
        • n é a quantidade de vezes que vai se repetir

    INTERPOLAÇÃO
        Console.Write($"Texto {var1}, texto {var2}");
        • Se usado @ no lugar de $, significa "não interpole"

    COMPARAÇÕES DE STRINGS
    Três formas de comparar strings:
        Console.WriteLine(a == b);
        Console.WriteLine(a.Equals(b));
        Console.WriteLine(string.Compare(a, b, true) == 0);
        • Se usar true, não diferencia maiúsculas e minúsculas
        • Se usar false, diferencia maiúsculas e minúsculas
        Console.WriteLine(string.Compare(a, b, true));
        • Compara letra a letra até que uma venha antes que outra [ a < z || a > z ]
            • Retorna -1 se a < b
            • Retorna 0 se forem iguais
            • Retorna 1 se a > b

    POSICIONAMENTO EM STRINGS
    Mostra a posição de um caractere de uma string:
        var identificador1 = s1.IndexOf(s2);
        Console.WriteLine(identificador1);

    Ou transforma em um array para mostrar o index da letra:
        var pos = s1.ToCharArray();
        Console.WriteLine(pos[n]);
        • n é a posição, lembrando que index começa em 0

    CORTANDO STRINGS (SUBSTRING)
    Corta um pedaço da string
        var identificador2 = identificador1.Substring(0, 2); // vai retornar 2 valores a partir da posição 0

    REPLACE
    Substitui parte de uma string
        var identificador2 = identificador1.Replace("substituído", "substituto");

    GLOBALIZATION
    Necessário inserir "using System.Globalization;" no início do arquivo para importar a biblioteca.

        CultureInfo pt = new CultureInfo("pt-BR"); //Define para qual país serão adaptados os dados

        Console.WriteLine(pt.DisplayName); //mostra o país para onde está definido
        Console.WriteLine(pt.DateTimeFormat.FirstDayOfWeek.ToString()); //mostra o dia da semana para o país definido
        Console.WriteLine(pt.DateTimeFormat.DateSeparator); //mostra o separador de data que será usado
        Console.WriteLine(pt.NumberFormat.CurrencyDecimalSeparator); //mostra o seperador de modera que será usado (vírgula ou ponto)

        Console.WriteLine(number.ToString("c", pt)); //"c" representa a forma de imprimir números, pt é a referência para o país definido
        Console.WriteLine(dateTime.ToString(pt));

            Formas de imprimir números:
            • c, C (Formato de moeda)
            • d, D (Formado decimal)
            • e, E (Formato exponencial)
            • f, F (Formato fixed point)
            • g, G (Formato geral)
            • n, N (Formato numérico)
            • r, R (Formato roundtrip)
            • x, X (Formato hexadecimal)
    
    INTERPOLAÇÃO COM FORMATAÇÃO
        Console.Write($"Texto {var:C}");
        • O valor de "var" será adaptado ao formato C (formato de moeda), exibindo cifrão ou símbolo da moeda.
        • Não faz conversão de moeda, apenas formata visualmente.

        Console.Write($"Texto {var:Dn}");
        • No lugar de n, informe a quantidade de casas decimais que devem ser exibidas.

        Console.Write($"Texto {var:X}");
        • Faz a conversão para o valor em hexadecimal.

        Console.Write($"Texto {var, N}");
        • O valor de N define a quantidade de espaços que a string var ocupará.
        • Se o texto não preencher, o restante do espaço será preenchido com espaços vazios.
        • Um valor positivo deixa os espaços antes do texto e um valor negativo deixa os espaços depois do texto.
        • Não vai cortar a string caso N seja menor do que o texto.

        Console.Write($"Texto {var, N:C}");
        • Insere espaços e formata como moeda.
    */