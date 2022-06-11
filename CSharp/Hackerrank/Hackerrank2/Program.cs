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

        string num = "R$ 02,01";
        string extenso;

        //Saída
        Console.WriteLine(hackerrank2.desafio02(num));


        

public class hackerrank2
{
    public static string desafio02(string valor)
    {

        if (Moeda.Centavos(valor) == "")
        {
            return $"VALOR: {Moeda.Reais(valor)}";
        }
        else if (Moeda.Reais(valor) == "")
        {
            return $"VALOR: {Moeda.Centavos(valor)}";
        }
        else if (Moeda.Reais(valor) == "1 REAL")
        {
            return $"VALOR: {Moeda.Reais(valor)} E {Moeda.Centavos(valor)}";
        }
        else
        {
            return $"VALOR: {Moeda.Reais(valor)} E {Moeda.Centavos(valor)}";
        }


        /*
        int centena = Convert.ToInt32(num.Substring(0, 1)); //último dígito
        int dezena = Convert.ToInt32(num.Substring(1, 1)); //penúltimo dígito
        int unidade = Convert.ToInt32(num.Substring(2, 1)); //antepenúltimo dígito
        */

    }
}