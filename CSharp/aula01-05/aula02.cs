class aulasA {
    public static void aula02a() {
        Console.WriteLine("\n\tTeste de adição: ");
        int a = 10;
        int b = 20;
        Console.WriteLine(a + b);
        int c = a + b;
        Console.WriteLine(c);
    }

    public static void aula02b() {
        Console.WriteLine("\n\tTestes de tipos: ");
        uint ui = 100;
        float fl = 10.2f; //obrigatório uso da letra f no final
        long l = 45755452222222;
        ulong ul = 45755452222223;
        double d = 11452222.555;
        decimal mon = 1000.15m; //obrigatório uso da letra m no final
        string meuNome = "Ingrid"; //aspas duplas para strings
        char primeiraLetraDoMeuNome = 'I'; //aspas simples para caractere

        Console.WriteLine(ui);
        Console.WriteLine(fl);
        Console.WriteLine(l);
        Console.WriteLine(ul);
        Console.WriteLine(d);
        Console.WriteLine(mon);
        Console.WriteLine(meuNome);
        Console.WriteLine(primeiraLetraDoMeuNome);
    }

    public static void aula02c() {
        Console.WriteLine("\n\tTeste de coerção: ");
        int a = 20;
        double b = a;
        Console.WriteLine(b);

        double c = 10.555;
        int d = (int) c; //se remover a conversão (int), dá erro de compilação.
        Console.WriteLine(d);

        string inteiroPossivel = "123";
        int cont = Convert.ToInt32(inteiroPossivel); //string numérica em int. Se houver letras, não converte.
        Console.WriteLine(cont);

        int numero = 0;
        string numeroString = "123";
        Console.WriteLine(int.TryParse(numeroString, out numero)); //informa se foi possível a conversão com True ou False.
        Console.WriteLine(numero);
    }

    public static void aula02d() {
        string a = Console.ReadLine();
        string b = Console.ReadLine();

        // Fazer algo para converter de string para inteiro o 'a' e o 'b'
        // Fazera soma e armazenar em 'c'
        // int c = Convert.ToInt32(a) + Convert.ToInt32(b);

        //OU
        int aConvertido, bConvertido;
        
        int.TryParse(a, out aConvertido);
        int.TryParse(b, out bConvertido);
        int c = aConvertido + bConvertido;

        //Imprimir 'c'
        Console.WriteLine(c);
    }

    public static void aula02e() {
        // Entrada de dados
        string n = Console.ReadLine(); //ReadLine recebe somente string.

        // Saída de dados
        Console.WriteLine("A variável é {0}", n);
        //ou
        Console.WriteLine($"A variável é {n}");
    }
}