class hackerrank {
    public static void desafio01() {
        /* DESAFIO 01
        1. Insira uma palavra ou texto
        2. Verifique se e um palindromo
        3. Conte quantas letras faltam para que se torne um palindromo
        4. A resposta deve ser no formato {TRUE - 0} ou {FALSE - 1}, {FALSE - 2}, etc.
        */

        Console.Write("Digite o conteúdo a ser verificado: ");
        string content = Console.ReadLine();

        // Quantidade de alterações que faltam para ser um palíndromo:
        int numChanges = 0;
        for (int ltr = 0, rtl = content.Length - 1; ltr < rtl; ltr++, rtl--) {
            if (content[ltr] != content[rtl]) {
                numChanges++;
            }
        }
        
        // Verificação se é ou não é palíndromo:
        string palindromo;
        if (numChanges == 0) {
            palindromo = "TRUE";
        } else {
            palindromo = "FALSE";
        }

        // Exibição de resultado no console:
        Console.WriteLine($"{palindromo} - {numChanges}");
    }

    public static void desafio02() {

    }
}