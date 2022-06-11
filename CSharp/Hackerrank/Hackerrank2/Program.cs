        /* DESAFIO 02
        1. Insira um valor em R$
        2. Leia este valor por extenso
        3. A resposta deve ser no formato:
            Input: R$ 100.509.998,24
            Output: CEM MILHOES, QUINHENTOS E NOVE MIL, NOVECENTOS E NOVENTA E OITO REAIS E VINTE E QUATRO CENTAVOS
        */
        
        //Entrada de dados
        // Console.Write("Digite o valor em reais: ");
        // string valor = Console.ReadLine();

        string num = "R$ 12.302,01";

        //Saída
        Console.WriteLine(hackerrank2.desafio02(num));


public class hackerrank2
{
    public static string desafio02(string valor)
    {

        if (Moeda.Reais(valor) != "" && Moeda.Centavos(valor) == "")
            return $"VALOR: {Moeda.Reais(valor)}";
        else if (Moeda.Reais(valor) == "" && Moeda.Centavos(valor) != "")
            return $"VALOR: {Moeda.Centavos(valor)}";
        else if (Moeda.Reais(valor) != "" && Moeda.Centavos(valor) != "")
            return $"VALOR: {Moeda.Reais(valor)} E {Moeda.Centavos(valor)}";
        else
            return "Insira um numero valido";
    }
}