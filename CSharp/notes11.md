# ORIENTAÇÃO A OBJETOS - REFERENTE À AULA 11


## Agregação

As informações de um objeto (objeto-todo) precisam ser complementados pelas informações contidas em um ou mais objetos de outra classe (objetos-parte). Ou, em outras palavras, o atributo de uma classe é outra classe: Usamos o objeto de uma classe dentro de outra classe.

Representa um vínculo fraco entre duas classes.

- Exemplo: Classe "Endereco" agregada à classe "Pessoa".


## Composição

É o mesmo que agregação, porém o objeto da classe aninhada não faria sentido se existisse fora da classe pai. É também um relacionamento caracterizado comoparte/todo, mas, neste caso, o todo é responsável pelo ciclo de vida da parte.

Representa um vínculo forte entre duas classes.

- Exemplo: Classe "Álbum" que tenha uma classe filha "Faixas".


## Gerenciando exceções

No C#, os erros são propagados pelo programa usando um mecanismo chamado "exceções".

```csharp
try //Tenta executar o bloco de código
{
    //abre um arquivo em C:\Users\Fulano\...\teste.txt
    //escreverno arquivo
}
catch(Exception e) //Se der exceção (erro), executa o bloco de código
{
    Console.WriteLine("Deuerro:"+ e);
}
finally //O bloco de código é executado independente de dar erro ou não
{
    //se conseguiu abrir o arquivo
        //fecharo arquivo
}

    //Erro simulado para testar o try_catch_finally
    throw new ExcecaoSpotipie("Erro ao baixar a musica", "erro grave");

            /* Deu erro:System.Exception: Erro ao baixar a musica
            at Album.TocarAlbum() in C:\Users\Fulano\...\Album.cs:line 41
            at Program.<Main>$(String[] args) in C:\Users\Fulano\...\Album.cs:line 16 */
```

## Propriedades

> Não entendi bem ainda 🤔

[Documentação](https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/classes-and-structs/using-properties)

```csharp
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
```