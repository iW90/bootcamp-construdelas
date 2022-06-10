internal class Faixa
{
    public string nomeDaFaixa;
    public List<string> participacoes;
    public int duracaoEmSegundos;

    public Faixa(string nomeDaFaixaParm, int duracaoEmSegundosParm)
    {
        this.nomeDaFaixa = nomeDaFaixaParm;
        this.duracaoEmSegundos = duracaoEmSegundosParm;
        this.participacoes = new List<string>();
    }

    public void AdicionarParticipacao(string nomeDoCantor)
    {
        participacoes.Add(nomeDoCantor);
    }

    public void TocarMusica()
    {
        Console.Beep();
    }

    public static Faixa LerFaixa()
    {
        Faixa ret;
        Console.Write("Digite o nome da faixa: ");
        var nomeFaixa = Console.ReadLine();

        Console.Write("Digite a duracao da faixa: ");
        var duracaoEmSegundos = Convert.ToInt32(Console.ReadLine());

        ret = new Faixa(nomeFaixa, duracaoEmSegundos);

        Console.Write("Quantas participacoes tem essa faixa: ");

        var qtdeParticipacoes = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < qtdeParticipacoes; i++)
        {
            Console.Write("Digite o nome da participacao: ");
            ret.AdicionarParticipacao(Console.ReadLine());
        }

        return ret;
    }
}