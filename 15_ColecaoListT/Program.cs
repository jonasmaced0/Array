Console.WriteLine("Coleção List T");

// inclusão de itens: Add(T) e Insert(int index, T value)
// inclusão de coleções: AddRange(ICollection) e InsertRange(int index, ICollection)
// acesso aos elementos: lista[indice]
// iteração na lista: laço for(Count) e laço foreach
// verificar a existencia de um elemento: Contains(T)
// remoção de itens: Remove(T), RemoveAt(int index), RemoveRange(int index, int count)
// ordenação da lista: Sort()
// remoção de todos os elementos: Clear()

var lista = new List<string>() {"Maria","Ana","Pedro"};

string[] array1 = {"Jonas", "João", "Joaquim" };

Console.WriteLine($"{lista.Count} itens.");

lista.AddRange(array1);
lista.InsertRange(2, array1);

Console.WriteLine($"{ lista.Count} itens.");

Console.WriteLine(lista[0]);
Console.WriteLine(lista[1]);
Console.WriteLine(lista[2]);
Console.WriteLine(lista[3]);
Console.WriteLine(lista[4]);
Console.WriteLine(lista[5]);
Console.WriteLine(lista[6]);
Console.WriteLine(lista[7]);
Console.WriteLine(lista[8]);

Console.WriteLine("------------------------------------------------------");

var lista1 = new List<int> {10,9,8,7,6,5,4,3,2,1};

lista1.Remove(7);
lista1.RemoveAt(0);
lista1.RemoveRange(0, 3);

foreach (var item in lista1)
{
    Console.WriteLine($"{item} ");
}


Console.WriteLine("-------------------------------------------------------");

var list2 = new List<string> { "Ana", "Pedro", "Marcelo" };

var result1 = list2[0];
var result2 = list2[1];
var result3 = list2[2];

Console.WriteLine(result1);
Console.WriteLine(result2);
Console.WriteLine(result3);

list2[0] = "Soteldo";
list2[1] = "Lucas Lima";
list2[2] = "João Paulo";

Console.WriteLine(list2[0]);
Console.WriteLine(list2[1]);
Console.WriteLine(list2[2]);

Console.WriteLine("-------------------------------------------------------");


List<string> lista3 = new() {"Maria","Ana","Pedro","Carlos","Zé"};

for (int i = 0; i < lista3.Count; i++)
{
    Console.Write($"{lista3[i]} ");
}

lista3.Reverse();
Console.WriteLine("\n");

for (int i = 0; i < lista3.Count; i++)
{
    Console.Write($"{lista3[i]} ");
}

Console.WriteLine("\n");

Console.WriteLine("-------------------------------------------------------");

var list4 = new List<string>() {"Santos", "Palmeiras", "São Paulo", "Corinthians"};

var resultado1 = list4.Contains("Santos");
var resultado2 = list4.Contains("Guarani");
var resultado3 = list4.Contains("Bragantino");

Console.WriteLine(resultado1);
Console.WriteLine(resultado2);
Console.WriteLine(resultado3);

Console.WriteLine("\n");
Console.WriteLine("-------------------------------------------------------");


Console.ReadKey();





