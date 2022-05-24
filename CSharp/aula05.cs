class aulasD {
    public static void aula05a() {
        Console.WriteLine("\n\tTeste de if-else: ");

        Console.WriteLine("Digite um número ");
        var umNumero = Console.ReadLine();
        Console.WriteLine("Digite outro número");
        var outroNumero = Console.ReadLine();

        if (int.TryParse(umNumero, out int umNumeroInt) == false)
            Console.WriteLine("Digite um número válido!");
        else
            if (int.TryParse(outroNumero, out int outroNumeroInt) == false)
                Console.WriteLine("Digite outro número válido!");
            else
                Console.WriteLine(umNumeroInt > outroNumeroInt && outroNumeroInt % 2 == 0);
    }

    public static void aula05b() {
        Console.WriteLine("\n\tTeste de switch-case: ");

        var mes = Console.ReadLine();
        var mesMinusculo = mes.ToLower();

        switch (mes) {
            case "janeiro":
            case "março":
            case "maio":
            case "julho":
            case "agosto":
            case "outubro":
            case "dezembro":
                Console.WriteLine("Este mês tem 31 dias");
                break;
            case "fevereiro":
                Console.WriteLine("Este mês tem 28 ou 29 dias");
                break;
            case "abril":
            case "junho":
            case "setembro":
            case "novembro":
                Console.WriteLine("Este mês tem 30 dias");
                break;
            default:
                Console.WriteLine("Digite um mês válido");
                break;
        }
    }


    public static void aula05c() {
        Console.WriteLine("\n\tExercício 01: ");
        /* EXERCÍCIO 01
        1. Peça um número
        2. Informe se ele é par ou ímpar sem utilizar %
        3. Utilize switch-case */

        Console.Write("Digite um número: ");
        string n = Console.ReadLine();

        int.TryParse(n.Substring((n.Length -1), 1), out int digFinal);

        switch (digFinal) {
            case 2:
            case 4:
            case 6:
            case 8:
            case 0:
                Console.WriteLine("Este número é par");
                break;
            default:
                Console.WriteLine("Este número é ímpar");
                break;
        }
    }

    public static void aula05d() {
        Console.WriteLine("\n\tTeste de looping for: ");

        Console.WriteLine("Digite um número: ");
        var numeroStr = Console.ReadLine();

        var numero = Convert.ToInt32(numeroStr);

        for(int i = 0; i < numero; i++) {
            Console.WriteLine($"Olha aqui eu no loop - {i}");
        }
    }

    public static void aula05e() {
        Console.WriteLine("\n\tExercício 02: ");
        /* EXERCÍCIO 02
        1. Leia um número
        2. Leia outro número
        3. Converta ambos para inteiro
        4. Imprima a multiplicação dos dois números sem usar (*) */

        Console.Write("Digite um número: ");
        int.TryParse(Console.ReadLine(), out int n1);
        Console.Write("Digite outro número: ");
        int.TryParse(Console.ReadLine(), out int n2);

        int soma = 0;
        for (int i = 0; i < n2; i++) {
            soma += n1;
        }

        Console.WriteLine($"A multiplicação entre {n1} e {n2} é {soma}");
    }

    public static void aula05f() {
        Console.WriteLine("\n\tTeste de looping foreach em array: ");

        int[] meuArrayDeInteiros = new int[5];
        meuArrayDeInteiros[0] = 1;
        meuArrayDeInteiros[1] = 2;
        meuArrayDeInteiros[2] = 3;
        meuArrayDeInteiros[3] = 4;
        meuArrayDeInteiros[4] = 5;

        foreach (int meuInteiro in meuArrayDeInteiros) {
            Console.WriteLine(meuInteiro);
        }

    }

    public static void aula05g() {
        Console.WriteLine("\n\tTeste de looping foreach em lista: ");

        List<int> minhaListaDeInteiros = new List<int>();
        minhaListaDeInteiros.Add(1);
        minhaListaDeInteiros.Add(2);
        minhaListaDeInteiros.Add(3);
        minhaListaDeInteiros.Add(4);
        minhaListaDeInteiros.Add(5);

        foreach (int meuInteiro in minhaListaDeInteiros) {
            Console.WriteLine(meuInteiro);
        }
    }

    public static void aula05h() {
        Console.WriteLine("\n\tExercício 03: ");
        /* EXERCÍCIO 03
        1. Leia uma palavra
        2. Exiba a palavra na vertical
        3. Use foreach */

        Console.Write("Digite uma palavra: ");
        string word = Console.ReadLine();

        foreach (int letra in word) {
            Console.WriteLine(letra);
        }

    }

    public static void aula05i() {
        Console.WriteLine("\n\tTeste de looping while: ");

        var minhaPalavra = Console.ReadLine();
        var minhaPalavraArray = minhaPalavra.ToCharArray();

        int i = 0;
        while (i < minhaPalavraArray.Length) {
            Console.WriteLine(i + " - " + minhaPalavraArray[i]);
            i++;
        }
    }

    public static void aula05j() {
        Console.WriteLine("\n\tTeste de looping do-while: ");

        var minhaPalavra = Console.ReadLine();
        var minhaPalavraArray = minhaPalavra.ToCharArray();

        int i = 0;
        do {
            Console.WriteLine(i + " - " + minhaPalavraArray[i]);
            i++;
        } while (i < minhaPalavraArray.Length);
    }

    public static void aula05k() {
        Console.WriteLine("\n\tExercício 04: ");
        /* EXERCÍCIO 04
        1. Digite um número
        2. Vá somando esses números até ele digitar 0
        3. Quando digitar 0, exibe a soma e encerra o programa */

        int soma = 0;
        int n = 0;
        do {
            Console.Write("Digite números para somar. Quando quiser conferir a soma, digite 0: ");
            int.TryParse(Console.ReadLine(), out n);

            soma += n;
        } while (n != 0);

        Console.WriteLine($"A soma dos números foi {soma}");
    }

    public static void aula05l() {
        Console.WriteLine("\n\tTeste da class Math: ");
        //https://docs.microsoft.com/pt-br/dotnet/api/system.math?view=net-6.0

        // Math.Max(a, b) - maior valor entre dois números
        // Math.Min(a, b) - menor valor entre dois números
        // Math.Sqrt(a) - raiz quadrada de a
        // Math.Pow(c, d) - c elevado a d

    }

    public static void aula05m() {
        /* DESAFIO 01: (ax² + bx + c = 0)
        1. Digite um valor para a, b e c
        2. Converta esses valores para inteiro
        3. Calcule o valor de Delta
        4. Calcule o valor da raiz de Delta (delta = b² - 4a.c)
        5. Calcule o valor da primeira raiz e imprima (-b +-(delta))/2a
        6. Calcule o valor da segunda raiz e imprima
            Entrada: A = 1; B = 8; C = -9;
            Saída esperada: 1 e -9; */

            int a, b, c;
            double delta, raizDelta, primeiraRaiz, segundaRaiz;

            Console.Write("Digite a: ");
            int.TryParse(Console.ReadLine(), out a);
            Console.Write("Digite a: ");
            int.TryParse(Console.ReadLine(), out b);
            Console.Write("Digite a: ");
            int.TryParse(Console.ReadLine(), out c);

            delta = Math.Pow(b, 2) - (4 * a * c);
            raizDelta = Math.Sqrt(delta);

            primeiraRaiz = (-b + raizDelta) / (2 * a);
            segundaRaiz = (-b - raizDelta) / (2 * a);

            Console.WriteLine($"Primeira raiz: {primeiraRaiz}\nSegunda raiz: {segundaRaiz}");
    }
}