/* EXERCÍCIO 02
1. Crie uma classe chamada Assinatura
2. Crie um método estático chamado Iniciais que vai receber o nome completo da pessoa como parâmetro e retornar uma string com as iniciais.
    public static string Iniciais(string nomeCompleto) {}

Tem que funcionar com esse main:
    Console.WriteLine(Assinatura.Iniciais(Console.ReadLine()));

Entrada esperada:
    Thays Tagliaferri de Grazia
Saída esperada:
    TTdG
*/

/*
class Assinatura {
    public static string Iniciais(string nomeCompleto) {
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
        foreach(string s in nomeCompletoSplit) {
            ret += s[0];
        }
        return ret;
    }
}

*/