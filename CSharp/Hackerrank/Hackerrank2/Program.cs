using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */

        /* INPUT / OUTPUT */
        // Limite: 0 a 18.446.744.073.709.551.615,99

        // Entrada de dados
        // string num = Console.ReadLine();
        string num = "R$ 56876487,00";

        // Construcao do formato correto
        if (!num.Contains(","))
            num += ",00";
        if (!num.Contains("R$"))
            num = "R$" + num;
        if (!num.Contains(" "))
            num = num.Insert(2, " ");

        // Saida
        if (Reais(num) != "" && Centavos(num) == "")
            Console.WriteLine($"{Reais(num)}");
        else if (Reais(num) == "" && Centavos(num) != "")
            Console.WriteLine($"{Centavos(num)}");
        else if (Reais(num) != "" && Centavos(num) != "")
            Console.WriteLine($"{Reais(num)} E {Centavos(num)}");
        else
            Console.WriteLine("Insira um numero valido");

        /* EXECUCAO: MOEDA */
        // Calculo de centavos
        static string Centavos(string valor)
        {
            string[] valorSeparado = valor.Split(','); //tudo que vier apos a virgula estara em valorSeparado[1]

            if (valorSeparado[1].Length != 2)
                valorSeparado[1] += "0";

            int centavos = Convert.ToInt32(valorSeparado[1]);

            int dezenaCent = Convert.ToInt32(valorSeparado[1].Substring(0, 1)); //primeiro digito
            int unidadeCent = Convert.ToInt32(valorSeparado[1].Substring(1, 1)); //segundo digito

            if (centavos > 0)
                return (dezenaCent == 0 && unidadeCent == 1) ? UnidadeDezena(unidadeCent, dezenaCent) + " CENTAVO" : UnidadeDezena(unidadeCent, dezenaCent) + " CENTAVOS";
            return "";
        }

        // Calculo de reais
        static string Reais(string valor)
        {
            string[] valorSeparado = valor.Replace(".", "").Split(' ', ','); //tudo que vier apos espaco e antes da virgula estara em valorSeparado[1]

            ulong reais = Convert.ToUInt64(valorSeparado[1]);
            string reaisStr = valorSeparado[1];

            if (reaisStr.Length % 3 == 1)
                reaisStr = "00" + reaisStr;
            else if (reaisStr.Length % 3 == 2)
                reaisStr = "0" + reaisStr;

            string extenso = LoopingUniDezCen(reaisStr);

            if (reais > 0)
                return (reais == 1) ? "UM REAL" : $"{extenso} REAIS";
            return "";
        }

        /* EXECUCAO: LEITURA DE NUMEROS */
        // Separando em blocos de tres casas decimais
        static string LoopingUniDezCen (string valor)
        {

            string extenso = "";

            int divFix = (valor.Length - 1) / 3; //quantidade de blocos
            int div = (valor.Length - 1) / 3; //bloco
            int bloco =  Convert.ToInt32(valor.Substring(0, 3)); //numero do primeiro bloco
            int centenaBloco = Convert.ToInt32(valor.Substring(0, 1)); //primeiro digito
            int dezenaBloco = Convert.ToInt32(valor.Substring(1, 1)); //segundo digito
            int unidadeBloco = Convert.ToInt32(valor.Substring(2, 1)); //terceiro digito

            // Verifica se precisa do "DE"
            uint deCheck = 0;
            if (valor.Length > 3)
                deCheck = Convert.ToUInt32(valor.Substring(3, valor.Length - 3));


            for (int i = 0; i <= divFix; i++)
            {

                // Verifica se precisa do "E"
                int eCheck0 = 0;
                int eCheck1 = 0;
                int eCheck2 = 0;
                int eCheck3 = 0;

                for (int j = 0; j < 7; j++)
                {

                    if (div > 0 && div < 7)
                    {
                        if (div > 1 && div < 7)
                            eCheck0 = Convert.ToInt32(valor.Substring(3, valor.Length -6));

                        eCheck1 = Convert.ToInt32(valor.Substring(valor.Length - 3, 1));
                        eCheck2 = Convert.ToInt32(valor.Substring(valor.Length - 2, 1));
                        eCheck3 = Convert.ToInt32(valor.Substring(valor.Length - 1, 1));
                    }
                }

                bool option1 = eCheck1 == 0 && (eCheck2 != 0 || eCheck3 != 0);
                bool option2 = eCheck1 == 1 && (eCheck2 == 0 && eCheck3 == 0);

                // Montagem do numero por extenso
                if (div == 0)
                {
                    if (bloco != 0)
                        extenso += $"{UniDezCen(unidadeBloco, dezenaBloco, centenaBloco)}";
                    else
                        extenso += "";
                }
                else if (div == 1)
                {
                    if (bloco == 1)
                    {
                        if (deCheck == 0)
                            extenso += $"MIL";
                        else if (option1 || option2)
                            extenso += $"MIL E ";
                        else
                            extenso += $"MIL, ";
                    }
                    else if (bloco > 1)
                    {
                        if (deCheck == 0)
                            extenso += $"{UniDezCen(unidadeBloco, dezenaBloco, centenaBloco)} MIL";
                        else if (option1 || option2)
                            extenso += $"{UniDezCen(unidadeBloco, dezenaBloco, centenaBloco)} MIL E ";
                        else
                            extenso += $"{UniDezCen(unidadeBloco, dezenaBloco, centenaBloco)} MIL, ";
                    }
                    else
                        extenso += "";
                }
                else if (div == 2)
                {
                    if (bloco == 1)
                        if (deCheck == 0)
                            extenso += $"{UniDezCen(unidadeBloco, dezenaBloco, centenaBloco)} MILHAO DE";
                        else if ((option1 && eCheck0 == 0) || (option2 && eCheck0 == 0))
                            extenso += $"{UniDezCen(unidadeBloco, dezenaBloco, centenaBloco)} MILHAO E ";
                        else
                            extenso += $"{UniDezCen(unidadeBloco, dezenaBloco, centenaBloco)} MILHAO, ";
                    else if (bloco > 1)
                        if (deCheck == 0)
                            extenso += $"{UniDezCen(unidadeBloco, dezenaBloco, centenaBloco)} MILHOES DE";
                        else if ((option1 && eCheck0 == 0) || (option2 && eCheck0 == 0))
                            extenso += $"{UniDezCen(unidadeBloco, dezenaBloco, centenaBloco)} MILHOES E ";
                        else
                            extenso += $"{UniDezCen(unidadeBloco, dezenaBloco, centenaBloco)} MILHOES, ";
                    else
                        extenso += "";
                }
                else if (div == 3)
                {
                    if (bloco == 1)
                        if (deCheck == 0)
                            extenso += $"{UniDezCen(unidadeBloco, dezenaBloco, centenaBloco)} BILHAO DE";
                        else if ((option1 && eCheck0 == 0) || (option2 && eCheck0 == 0))
                            extenso += $"{UniDezCen(unidadeBloco, dezenaBloco, centenaBloco)} BILHAO E ";
                        else
                            extenso += $"{UniDezCen(unidadeBloco, dezenaBloco, centenaBloco)} BILHAO, ";
                    else if (bloco > 1)
                        if (deCheck == 0)
                            extenso += $"{UniDezCen(unidadeBloco, dezenaBloco, centenaBloco)} BILHOES DE";
                        else if ((option1 && eCheck0 == 0) || (option2 && eCheck0 == 0))
                            extenso += $"{UniDezCen(unidadeBloco, dezenaBloco, centenaBloco)} BILHOES E ";
                        else
                            extenso += $"{UniDezCen(unidadeBloco, dezenaBloco, centenaBloco)} BILHOES, ";
                    else
                        extenso += "";
                }
                else if (div == 4)
                {
                    if (bloco == 1)
                        if (deCheck == 0)
                            extenso += $"{UniDezCen(unidadeBloco, dezenaBloco, centenaBloco)} TRILHAO DE";
                        else if ((option1 && eCheck0 == 0) || (option2 && eCheck0 == 0))
                            extenso += $"{UniDezCen(unidadeBloco, dezenaBloco, centenaBloco)} TRILHAO E ";
                        else
                            extenso += $"{UniDezCen(unidadeBloco, dezenaBloco, centenaBloco)} TRILHAO, ";
                    else if (bloco > 1)
                        if (deCheck == 0)
                            extenso += $"{UniDezCen(unidadeBloco, dezenaBloco, centenaBloco)} TRILHOES DE";
                        else if ((option1 && eCheck0 == 0) || (option2 && eCheck0 == 0))
                            extenso += $"{UniDezCen(unidadeBloco, dezenaBloco, centenaBloco)} TRILHOES E ";
                        else
                            extenso += $"{UniDezCen(unidadeBloco, dezenaBloco, centenaBloco)} TRILHOES, ";
                    else
                        extenso += "";
                }
                else if (div == 5)
                {
                    if (bloco == 1)
                        if (deCheck == 0)
                            extenso += $"{UniDezCen(unidadeBloco, dezenaBloco, centenaBloco)} QUARTILHAO DE";
                        else if ((option1 && eCheck0 == 0) || (option2 && eCheck0 == 0))
                            extenso += $"{UniDezCen(unidadeBloco, dezenaBloco, centenaBloco)} QUARTILHAO E ";
                        else
                            extenso += $"{UniDezCen(unidadeBloco, dezenaBloco, centenaBloco)} QUARTILHAO, ";
                    else if (bloco > 1)
                        if (deCheck == 0)
                            extenso += $"{UniDezCen(unidadeBloco, dezenaBloco, centenaBloco)} QUARTILHOES DE";
                        else if ((option1 && eCheck0 == 0) || (option2 && eCheck0 == 0))
                            extenso += $"{UniDezCen(unidadeBloco, dezenaBloco, centenaBloco)} QUARTILHOES E ";
                        else
                            extenso += $"{UniDezCen(unidadeBloco, dezenaBloco, centenaBloco)} QUARTILHOES, ";
                    else
                        extenso += "";
                }
                else
                {
                    if (bloco == 1)
                        if (deCheck == 0)
                            extenso += $"{UniDezCen(unidadeBloco, dezenaBloco, centenaBloco)} QUINTILHAO DE";
                        else if ((option1 && eCheck0 == 0) || (option2 && eCheck0 == 0))
                            extenso += $"{UniDezCen(unidadeBloco, dezenaBloco, centenaBloco)} QUINTILHAO E ";
                        else
                            extenso += $"{UniDezCen(unidadeBloco, dezenaBloco, centenaBloco)} QUINTILHAO, ";
                    else if (bloco > 1)
                        if (deCheck == 0)
                            extenso += $"{UniDezCen(unidadeBloco, dezenaBloco, centenaBloco)} QUINTILHOES DE";
                        else if ((option1 && eCheck0 == 0) || (option2 && eCheck0 == 0))
                            extenso += $"{UniDezCen(unidadeBloco, dezenaBloco, centenaBloco)} QUINTILHOES E ";
                        else
                            extenso += $"{UniDezCen(unidadeBloco, dezenaBloco, centenaBloco)} QUINTILHOES, ";
                    else
                        extenso += "";
                }

                // Atualizacao do bloco seguinte
                valor = valor.Substring(3, valor.Length -3); //eliminando os tres primeiros digitos
                if (valor.Length >= 3)
                {
                    div--; //passa para o bloco seguinte
                    bloco =  Convert.ToInt32(valor.Substring(0, 3)); //primeiro bloco
                    centenaBloco = Convert.ToInt32(valor.Substring(0, 1)); //primeiro digito
                    dezenaBloco = Convert.ToInt32(valor.Substring(1, 1)); //segundo digito
                    unidadeBloco = Convert.ToInt32(valor.Substring(2, 1)); //terceiro digito
                }
            }
            return extenso;
        }

        // Montagem dos numeros com tres casas decimais
        static string UniDezCen(int unidade, int dezena, int centena)
        {
            if (dezena == 0 && unidade == 0)
                return centena == 1 ? "CEM" : Centena(centena);
            return centena == 0 ? UnidadeDezena(unidade, dezena) : Centena(centena) + " E " + UnidadeDezena(unidade, dezena);
        }

        // Montagem dos numeros com duas casas decimais
        static string UnidadeDezena(int unidade, int dezena)
        {

            if ((dezena >= 1 && dezena <= 9) && unidade == 0)
                return Dezena(dezena);// switch dezenaredonda [DEZ, VINTE, TRINTA, ...]
            else if (dezena == 0 && (unidade > 0 && unidade < 10))
                return Unidade(unidade); // switch unidade [UM, DOIS, TRES, ...]
            else if (dezena == 1 && (unidade > 0 && unidade < 10))
                return DezenaUm(unidade); // switch dezena [ONZE, DOZE, TREZE, ...]
            else if ((dezena > 1 && dezena < 10) && (unidade > 0 && unidade < 10))
                return Dezena(dezena) + " E " + Unidade(unidade); // switch dezena1 + "E" + switch unidade [VINTE E UM, VINTE E DOIS, VINTE E TRES, ...]
            else
                return "erro";
        }

        // Numeros por extenso
        static string Centena(int centena)
        {
            switch (centena)
            {
                case 1:
                    return "CENTO";
                case 2:
                    return "DUZENTOS";
                case 3:
                    return "TREZENTOS";
                case 4:
                    return "QUATROCENTOS";
                case 5:
                    return "QUINHENTOS";
                case 6:
                    return "SEISCENTOS";
                case 7:
                    return "SETECENTOS";
                case 8:
                    return "OITOCENTOS";
                case 9:
                    return "NOVECENTOS";
                default:
                    return "erro";
            }
        }

        static string Dezena(int dezena)
        {
            switch (dezena)
            {
                case 1:
                    return "DEZ";
                case 2:
                    return "VINTE";
                case 3:
                    return "TRINTA";
                case 4:
                    return "QUARENTA";
                case 5:
                    return "CINQUENTA";
                case 6:
                    return "SESSENTA";
                case 7:
                    return "SETENTA";
                case 8:
                    return "OITENTA";
                case 9:
                    return "NOVENTA";
                default:
                    return "erro";
            }
        }

        static string DezenaUm(int unidade)
        {
            switch (unidade)
            {
                case 1:
                    return "ONZE";
                case 2:
                    return "DOZE";
                case 3:
                    return "TREZE";
                case 4:
                    return "QUATORZE";
                case 5:
                    return "QUINZE";
                case 6:
                    return "DEZESSEIS";
                case 7:
                    return "DEZESSETE";
                case 8:
                    return "DEZOITO";
                case 9:
                    return "DEZENOVE";
                default:
                    return "erro";
            }
        }

        static string Unidade(int unidade)
        {
            switch (unidade)
            {
                case 1:
                    return "UM";
                case 2:
                    return "DOIS";
                case 3:
                    return "TRES";
                case 4:
                    return "QUATRO";
                case 5:
                    return "CINCO";
                case 6:
                    return "SEIS";
                case 7:
                    return "SETE";
                case 8:
                    return "OITO";
                case 9:
                    return "NOVE";
                default:
                    return "erro";
            }
        }
    }
}