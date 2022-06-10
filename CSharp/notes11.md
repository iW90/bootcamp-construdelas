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