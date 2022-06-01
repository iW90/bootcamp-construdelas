# ORIENTAÇÃO A OBJETOS - REFERENTE À AULA 06

> Apenas uma unidade de compilação pode ter instruções de nível superior.

Ou seja, declarações fora de um objeto só pode existir na Main, e não nos demais arquivos.cs

## Diferença Struct x Class:

* Struct passa por valor;

* Class passa por referência;

## Construtores

**Sempre** que uma classe ou struct é criada, o construtor é chamado.

Uma classe ou struct podem ter vários construtores que usam argumentos diferentes.

Os construtores permitem que o programador defina valores padrão, limite a instanciação e grave códigos flexíveis e fáceis de ler.

São, simplificadamente, o "título" ou "etiqueta" das informações.

```csharp
public class Person {
    private string last; //atributo
    private string first; //atributo

    public Person (string lastName, string first) { //método construtor
        last = lastName;
        this.first = first; //se usar o "this", pode usar o mesmo nome no parâmetro
    }

   // Restante do código de implementação da classe vai daqui em diante.
}
```

