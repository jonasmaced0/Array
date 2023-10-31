Console.WriteLine("Array_ArrayList_List\n");

int[] numeros;
numeros = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

string[] nomes;

nomes = new string[5] { "Maria", "Eva", "Davi", "Pedro", "Marcelo" };


for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Elemento do Array na posição {i} = {numeros[i]}");
    Console.WriteLine();
}

Console.WriteLine("\n");

for (int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine($"Elemento do Array na posição {i} = {nomes[i]}");
    Console.WriteLine();
}


Console.ReadKey();
