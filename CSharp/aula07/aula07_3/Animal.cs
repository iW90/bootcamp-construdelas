enum AnimalTipo
{
    Cachorro,
    Gato,
    Pato,
    Passaro,
    Desconhecido
}
class Animal
{
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