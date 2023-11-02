using System.Collections;

Console.WriteLine("\n\n ArrayList \n\n");

// Método Add e Método Inset(int index, Object value)

var list = new ArrayList() { "Maria", 2, 3.5, null, true };

list.Add(3.5);

list.Insert(2, "Paulo");

Console.WriteLine(list[0]);
Console.WriteLine(list[1]);
Console.WriteLine(list[2]);
Console.WriteLine(list[3]);
Console.WriteLine(list[4]);
Console.WriteLine(list[5]);
Console.WriteLine(list[6]);

Console.WriteLine();


// Método AddRange(IColletion) e Método InsertRange(int index, IColletion)


var list1 = new ArrayList() { "Jonas", true, 4.5};

int[] array1 = { 2, 4, 5 };

list1.AddRange(array1);

list1.InsertRange(1, array1);

Console.WriteLine(list1[0]);
Console.WriteLine(list1[1]);
Console.WriteLine(list1[2]);
Console.WriteLine(list1[3]);
Console.WriteLine(list1[4]);
Console.WriteLine(list1[5]);
Console.WriteLine(list1[6]);
Console.WriteLine(list1[7]);
Console.WriteLine(list1[8]);

Console.ReadKey();


