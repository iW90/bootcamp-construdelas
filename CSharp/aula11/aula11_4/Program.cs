Console.WriteLine("Seja bem-vindo(a) ao nosso Spotipie!");

Console.Write("Digite quantos albums voce ira cadastrar: ");
int qtdeAlbums = Convert.ToInt32(Console.ReadLine());

List<Album> todosOsAlbuns = new List<Album>();

for (int i = 0; i < qtdeAlbums; i++)
{
    todosOsAlbuns.Add(Album.LerAlbum());
}

foreach (Album album in todosOsAlbuns)
{
    try //Tenta executar o bloco de código
    {
        album.TocarAlbum();
    }
    catch (Exception e) //Se der exceção (erro), executa o bloco de código
    {
        Console.Write("Deu erro:" + e);
            /* Deu erro:System.Exception: Erro ao baixar a musica
            at Album.TocarAlbum() in C:\Users\Fulano\...\Album.cs:line 41
            at Program.<Main>$(String[] args) in C:\Users\Fulano\...\Album.cs:line 16 */
    }
    finally //O bloco de código é executado independente de dar erro ou não
    {
        Console.Write("Acabei de tocar o album."); 
    }
}