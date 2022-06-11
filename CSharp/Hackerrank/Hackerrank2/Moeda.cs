public class Moeda {
    public static string Centavos(string valor)
    {
        string[] valorSeparado = valor.Split(','); //tudo que vier após a vírgula estará em valorSeparado[1]

        int centavos = Convert.ToInt32(valorSeparado[1]);

        int dezenaCent = Convert.ToInt32(valorSeparado[1].Substring(0, 1)); //último dígito
        int unidadeCent = Convert.ToInt32(valorSeparado[1].Substring(1, 1)); //penúltimo dígito

        if (centavos > 0)
            return (dezenaCent == 0 && unidadeCent == 1) ? Numeros.UnidadeDezena(unidadeCent, dezenaCent) + " CENTAVO" : Numeros.UnidadeDezena(unidadeCent, dezenaCent) + " CENTAVOS";
        return "";
    }

    public static string Reais(string valor)
    {
        string[] valorSeparado = valor.Split(' ', ','); //tudo que vier após espaço e antes da vírgula estará em valorSeparado[1]

        ulong reais = Convert.ToUInt64(valorSeparado[1].Replace(".", ""));

        int dezenaReal = Convert.ToInt32(valorSeparado[1].Substring(0, 1)); //último dígito
        int unidadeReal = Convert.ToInt32(valorSeparado[1].Substring(1, 1)); //penúltimo dígito

        if (reais == 0)
            return "";
        else if (reais == 1)
            return "UM REAL";
        else
            return "DOIS REAIS";
    }
}

//            return Numeros.UnidadeDezena(unidadeReal, dezenaReal) + " 2 REAIS";