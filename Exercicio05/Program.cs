/* 
 
 5- Dada uma classe Produto contendo duas propriedades : Nome (string) e Preco (decimal). Crie uma lista
de objetos do tipo Produto usando os seguinte dados:
Clips, R$ 3,95 - Caneta, R$ 5,99 - - Lápis, R$ 4,15 - Estojo, R$ 6,99 e Caderno, R$ 7,55
A seguir realize as seguintes operações na lista de objetos Produto criada :
1- Crie um método para exibir a relação de produtos , a soma total dos preços dos produtos, a média do
preço dos produtos e a quantidade de produtos na lista
2- Inclua na lista o seguinte produto : Mochila, R$ 22,44 e exiba novamente a lista de produtos
3- Ordene a lista pelo nome do produto e exiba a lista ordenada
4- Obtenha e exiba no console os produtos com preço inferior a R$ 5,00
5- Localize na lista o produto com nome Estojo
 
 */

using Exercicio05;


List<Produto> produtos = Dados.GetProdutos();

Exibir(produtos);

Produto mochila = new Produto() { Nome = "Mochila", Preco = 22.44m };

produtos.Add(mochila);

Console.WriteLine("\n");
Console.WriteLine("Após a adição de um item a lista ficou assim: \n");

Exibir(produtos);


Console.WriteLine("\nA lista ordenada dos Produtos: \n");
var listaOrdenada = produtos.OrderBy(n => n.Nome).ToList();
Exibir(listaOrdenada);

Console.WriteLine("\nProdutos com preço inferiro a R$5.00: \n");
var precoInferior = produtos.FindAll(n => n.Preco < 5.00m);
Exibir(precoInferior);

Console.WriteLine("\nLocalizando o produto Estojo \n");
var estojo = produtos.Find(n => n.Nome.Equals("Estojo"));
Console.WriteLine($"{estojo.Nome} - R${estojo.Preco}");

Console.ReadKey();

static void Exibir(List<Produto> produtos)
{
    var Soma = 0.0m;
    Console.WriteLine("Produto - Preço\n");
    foreach (Produto produto in produtos)
    {
        Console.WriteLine($"{produto.Nome} - R${produto.Preco}");
        Soma += produto.Preco;
    }

    var Media = Soma/ produtos.Count;


    Console.WriteLine($"\nA soma total dos Produtos da lista é de {Math.Round(Soma,3)}.");
    Console.WriteLine($"\nA média total dos Produtos da lista é de {Math.Round(Media, 3)}.");
    Console.WriteLine($"\nA quantidade dos Produtos na lista é de {produtos.Count}.");
}
