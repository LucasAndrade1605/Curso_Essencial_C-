//1 - Crie um programa C# para armazenar os nomes de 10 frutas em um array unidimensional e a seguir realize
//as seguintes operações : Dados: Maça, Banana, Laranja, Uva, Manga, Pêra, Abacate, Mamão, Pêssego, Amora

//a- Exiba os nomes das frutas no console e a quantidade de elementos do array usando os laços for e foreach
//b- Exiba os nomes da segunda e da penúltima fruta no console
//c- Altere o nome da terceira fruta para Kiwi e da última fruta para Caqui e exiba o nome de todas as frutas
//d- Ordene a coleção de frutas na ordem ascendente
//e- Exiba no console a coleção de nomes de frutas na ordem inversa

string[] frutas = new string[] {"Maça","Banana","Laranja","uva", "Manga", "Pêra", "Abacate"
,"Mamão","Pêssego","Amora"};

//a

Console.WriteLine("Frutas:\n");

ExibirFrutas(frutas);

Console.WriteLine($"\n\nQuantidade total de frutas: {frutas.Length}");

//b

Console.WriteLine($"\nSegunda fruta: {frutas.GetValue(1)}\nPenúltima fruta: {frutas.GetValue(8)}\n");

//c

frutas[2] = "Kiwi";
frutas[9] = "Caqui";

ExibirFrutas(frutas);

//d

Array.Sort(frutas);

ExibirFrutas(frutas);

//e

Array.Reverse(frutas);

ExibirFrutas(frutas);

Console.ReadKey();


void ExibirFrutas(string[] frutas)
{
    foreach (string fruta in frutas)
    {
        Console.Write($"{fruta} ");
    }
    Console.WriteLine();
}
