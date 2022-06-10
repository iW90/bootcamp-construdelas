class Album
{
    private string nomeDoAlbum;
    private string nomeDoArtista;
    public string NomeDoAlbum
    {
        get
        {
            //if estaLogadoNoSpotipie
            return nomeDoAlbum;
            //else
            //throw ExceptionSpotipie("nao logado", "usuario nao está logado");
        }

        set
        {
            //if estaLogadoEEhAdministrador
            nomeDoAlbum = value;
            //else
            //throw ExceptionSpotipie("nao logado ou nao é administrador", "usuario nao está logado ou nao é administrador");
        }
    }

    public string NomeDoArtista
    {
        get
        {
            //if estaLogadoNoSpotipie
            return nomeDoArtista;
            //else
            //throw ExceptionSpotipie("nao logado", "usuario nao está logado");
        }
    }

    public List<Faixa> faixas;

    public Album(string nomeDoAlbum, string nomeDoArtista)
    {
        this.NomeDoAlbum = nomeDoAlbum;
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
    }
}