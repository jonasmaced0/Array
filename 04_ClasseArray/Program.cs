Console.WriteLine("Array_ArrayList_List\n");

// Classe Array
// Array.Reverse(nome_array);
// Array.Sort(nome_array);
// Array.BinarySearch(nome_array, objeto);

string[] nomes = {"Marcelo","João","Pedro","Fabio","Thiago"};

Console.WriteLine("\n\nExibindo o array original...\n");

ExibeArray(nomes);

Console.WriteLine("\n\nInvertendo a ordem do array...\n");

Array.Reverse(nomes);

ExibeArray(nomes);

Console.WriteLine("\n\nOrdenando a ordem do array...\n");

Array.Sort(nomes);

ExibeArray(nomes);

// -----------------------------------------------------------

Console.WriteLine("\n\nLocalizando o número no Array...\n");
Console.WriteLine("Informe um nome:");
string nome = Console.ReadLine();

var indice = Array.BinarySearch(nomes, nome);

if( indice >=0 )
    Console.WriteLine($"\n{nome} foi encontrado com índice {indice}");
else
{
    Console.WriteLine("O nome não foi encontrado");
}


Console.ReadKey();

static void ExibeArray(string[] nomes)
{
    foreach (string nome in nomes)
    {
        Console.Write($"{nome} ");
    }
}