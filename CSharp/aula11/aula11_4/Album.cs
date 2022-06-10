class Album
{
    public string nomeDoAlbum;
    public string nomeDoArtista;
    public List<Faixa> faixas;

    public Album(string nomeDoAlbum, string nomeDoArtista)
    {
        this.nomeDoAlbum = nomeDoAlbum;
        this.nomeDoArtista = nomeDoArtista;
        this.faixas = new List<Faixa>();
    }

    public void AdicionarFaixa(Faixa faixa)
    {
        faixas.Add(faixa);
    }

    public int DuracaoDoAlbum()
    {
        int duracaoTotal = 0;

    foreach(var faixa in faixas)
    {
        duracaoTotal += faixa.duracaoEmSegundos;
    }

    return duracaoTotal;
    }

    public void TocarAlbum()
    {
        foreach (var faixa in faixas)
        {
            faixa.TocarMusica();
        }

    throw new ExcecaoSpotipie("Erro ao baixar a musica", "erro grave"); //Erro simulado para testar o try_catch

    }

    public static Album LerAlbum()
    {
        Album ret;
        Console.Write("Digite o nome do album: ");
        var nomeAlbum = Console.ReadLine();

        Console.Write("Digite o nome do artista: ");
        var nomeArtista = Console.ReadLine();

        ret = new Album(nomeAlbum, nomeArtista);

        Console.Write("Digite quantas faixas tem o album: ");
        var faixasQtde = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < faixasQtde; i++)
        {
            ret.AdicionarFaixa(Faixa.LerFaixa());
        }

        return ret;
    }
}

class ExcecaoSpotipie : Exception
{
    string tipoDeErro;
    public ExcecaoSpotipie(string mensagem, string tipoDeErro):base(mensagem)
    {
        this.tipoDeErro = tipoDeErro;
    }

    public override string ToString()
    {
        return "ERRO NO SPOTIPIE: " + tipoDeErro + " - " + base.ToString();
            /* Deu erro:ERRO NO SPOTIPIE: erro grave - ExcecaoSpotipie: Erro ao baixar a musica
            at Album.TocarAlbum() in C:\Users\Fulano\...\Album.cs:line 41
            at Program.<Main>$(String[] args) in C:\Users\Fulano\...\Album.cs:line 16 */
    }
}