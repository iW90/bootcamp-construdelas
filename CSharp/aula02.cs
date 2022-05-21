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

        // //Fazer algo para converter de string para inteiro o 'a' e o 'b'
        // //Fazera soma e armazenar em 'c'
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


/*
    DATA TYPES
    • System.Boolean:   [bool]      True ou False (2bits)

    • System.SByte:     [sbyte]     Inteiros (8bits)
    • System.Byte:      [byte]      Inteiros positivos (8bits)

    • System.Decimal:   [decimal]   Números fracionados precisos (96bits) //obrigatória a letra M no final
    • System.Double:    [double]    Números fracionados imprecisos (64bits) //separa as casas decimais por ponto
    • System.Single:    [float]     Números fracionados imprecisos (32bits) //obrigatória a letra F no final

    • System.Int16:     [short]     Inteiros (16bits)   //pode usar o _ no lugar de . para separar milhar 1_000
    • System.Int32:     [int]       Inteiros (32bits)
    • System.Int64:     [long]      Inteiros (64bits) //opcional o uso da letra L no final

    • System.UInt16:    [ushort]    Inteiros positivos (32bits)
    • System.UInt32:    [uint]      Inteiros positivos (32bits)
    • System.UInt64:    [ulong]     Inteiros positivos (64bits)

    • System.Char:      [char]      Unicode character (16bits)

    • System.DateTime:  [n/a]       De (Jan 1 100) até (Dec 31 9999)
    • System.String:    [string]    Reference Type
    • System.Object:    [object]    Reference Type
    • System.Struct     [struct]    Reference Type
    • System.Enum       [enum]      Reference Type

    MOSTRANDO O TIPO DE UMA VARIÁVEL
        Identificador.TypeOf

    MOSTRANDO O TAMANHO MÍNIMO E MÁXIMO DE CADA TIPO
        type.MinValue //mostra o valor mínimo
        type.MaxValue //mostra o valor máximo
        • No lugar de 'type' basta colocar o tipo desejado, e usar no 'Console.Write'

    DECLARAÇÃO DE VARIÁVEIS
    Pode utilizar o var, sem especificar um tipo:
        var identificador = valor;
        • Mas é obrigatório atribuir um valor imediatamente na declaração.
    
    Ou pode especificar o tipo (recomendável para economizar espaços de memória):
        type identificador = valor;

    DECLARAÇÃO DE CONSTANTES
    Funciona da mesma maneira que as variáveis, mas adiciona-se a palavra "const" antes:
        const type identificador = valor;

    MOSTRAR O TIPO DA VARIÁVEL/CONSTANTE
        identificador.GetType();

    NOMECLATURA DE VARIÁVEIS E CONSTANTES
    • Começa com letra ou underline
    • Case Sensitive
    • Aceita apenas letras, números e underline
    • Aceita acentuação (mas não é recomendável)
    • Não pode conter espaços
    • Não pode conter símbolos (exceto underline)
    • Não pode usar palavras reservadas
    • Sugerido o uso do CamelCase
    • Uso do @ é aceito, mas somente no início e apenas em caso específico

    CONVERSÃO IMPLÍCITA
    Não é necessária uma coerção, o C# faz automaticamente.
        int a = 10;
        double b = a;
        • Só é possível quando um cabe dentro do outro (se o espaço em memória comporta).
        • Só é possível quando o tipo é compatível (um número decimal sem valor quebrado é compatível com o inteiro)

    CONVERSÃO EXPLÍCITA (TYPECAST)
        double a = 10.555;
        int b = (int) a;

    COERÇÃO EXPLÍCITA (CLASSES AUXILIARES) DE STRING EM INT
    Se houver letras, haverá um erro e a coerção não será feita.
        string inteiroPossivel = "123";
        int identificador = Convert.ToInt32(inteiroPossivel);
        Console.WriteLine(identificador);

        CLASSE CONVERT PARA OUTROS TIPOS
            Convert.ToType //substitua 'type' pelo tipo desejado.

    COERÇÃO EXPLÍCITA (CLASSES AUXILIARES) DE STRING EM INT
    Usando o TryParse, que retorna um booleano informando se foi possível ou não realizar a conversão, e não exibe erro.
    Estrutura: TryParse(varEntrada, out varSaida);
        int numero = 0;
        string numeroString = "123";
        Console.WriteLine(int.TryParse(numeroString, out numero));
        Console.WriteLine(numero);
 */