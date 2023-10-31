using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("Array_ArrayList_List\n");

// foreach ( tipo elemento in coleção )
// {
// // instrução ou bloco de instruções
// }


int[] numeros;
numeros = new int[10] {1,2,3,4,5,6,7,8,9,10};

string[] nomes;
nomes = new string[5] { "Maria", "Eva", "Davi", "Pedro", "Marcelo" };


foreach (int numero in numeros)
{
    Console.Write($"{numero} ");
}

Console.WriteLine("\n");

foreach (string nome in nomes)
{
    Console.Write($"{nome} - ");
}



Console.ReadKey();