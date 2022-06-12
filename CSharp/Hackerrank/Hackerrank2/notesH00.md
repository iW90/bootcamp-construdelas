# ANOTAÇÕES SOBRE O DESAFIO 2 NO HACKERRANK

## TAMANHO MÁXIMO

ulong: De 0 a 18.446.744.073.709.551.615 (18 quinquilhões+)


## Numeros

Os números são divididos de três em três, UDC (unidade, dezena e centena) e depois começam a se repetir.


### Unidade, Dezena e Centena

- Bloco de unidade
    - 1 a 9
- Bloco de dezena
    - dezenaDez (11 a 19)
    - dezena (20, 30, 40)
    - dezena + unidade (21, 22, 23)
- Bloco de centena
    - 100, 200, 300
    - cento e, duzentos e, trezentos e


### Milhares e Milhões

num = 18.446.744.073.709.551.615 == 7 blocos de UDC (unidade, dezena, centena);

| bloco6 | bloco5 | bloco4 | bloco3 | bloco2 | bloco1 | bloco0 |
| :---: | :---: | :---: | :---: | :---: | :---: | :---: |
| ————— | ————— | ————— | ————— | ————— | ————— | ————— |
| 18 | 446 | 744 | 073 | 709 | 551 | 615 |
| DU | CDU | CDU | CDU | CDU | CDU | CDU |
| quintilhão | quartilhão | trilhão | bilhão | milhão | milhar | - |

Como pegar o primeiro bloco:

- Fazer comprimento de num % 3
    - Se 0: Não mudar nada em num(string)
    - Se 1: Adicionar 0 antes do num(string)
    - Se 2: Adicionar 00 antes do num(string)
    - Pegar os índices 0, 1 e 2


- Fazer uma divisão inteira: num / 3
    - Se 7: quintilhão
    - Se 6: quartilhão
    - Se 5: trilhão
    - Se 4: bilhão
    - Se 3: milhão
    - Se 2: mil
    - Se 1: base


## NÚMEROS POR EXTENSO

UNIDADES
- ZERO
- UM
- DOIS
- TRES
- QUATRO
- CINCO
- SEIS
- SETE
- OITO
- NOVE

DEZENAS (redondo)
- DEZ
- ONZE
- DOZE
- TREZE
- CATORZE
- QUINZE
- DEZESSEIS
- DEZESSETE
- DEZOITO
- DEZENOVE

DEZENAS (um)
- VINTE
- TRINTA
- QUARENTA
- CINQUENTA
- SESSENTA
- SETENTA
- OITENTA
- NOVENTA

CENTENA
- CEM / CENTO
- DUZENTOS
- TREZENTOS
- QUATROCENTOS
- QUINHENTOS
- SEISCENTOS
- SETECENTOS
- OITOCENTOS
- NOVECENTOS

MILHAR
- MIL
- UNIDADE + MIL
- DEZENA + MIL
- CENTENA + MIL

MILHÕES
- MILHAO/OES
- BILHAO/OES
- TRILHAO/OES
- QUADRILHAO/OES
- QUINTILHAO/OES
- SEXTILHAO/OES
- SEPTILHAO/OES
- OCTILHAO/OES
- NONILHAO/OES
- DECILHAO/OES

## Backup

```csharp
    public static string CasaDecimal (int primeiroBloco)
    {
        if (ultimoBloco.Length % 3 == 0)
            return UniDezCen(primeiroBloco[0], primeiroBloco[1], primeiroBloco[2]);
        else if (primeiroBloco.Length % 3 == 1)
            return UnidadeDezena(primeiroBloco[0], primeiroBloco[1]);
        else
            return Unidade(primeiroBloco);
    }

        /*
        int centena = Convert.ToInt32(num.Substring(0, 1)); //último dígito
        int dezena = Convert.ToInt32(num.Substring(1, 1)); //penúltimo dígito
        int unidade = Convert.ToInt32(num.Substring(2, 1)); //antepenúltimo dígito
        */
```