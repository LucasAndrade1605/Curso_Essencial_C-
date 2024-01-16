//5 - Dada uma classe Produto contendo duas propriedades : Nome(string) e Preco(decimal). Crie uma lista
//de objetos do tipo Produto usando os seguinte dados:
//Clips, R$ 3,95 - Caneta, R$ 5,99 - - Lápis, R$ 4,15 - Estojo, R$ 6,99 e Caderno, R$ 7,55
//A seguir realize as seguintes operações na lista de objetos Produto criada :

//1 - Crie um método para exibir a relação de produtos , a soma total dos preços dos produtos, a média do
//preço dos produtos e a quantidade de produtos na lista
//2- Inclua na lista o seguinte produto : Mochila, R$ 22,44 e exiba novamente a lista de produtos
//3- Ordene a lista pelo nome do produto e exiba a lista ordenada
//4- Obtenha e exiba no console os produtos com preço inferior a R$ 5,00
//5- Localize na lista o produto com nome Estojo

using Exercicio05;

List<Produtos> produtos = new List<Produtos>()
{
    new Produtos(){Nome = "Clips", Preco = 3.95f},
    new Produtos(){Nome = "Caneta", Preco = 5.99f},
    new Produtos(){Nome = "Lápis", Preco = 4.15f},
    new Produtos(){Nome = "Estojo", Preco = 6.99f},
    new Produtos(){Nome = "Caderno", Preco = 7.55f}
};

RelacaoProdutos(produtos);

produtos.Add(new Produtos() { Nome = "Mochila", Preco = 22.44f });
RelacaoProdutos(produtos);

var listaOrdenada = produtos.OrderBy(x => x.Nome).ToList();
RelacaoProdutos(listaOrdenada);

var listaValorMenorCinco = produtos.FindAll(x => x.Preco<5);
RelacaoProdutos(listaValorMenorCinco);

Produtos estojo = produtos.Find(x => x.Nome.Equals("Estojo"));

Console.WriteLine($"\nProduto estojo: {estojo.Nome} | {estojo.Preco}");


void RelacaoProdutos(List<Produtos> produtos)
{
    float precoTotal = 0;
    Console.WriteLine("\nProdutos na lista: \n");

    foreach (var produto in produtos){
        Console.WriteLine($"Nome: {produto.Nome} | Preço: {produto.Preco}");
        precoTotal += produto.Preco;
    }

    Console.WriteLine($"\nPreço total dos produtos: {precoTotal}");
    Console.WriteLine($"Preço médio dos produtos: {precoTotal/produtos.Count}");
    Console.WriteLine($"Quantidade de produtos: {produtos.Count}");
}

