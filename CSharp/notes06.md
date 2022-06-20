# ORIENTAÇÃO A OBJETOS

Características da POO:

- Confiável
- Oportuno
- Manutenível
- Extensível
- Reutilizável
- Natural


## Classes

Classe é uma forma de organizar os conteúdos de um código, separando por "família".

Dentro da classe, podemos criar Os atribtutos (variáveis) e métodos (funções) que servirão de molde para criação de objetos.

Toda classe é em camelCase e iniciada por letra maiúscula.

```csharp
class NomeDaClasse {
    //atributos são as variáveis
    int identificador1;
    int identificador2;

    //funções são os métodos, que recebem um tipo ou void
    void metodo() {
        //código para montar o novo objeto
    }
}
```


## Objetos

Sempre que 'instanciarmos' um objeto (utiliza-se o "new" relacionando a uma classe), estaremos criando um novo objeto de acordo com as características da classe referenciada. Portanto não existe um objeto se não houver uma classe relacionada.

```csharp
NomeDaClasse objeto = new NomeDaClasse(); //NomeDaClasse funciona como um tipo.
Integer num = new Integer(3); //Integer é classe (Wrapper Class)
```


### Vetor de Objetos

Armazena-se vários objetos.

```csharp
NomeDaClasse ident[] = new NomeDaClasse[5]; //Declara o array com 5 espaços
ident[0] = new NomeDaClasse (valores); //Instancia um objeto no índice 0 do array
```


## Struct x Class

Structs funcionam simplificadamente da mesma forma que uma classe, exceto que:

* Struct passa por valor;

* Class passa por referência;


---


### Erro

> Apenas uma unidade de compilação pode ter instruções de nível superior.

Ou seja, declarações fora de um objeto só pode existir na Main, e não nos demais arquivos.cs