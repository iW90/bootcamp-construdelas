class Assinatura
{
    public static string Iniciais(string nomeCompleto)
    {
        //USANDO FOR
        // string ret = "";
        // var nomeCompletoArr = nomeCompleto.ToCharArray();

        // for (int i = 0; i < nomeCompletoArr.Length; i++) {
        //     if (i == 0 || nomeCompletoArr[i - 1] == ' ') {
        //         ret += nomeCompletoArr[i];
        //     }
        // }
        // return ret;

        //USANDO SPLIT
        string ret = "";
        var nomeCompletoSplit = nomeCompleto.Split(' ');
        foreach (string s in nomeCompletoSplit)
        {
            ret += s[0];
        }
        return ret;
    }
}