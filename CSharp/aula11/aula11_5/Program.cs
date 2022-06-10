Console.WriteLine("Seja bem-vindo ao nosso Spotipie!");

Console.Write("Digite quantos albums voce ira cadastrar: ");
int qtdeAlbums = Convert.ToInt32(Console.ReadLine());
List<Album> todosOsAlbuns = new List<Album>();

for (int i = 0; i < qtdeAlbums; i++)
{
    todosOsAlbuns.Add(Album.LerAlbum());
}

foreach (Album album in todosOsAlbuns)
{
    try
    {
        album.TocarAlbum();
    }
    catch (Exception e)
    {
        Console.WriteLine("Deu erro:" + e);
    }
    finally
    {
        Console.WriteLine("Acabei de tocar o album.");
    }

}

foreach (Album album in todosOsAlbuns)
{
    Console.WriteLine(album.NomeDoArtista + " - " + album.NomeDoAlbum );
}