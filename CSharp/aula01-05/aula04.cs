class aulasC {
    public static void aula04a() {
        Console.WriteLine("\n\tTeste de Erro 'Try Catch': ");

        var a = "OlaThays";
        try {
            Convert.ToInt32(a);
            Console.WriteLine("lalalla");
        } catch (Exception e) {
            Console.WriteLine("Deu Erro");
            Console.WriteLine(e.ToString());
        }
    }

    public static void aula04b() {
        Console.WriteLine("\n\tExercício 01: ");
        /* EXERCÍCIO 01:
        1. Exiba um erro caso o formato da data seja digitado errado ou incompleto
        */

        Console.WriteLine("Digite o dia do seu aniversário no formato DD/MM/AAAA");
        string dataDeNascimentoStr = Console.ReadLine();
        string diaStr = dataDeNascimentoStr.Substring(0, 2);
        string mesStr = dataDeNascimentoStr.Substring(3, 2);
        string anoStr = dataDeNascimentoStr.Substring(6, 4);
        try {
            short dia = Convert.ToInt16(diaStr);
            short mes = Convert.ToInt16(mesStr);
            short ano = Convert.ToInt16(anoStr);
            var dataDeNascimentoDate = new DateTime(ano, mes, dia);
            Console.WriteLine(dataDeNascimentoDate.DayOfWeek);
        } catch (Exception e) {
            Console.WriteLine("Erro. Digite a data no formato DD/MM/AAAA");
            Console.WriteLine(e.ToString());
        }
    }

    public static void aula04c() {
        Console.WriteLine("\n\tTeste de Operadores Aritméticos");

        int i = 3;
        Console.WriteLine(i);
        Console.WriteLine(i++);
        Console.WriteLine(i);

        int j = 4;
        Console.WriteLine(j);
        Console.WriteLine(++j);
        Console.WriteLine(j);

        i = 3;
        Console.WriteLine(i);
        Console.WriteLine(i--);
        Console.WriteLine(i);

        j = 4;
        Console.WriteLine(j);
        Console.WriteLine(--j);
        Console.WriteLine(j);

        int a = 10;
        a += 20; // a = a + 20;
        Console.WriteLine(a);
    }

    public static void aula04d() {
        Console.WriteLine("\n\tExercício 02: ");
        /* EXERCÍCIO 02:
        1. Peça um número
        2. Converta para inteiro
        3. Exiba o resto da divisão por 2
        */

        Console.Write("Digite um número: ");
        int.TryParse(Console.ReadLine(), out int n);

        Console.WriteLine($"O resto da divisão de {n} por 2 é {n % 2}.");
    }

    public static void aula04e() {
        Console.WriteLine("\n\tTeste de Operadores Relacionais e Lógicos");
        int a = 10;
        int b = 20;

        Console.WriteLine(a == b);
        Console.WriteLine(a != b);
        Console.WriteLine(a > b || b > 10);
        Console.WriteLine(a < b && b > 10);
        Console.WriteLine(a < b && b < 10);
    }

    public static void aula04f() {
        Console.WriteLine("\n\tExercício 03: ");
        /* EXERCÍCIO 03:
        1. Peça um número
        2. Peça outro número
        3. Converta os números para inteiro
        4. Exiba True se o primeiro número for maior ou igual ao segundo número e False se for menor
        */

        Console.Write("Digite um número: ");
        int.TryParse(Console.ReadLine(), out int n1);
        Console.Write("Digite outro número: ");
        int.TryParse(Console.ReadLine(), out int n2);

        Console.WriteLine($"{n1} >= {n2}: {n1 >= n2}");
    }

    public static void aula04g() {
        Console.WriteLine("\n\tExercício 03: ");
        /* DESAFIO 01:
        1. Peça um número
        2. Converta para inteiro
        3. Exiba True se for par e False se for ímpar
        */

        Console.Write("Digite um número: ");
        int.TryParse(Console.ReadLine(), out int n);

        Console.WriteLine((n % 2 == 0) ? "Par" : "Ímpar");

        // ou
        // bool parOuImpar = (n % 2) == 0;
        // Console.WriteLine($"O número {n} é par? {parOuImpar}");
    }

    public static void aula04h() {
        Console.WriteLine("\n\tExercício 04: ");
        /* DESAFIO 02:
        1. Peça um número
        2. Peça outro número
        3. Exiba True se o primeiro número for maior que segundo número e o segundo número for par
        */

        Console.Write("Digite um número: ");
        int.TryParse(Console.ReadLine(), out int n1);
        Console.Write("Digite outro número: ");
        int.TryParse(Console.ReadLine(), out int n2);

        Console.WriteLine((n2 % 2) == 0 && n1 > n2);
    }

    public static void aula04i() {
        Console.WriteLine("\n\tExercício 05: ");
        /* DESAFIO 03:
        1. Repita o exercício anterior utilizando um validador Try Catch
        */

        try {
            Console.Write("Digite um número: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite outro número: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((n2 % 2) == 0 && n1 > n2);
        } catch (Exception e) {
            Console.WriteLine("O valor digitado não é válido. Por favor, digite um número inteiro.");
        }
    }

    public static void aula04j() {
        Console.WriteLine("\n\tExercício 06: ");
        /* DESAFIO 04:
        1. Repita o exercício anterior utilizando um validador de sua escolha
        */

        int n1, n2;
        do {
            Console.Write("Digite um número inteiro (n1): ");
        } while (!int.TryParse(Console.ReadLine(), out n1));

        do {
            Console.Write("Digite outro número inteiro (n2): ");
        } while (!int.TryParse(Console.ReadLine(), out n2));

        Console.WriteLine((n2 % 2) == 0 && n1 > n2);
    }

}