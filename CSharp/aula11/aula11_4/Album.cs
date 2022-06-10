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

    //throw new ExcecaoSpotipie("Erro ao baixar a musica", "erro grave");
    }

    public static Album LerAlbum()
    {
        Album ret;
        Console.WriteLine("Digite o nome do album");
        var nomeAlbum = Console.ReadLine();
        Console.WriteLine("Digite o nome do artista");
        var nomeArtista = Console.ReadLine();
        ret = new Album(nomeAlbum, nomeArtista);
        Console.WriteLine("Digite quantas faixas tem o album:");
        var faixasQtde = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < faixasQtde; i++)
        {
            ret.AdicionarFaixa(Faixa.LerFaixa());
        }
        return ret;
    }
}