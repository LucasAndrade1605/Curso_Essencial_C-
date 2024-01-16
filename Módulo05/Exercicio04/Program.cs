//4 - Crie um programa C# que usa uma ArrayList para armazenar uma lista de objetos pessoas.
//a-) Primeiro crie uma classe chamada Pessoa.cs com duas propriedades (nome e idade) e um método Exibir()
//para imprimir o nome e a idade;
//b -) A seguir crie uma ArrayList e solicite a informação dos nomes e idades de 3 pessoas via teclado
//armazenando as informações na ArrayList.
//c-) A seguir exiba no console a lista das pessoas com nome e idade
//d-) Inclua mais dois objetos Pessoa na lista e exiba a nova lista de pessoas
//e-) Remova o último elemento da coleção e exiba a lista completa
//Use seguintes dados iniciais: Ana, 22 - Diná, 21 - Maria, 19
//Ao incluir os objetos pessoa use os dados : Jaime,20 - Tânia,18

using Exercicio04;
using System.Collections;

ArrayList pessoas = new ArrayList();

for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Informe nome e idade da pessoa "+i+": ");
    pessoas.Add(new Pessoa()
    {
        Nome = Console.ReadLine(),
        Idade = Convert.ToInt32(Console.ReadLine())
    });
}

Console.WriteLine("Lista de Pessoas: ");

foreach (Pessoa pessoa in pessoas)
{
    pessoa.Exibir();
}

Console.WriteLine("--------------------");

pessoas.Add(new Pessoa()
{
    Nome = "Jaime",
    Idade = 20
});

pessoas.Add(new Pessoa()
{
    Nome = "Tânia",
    Idade = 18
});

foreach (Pessoa pessoa in pessoas)
{
    pessoa.Exibir();
}

Console.WriteLine("--------------------");

pessoas.RemoveAt(4);

foreach (Pessoa pessoa in pessoas)
{
    pessoa.Exibir();
}

