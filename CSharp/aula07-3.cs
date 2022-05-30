/* EXERCÍCIO 02
 * (relacionado à aula06-4.cs)
1. Crie um enum com os valores: cachorro, gato, pato, passaro e desconhecido, o nome da enum é AnimalTipo
2. Crie um main que pergunte quantos animais vamos levar na arca.
3. No construtor do animal receber a string tipoDoAnimalStr e armazenar no atributo tipoDoAnimal que é do tipo AnimalTipo.
4. Crie um array e vá lendo o tipo do animal e colocando na arca.
5. Imprima quantos animais do tipo cachorro foram colocados na arca.
*/

/*
Console.WriteLine("Digite quantos animais vai na arca:");
int qtdeAnimais = Convert.ToInt32(Console.ReadLine());
var arcaDeNoe = new Animal[qtdeAnimais];
for (int i = 0; i < arcaDeNoe.Length; i++) {
    Console.WriteLine("Digite o tipo do animal:");
    var tipoDoAnimal = Console.ReadLine();
    var animal = new Animal(tipoDoAnimal.ToLower());
    arcaDeNoe[i] = animal;
}

 

int cachorroQtd = 0;
foreach (var animal in arcaDeNoe) {
    if (animal.tipoDoAnimal == AnimalTipo.Cachorro)
    {
        cachorroQtd++;
    }
}

Console.WriteLine($"Estamos levando {cachorroQtd} cachorros na arca");

// OUTRO ARQUIVO.CS: (salvei no mesmo arquivo para organização)
enum AnimalTipo {
    Cachorro,
    Gato,
    Pato,
    Passaro,
    Desconhecido
}
class Animal {
    public AnimalTipo tipoDoAnimal;
    public Animal(string tipoDoAnimalStr)
    {
        switch (tipoDoAnimalStr)
        {
            case "cachorro":
                tipoDoAnimal = AnimalTipo.Cachorro;
                break;
            case "gato":
                tipoDoAnimal = AnimalTipo.Gato;
                break;
            case "pato":
                tipoDoAnimal = AnimalTipo.Pato;
                break;
            case "passaro":
                tipoDoAnimal = AnimalTipo.Passaro;
                break;
            default:
                tipoDoAnimal = AnimalTipo.Desconhecido;
                break;
        }
    }
}

*/