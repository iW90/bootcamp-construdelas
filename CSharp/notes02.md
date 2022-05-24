# ANOTAÇÕES REFERENTES À AULA 02

## Data Types:

| System Type | Type | Size | Description |
|:---|:---:|:---:|:---|
| ——————————— | ———— | ———— | ——————————————————————————————————— |
| System.Boolean | bool | 2bits | True ou False |
| System.SByte | sbyte | 8bits | Inteiros |
| System.Byte | byte | 8bits | Inteiros positivos |
| System.Decimal | decimal | 96bits | Números fracionados precisos //obrigatória a letra M no final |
| System.Double | double | 64bits | Números fracionados imprecisos //separa as casas decimais por ponto |
| System.Single | float | 32bits | Números fracionados imprecisos //obrigatória a letra F no final |
| System.Int16 | short | 16bits | Inteiros //pode usar o _ no lugar de . para separar milhar 1_000 |
| System.Int32 | int | 32bits | Inteiros |
| System.Int64 | long | 64bits | Inteiros //opcional o uso da letra L no final |
| System.UInt16 | ushort | 32bits | Inteiros positivos |
| System.UInt32 | uint | 32bits | Inteiros positivos |
| System.UInt64 | ulong | 64bits | Inteiros positivos |
| System.Char | char | 16bits | Unicode character //colocado entre aspas simples |
| System.DateTime | *n/a* | *n/a* | De (Jan 1 100) até (Dec 31 9999) |
| System.String | string | *n/a* | *Reference Type* //colocado entre aspas duplas |
| System.Object | object | *n/a* | *Reference Type* |
| System.Struct | struct | *n/a* | *Reference Type* |
| System.Enum | enum | *n/a* | *Reference Type* |

## Mostrando o Type de uma variável/constante:

    Identificador.GetType()

## Mostrando o tamanho mínimo ou máximo de cada Type:

    type.MinValue //mostra o valor mínimo
    type.MaxValue //mostra o valor máximo

* No lugar de 'type' basta colocar o tipo desejado, e usar no 'Console.Write'

## Declaração de variáveis:

Pode utilizar o var, sem especificar um tipo:

    var identificador = valor;

* Mas é obrigatório atribuir um valor imediatamente na declaração.

Ou pode especificar o tipo (recomendável para economizar espaços de memória):

    type identificador = valor;

## Declaração de constantes:

Funciona da mesma maneira que as variáveis, mas adiciona-se a palavra "const" antes:

    const type identificador = valor;

## Nomenclatura de variáveis e constantes:

* Começa com letra ou underline
* Case Sensitive
* Aceita apenas letras, números e underline
* Aceita acentuação (mas não é recomendável)
* Não pode conter espaços
* Não pode conter símbolos (exceto underline)
* Não pode usar palavras reservadas
* Sugerido o uso do CamelCase
* Uso do @ é aceito, mas somente no início e apenas em caso específico

## Coerção implícita:

Não é necessária uma coerção, o C# faz automaticamente.

    int a = 10;
    double b = a;

* Só é possível quando um cabe dentro do outro (se o espaço em memória comporta).
* Só é possível quando o tipo é compatível (um número decimal sem valor quebrado é compatível com o inteiro)

## Coerção explícita (Typecast):

    double a = 10.555;
    int b = (int) a;

## Coerção explícita (classes auxiliares: Convert) de string em int:

Se houver letras, haverá um erro e a coerção não será feita.

    string inteiroPossivel = "123";
    int identificador = Convert.ToInt32(inteiroPossivel);
    Console.WriteLine(identificador);

### Classe convert para outros tipos:

    Convert.ToType

* substitua 'Type' pelo tipo desejado.

## Coerção explícita (classes auxiliares: TryParse):

Usando o TryParse, que retorna um booleano informando se foi possível ou não realizar a conversão, e não exibe erro.

Estrutura: `TryParse(varEntrada, out varSaida);`

    int numero = 0;
    string numeroString = "123";
    Console.WriteLine(int.TryParse(numeroString, out numero));
    Console.WriteLine(numero);