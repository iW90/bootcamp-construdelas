/* EXERCÍCIO 02
1. Crie uma classe Album
2. Crie uma classe Faixa
3. A classe Album deve ter um array/list de faixas
*/

Console.WriteLine("Seja bem-vindo ao nosso Spotipie");

Console.WriteLine("Digite quantos albums voce ira cadastrar:");
int qtdeAlbums = Convert.ToInt32(Console.ReadLine());
List<Album> todosOsAlbuns = new List<Album>();

for (int i = 0; i < qtdeAlbums; i++)
{
    todosOsAlbuns.Add(Album.LerAlbum());
}

foreach (Album album in todosOsAlbuns)
{
    album.TocarAlbum();
}