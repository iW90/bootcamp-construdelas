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