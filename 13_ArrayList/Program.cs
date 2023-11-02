using System.Collections;

Console.WriteLine("\n\n ArrayList \n\n");

// Método Contains()  - retorna true ou false
// Método Sort() - ordenar uma ArrayList
// Método Clear() - remove todos os elementos da Arraylist mas mantem a capacidade da Arrylist.

var lista = new ArrayList() {"Maria", true, 5, 4.5, DateTime.Now };

var resultado1 = lista.Contains("Maria");
Console.WriteLine(resultado1);

var resultado2 = lista.Contains(true);
Console.WriteLine(resultado2);

var resultado3 = lista.Contains(6);
Console.WriteLine(resultado3);

var lista1 = new ArrayList() {"Jonas", "Maria", "João", "Daniel", "Rafael" };

lista1.Sort();

foreach (var item in lista1)
{
    Console.Write($"{item} ");
}

lista1.Clear();

Console.WriteLine("\n");

Console.WriteLine(lista1.Count);

Console.ReadKey();

