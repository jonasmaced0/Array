/*
 
1- Crie um programa C# para armazenar os nomes de 10 frutas em um array unidimensional e a seguir realize
as seguintes operações : Dados: Maça, Banana, Laranja, Uva, Manga, Pêra, Abacate, Mamão, Pêssego, Amora.

a- Exiba os nomes das frutas no console e a quantidade de elementos do array usando os laços for e foreach
b- Exiba os nomes da segunda e da penúltima fruta no console
c- Altere o nome da terceira fruta para Kiwi e da última fruta para Caqui e exiba o nome de todas as frutas
d- Ordene a coleção de frutas na ordem ascendente
e- Exiba no console a coleção de nomes de frutas na ordem inversa


 */

string[] frutas = new string[10]
    {"Maça","Banana","Laranja","Uva","Manga","Pêra","Abacate","Mamão","Pêssego","Amora"};


Console.WriteLine("Exibindo as frutas usando o laço foreach\n");
foreach (string fruta in frutas)
{
    Console.Write($"{fruta} ");
}

Console.WriteLine("\n");

Console.WriteLine("Exibindo as frutas usando o laço for\n");
for (int i = 0; i < frutas.Length; i++)
{
    Console.Write($"{frutas[i]} ");
}
Console.WriteLine("\n");

Console.WriteLine($"A quantidade de elementos do array é de: {frutas.Length}\n");

Console.WriteLine("Exibindo os nomes da segunda e penúltima fruta\n");
Console.WriteLine($"A segunda fruta é a: {frutas[1]}\n");
Console.WriteLine($"A penultima fruta é a: {frutas[8]}\n");

Console.WriteLine("Alternando o nome da terceira e da ultima fruta\n");

frutas[2] = "Kiwi";
frutas[9] = "Caqui";

foreach (string fruta in frutas)
{
    Console.Write($"{fruta} ");
}
Console.WriteLine("\n");

Array.Sort(frutas);

Console.WriteLine("Colocando as frutas em ordem ascedente\n");
foreach (string fruta in frutas)
{
    Console.Write($"{fruta} ");
}
Console.WriteLine("\n");

Array.Reverse(frutas);
Console.WriteLine("Colocando as frutas em ordem inversa\n");
foreach (string fruta in frutas)
{
    Console.Write($"{fruta} ");
}


Console.ReadKey();
