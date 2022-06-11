public class Numeros {


    public static string milhoes (int milhao) {
        if (milhao == 1) {
            return "MILHAO E ";
        } else {
            return "MILHAO E ";
        }
    }

    public static string milhar (int milhar) {
        if (milhar == 1) {
            return "MIL E ";
        } else {
            return "MIL E ";
        }
    }

    public static string uniDezCen(int unidade, int dezena, int centena)
    {
        if (dezena == 0 && unidade == 0)
        {
            if (centena == 1)
            {
                return "CEM";
            }
            else
            {
                return  Centena(centena);
            }
        }
        else
        {
            if (centena == 0)
            {
                return UnidadeDezena(unidade, dezena); //if dezena e unidade
            }
            else
            {
                return Centena(centena) + " E " + UnidadeDezena(unidade, dezena); //switch centena + " E " + if dezena e unidade
            }
        }
    }

    public static string UnidadeDezena(int unidade, int dezena)
    {

        if ((dezena >= 1 && dezena <= 9) && unidade == 0)
        { // 10, 20, 30, ...
            return Dezena(dezena);// switch dezenaredonda [DEZ, VINTE, TRINTA, ...]
        }
        else if (dezena == 0 && (unidade > 0 && unidade < 10))
        { // 00 a 09
            return Unidade(unidade); // switch unidade [UM, DOIS, TRÊS, ...]
        }
        else if (dezena == 1 && (unidade > 0 && unidade < 10))
        { // 11 a 19
            return DezenaUm(dezena); // switch dezena [ONZE, DOZE, TREZE, ...]
        }
        else if ((dezena > 1 && dezena < 10) && (unidade > 0 && unidade < 10))
        { // 21 a 99, exceto anteriores
            return Dezena(dezena) + " E " + Unidade(unidade); // switch dezena1 + "E" + switch unidade [VINTE E UM, VINTE E DOIS, VINTE E TRÊS, ...]
        } else {
            return "erro";
        }
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

    static string DezenaUm(int dezena)
    {
        switch (dezena)
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
}