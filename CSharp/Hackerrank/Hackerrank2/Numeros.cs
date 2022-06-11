public class Numeros {

    public static string LoopingUniDezCen (string num)
    {

        string extenso = "";

        int div = (num.Length - 1) / 3;
        int bloco =  Convert.ToInt32(num.Substring(0, 3)); //primeiro bloco
        int centenaBloco = Convert.ToInt32(num.Substring(0, 1)); //primeiro dígito
        int dezenaBloco = Convert.ToInt32(num.Substring(1, 1)); //segundo dígito
        int unidadeBloco = Convert.ToInt32(num.Substring(2, 1)); //terceiro dígito

        for (int i = 0; i <= num.Length % 7; i++) {
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
                    extenso += $"MIL, ";
                else if (bloco > 1)
                    extenso += $"{UniDezCen(unidadeBloco, dezenaBloco, centenaBloco)} MIL, ";
                else
                    extenso += "";
            }
            else if (div == 2)
            {
                if (bloco == 1)
                    extenso += $"{UniDezCen(unidadeBloco, dezenaBloco, centenaBloco)} MILHAO, ";
                else if (bloco > 1)
                    extenso += $"{UniDezCen(unidadeBloco, dezenaBloco, centenaBloco)} MILHOES, ";
                else
                    extenso += "";
            }
            else if (div == 3)
            {
                if (bloco == 1)
                    extenso += $"{UniDezCen(unidadeBloco, dezenaBloco, centenaBloco)} BILHAO, ";
                else if (bloco > 1)
                    extenso += $"{UniDezCen(unidadeBloco, dezenaBloco, centenaBloco)} BILHOES, ";
                else
                    extenso += "";
            }
            else if (div == 4)
            {
                if (bloco == 1)
                    extenso += $"{UniDezCen(unidadeBloco, dezenaBloco, centenaBloco)} TRILHAO, ";
                else if (bloco > 1)
                    extenso += $"{UniDezCen(unidadeBloco, dezenaBloco, centenaBloco)} TRILHOES, ";
                else
                    extenso += "";
            }
            else if (div == 5)
            {
                if (bloco == 1)
                    extenso += $"{UniDezCen(unidadeBloco, dezenaBloco, centenaBloco)} QUARTILHAO, ";
                else if (bloco > 1)
                    extenso += $"{UniDezCen(unidadeBloco, dezenaBloco, centenaBloco)} QUARTILHOES, ";
                else
                    extenso += "";
            }
            else
            {
                if (bloco == 1)
                    extenso = $"{UniDezCen(unidadeBloco, dezenaBloco, centenaBloco)} QUINTILHAO, ";
                else if (bloco > 1)
                    extenso = $"{UniDezCen(unidadeBloco, dezenaBloco, centenaBloco)} QUINTILHOES, ";
                else
                    extenso = "";
            }

            num = num.Substring(3, num.Length -3); // eliminando os três primeiros dígitos
            if (num.Length >= 3) {
                div = (num.Length - 1) / 3;
                bloco =  Convert.ToInt32(num.Substring(0, 3)); //primeiro bloco
                centenaBloco = Convert.ToInt32(num.Substring(0, 1)); //primeiro dígito
                dezenaBloco = Convert.ToInt32(num.Substring(1, 1)); //segundo dígito
                unidadeBloco = Convert.ToInt32(num.Substring(2, 1)); //terceiro dígito
            }
        }
        return extenso;
    }

    public static string UniDezCen(int unidade, int dezena, int centena)
    {
        if (dezena == 0 && unidade == 0)
            return centena == 1 ? "CEM" : Centena(centena);
        return centena == 0 ? UnidadeDezena(unidade, dezena) : Centena(centena) + " E " + UnidadeDezena(unidade, dezena);
    }

    public static string UnidadeDezena(int unidade, int dezena)
    {

        if ((dezena >= 1 && dezena <= 9) && unidade == 0)
            return Dezena(dezena);// switch dezenaredonda [DEZ, VINTE, TRINTA, ...]
        else if (dezena == 0 && (unidade > 0 && unidade < 10))
            return Unidade(unidade); // switch unidade [UM, DOIS, TRÊS, ...]
        else if (dezena == 1 && (unidade > 0 && unidade < 10))
            return DezenaUm(unidade); // switch dezena [ONZE, DOZE, TREZE, ...]
        else if ((dezena > 1 && dezena < 10) && (unidade > 0 && unidade < 10))
            return Dezena(dezena) + " E " + Unidade(unidade); // switch dezena1 + "E" + switch unidade [VINTE E UM, VINTE E DOIS, VINTE E TRÊS, ...]
        else
            return "erro";
    }

    static string Centena(int centena)
    {
        // CENTENAREDONDA
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
                return "TRÊS";
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