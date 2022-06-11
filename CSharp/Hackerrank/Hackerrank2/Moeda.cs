public class Moeda {
    public static string Centavos(string valor)
    {
        string[] valorSeparado = valor.Split(','); //tudo que vier após a vírgula estará em valorSeparado[1]

        int centavos = Convert.ToInt32(valorSeparado[1]);

        int dezenaCent = Convert.ToInt32(valorSeparado[1].Substring(0, 1)); //primeiro dígito
        int unidadeCent = Convert.ToInt32(valorSeparado[1].Substring(1, 1)); //segundo dígito

        if (centavos > 0)
            return (dezenaCent == 0 && unidadeCent == 1) ? Numeros.UnidadeDezena(unidadeCent, dezenaCent) + " CENTAVO" : Numeros.UnidadeDezena(unidadeCent, dezenaCent) + " CENTAVOS";
        return "";
    }

    public static string Reais(string valor)
    {
        string[] valorSeparado = valor.Replace(".", "").Split(' ', ','); //tudo que vier após espaço e antes da vírgula estará em valorSeparado[1]

        ulong reais = Convert.ToUInt64(valorSeparado[1]);
        string reaisStr = valorSeparado[1];

        if (reaisStr.Length % 3 == 1)
            reaisStr = "00" + reaisStr;
        else if (reaisStr.Length % 3 == 2)
            reaisStr = "0" + reaisStr;

 
        string extenso = Numeros.LoopingUniDezCen(reaisStr);


        if (reais > 0)
            return (reais == 1) ? "UM REAL" : $"{extenso} REAIS";
        return "";

    }

}