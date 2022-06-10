# ORIENTAÇÃO A OBJETOS - REFERENTE À AULA 11


## Agregação

O atributo de uma classe é outra classe: Usamos o objeto de uma classe dentro de outra classe.

- Exemplo: Classe "Endereco" agregada à classe "Pessoa".


## Composição

É o mesmo que agregação, porém o objeto da classe aninhada não faria sentido se existisse fora da classe pai.

- Exemplo: Classe "Álbum" que tenha uma classe filha "Faixas".


## Gerenciando exceções


## Propriedades

[Documentação](https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/classes-and-structs/using-properties)

===

Deu erro:System.Exception: Erro ao baixar a musica
at Album.TocarAlbum() in T:\Users\Thays\source\repos\ConsoleApp4\ConsoleApp4\Album.cs:line 41
at Program.<Main>$(String[] args) in T:\Users\Thays\source\repos\ConsoleApp4\ConsoleApp4\Program.cs:line 16

==========


Deu erro:ERRO NO SPOTIPIE: erro grave - ExcecaoSpotipie: Erro ao baixar a musica
at Album.TocarAlbum() in T:\Users\Thays\source\repos\ConsoleApp4\ConsoleApp4\Album.cs:line 41
at Program.<Main>$(String[] args) in T:\Users\Thays\source\repos\ConsoleApp4\ConsoleApp4\Program.cs:line 16


===========


class Album
{​
public string nomeDoAlbum;
public string nomeDoArtista;
public List<Faixa> faixas;
 public Album(string nomeDoAlbum, string nomeDoArtista)
{​
this.nomeDoAlbum = nomeDoAlbum;
this.nomeDoArtista = nomeDoArtista;
this.faixas = new List<Faixa>();
}​
 public void AdicionarFaixa(Faixa faixa)
{​
faixas.Add(faixa);
}​
 public int DuracaoDoAlbum()
{​
int duracaoTotal = 0;
foreach(var faixa in faixas)
{​
duracaoTotal += faixa.duracaoEmSegundos;
}​
return duracaoTotal;
}​
 public void TocarAlbum()
{​
foreach (var faixa in faixas)
{​
faixa.TocarMusica();
}​
//throw new ExcecaoSpotipie("Erro ao baixar a musica", "erro grave");
}​
 public static Album LerAlbum()
{​
Album ret;
Console.WriteLine("Digite o nome do album");
var nomeAlbum = Console.ReadLine();
Console.WriteLine("Digite o nome do artista");
var nomeArtista = Console.ReadLine();
ret = new Album(nomeAlbum, nomeArtista);
Console.WriteLine("Digite quantas faixas tem o album:");
var faixasQtde = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < faixasQtde; i++)
{​
ret.AdicionarFaixa(Faixa.LerFaixa());
}​
return ret;
}​
}​
class ExcecaoSpotipie : Exception
{​
string tipoDeErro;
public ExcecaoSpotipie(string mensagem, string tipoDeErro):base(mensagem)
{​
this.tipoDeErro = tipoDeErro;
}​
 public override string ToString()
{​
return "ERRO NO SPOTIPIE: " + tipoDeErro + " - " + base.ToString();
}​
}​

============


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
Console.WriteLine("Digite o nome da faixa:");
var nomeFaixa = Console.ReadLine();
Console.WriteLine("Digite a duracao da faixa:");
var duracaoEmSegundos = Convert.ToInt32(Console.ReadLine());
ret = new Faixa(nomeFaixa, duracaoEmSegundos);
Console.WriteLine("Quantas participacoes tem essa faixa");
var qtdeParticipacoes = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < qtdeParticipacoes; i++)
{
Console.WriteLine("Digite o nome da participacao");
ret.AdicionarParticipacao(Console.ReadLine());
}
return ret;
}
}

=======

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
Console.WriteLine("Acabei de tocar o album");
}

}

===

## PARTE 2

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
Console.WriteLine("Acabei de tocar o album");
}

}

foreach (Album album in todosOsAlbuns)
{
Console.WriteLine(album.NomeDoArtista + " - " + album.NomeDoAlbum );
}

===


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
Console.WriteLine("Digite o nome da faixa:");
var nomeFaixa = Console.ReadLine();
Console.WriteLine("Digite a duracao da faixa:");
var duracaoEmSegundos = Convert.ToInt32(Console.ReadLine());
ret = new Faixa(nomeFaixa, duracaoEmSegundos);
Console.WriteLine("Quantas participacoes tem essa faixa");
var qtdeParticipacoes = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < qtdeParticipacoes; i++)
{
Console.WriteLine("Digite o nome da participacao");
ret.AdicionarParticipacao(Console.ReadLine());
}
return ret;
}
}

===


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