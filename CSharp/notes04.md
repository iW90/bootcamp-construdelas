# ANOTAÇÕES REFERENTES À AULA 04

## Convenções e Nomenclaturas

As classes começam com letra maiúscula no início de cada palavra:

* **Empresa**{}
* **HistoricoDeCompra**{}

Atributos da classe sempre com primeira letra minúscula:

* private string **nomeDaEmpresa**;
* private DateTime **dataDeNascimento**;

Propriedades da classe sempre com primeira letra maiúscula:

* public string **Nome** {get; set;}
* public DateTime **DataDeNascimento** {get; set;}

Métodos com primeira letra maiúscula:

* public string **GetNome**();

Parâmetros do método com primeira letra minúscula:

* public void SetNome(string **nome**);

Variáveis com primeira letra minúscula:

* var **nomeDaVariavel**

## Operadores Aritméticos

| Operador | Descrição |
|:---:|:---|
| ——— | ————————————————— |
| + | Soma |
| - | Subtração |
| * | Multiplicação |
| / | Divisão |
| % | Módulo (resto da divisão) |
| += | Soma a si mesmo a outro valor |
| -= | Subtrai de si mesmo a outro valor |
| *= | Multiplica a si mesmo por outro valor |
| /= | Divide a si mesmo por outro valor |

## Operadores lógicos

| Operador | Descrição |
|:---:|:---|
| ——— | ————————————————— |
| ! | Negação (Not ¬) |
| && | Conjunção (And ∧) |
| || | Disjunção (Or ∨) |

### Operador lógico exclusivo para bitwise

| Operador | Descrição |
|:---:|:---|
| ——— | ————————————————— |
| XOU | Disjunção Exclusiva (XOR ⊻) |

## Operadores relacionais

| Operador | Descrição |
|:---:|:---|
| ——— | ————————————————— |
| == | Igualdade |
| != | Diferença |
| > | Maior que |
| < | Menor que |
| >= | Maior ou igual a |
| <= | Menor ou igual a |
| is | Verificador de tipo ou classe |

## Operador ternário (dicotômico)

```csharp
condição ? true : false;
```