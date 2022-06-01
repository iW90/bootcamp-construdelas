/* EXERCÍCIO 01:
1. Crie uma interface chamada Animal
2. Vai ter a definicao dos metodos Procriar, SeMovimentar que não recebem parametro e retorne void

3. Crie uma classe abstrata que implemente a interface Animal chamada Mamifero
4. Implemente o metodo Procriar que imprime “estou gravida”.

5. Crie uma classe abstrata que implemente a interface Animal chamada Oviparo
6. Implemente o metodo Procriar que imprime “botei um ovo”.

7. Crie uma classe chamada Canguru que herde de Mamifero
8. Implemente o método SeMovimentar que imprime “to pulando”.

9. Crie uma classe chamada Tilapia que herde de Oviparo
10. Implemente o método SeMovimentar que imprime “to nadando”.

11. Crie uma classe chamada Canario que herde de Oviparo
12. Implemente o método SeMovimentar que imprime “to voando”.

13. Crie um main que crie um array de Animal e instancie um Canguru, uma Tilapia e um Canario e adicione nesse array.
14. Chame o método SeMovimentar e o método Procriar para cada um dos itens do array.
*/


var canguru = new Canguru();
var tilapia = new Tilapia();
var canario = new Canario();
var arrAnimal = new Animal[3];

arrAnimal[0] = canguru;
arrAnimal[1] = tilapia;
arrAnimal[2] = canario;

foreach (var item in arrAnimal)
{
    item.Procriar();
    item.SeMovimentar();
}