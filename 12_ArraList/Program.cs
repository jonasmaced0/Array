using System.Collections;

Console.WriteLine("\n\n ArrayList \n\n");

// Método Remove(Object value), RemoveAt(int index) e RemoveRange(int index, int count)

var list = new ArrayList() { "Ana", 5, true, " ", null, 1.1,"Zé",3,9,0};
//                             0    1   2    3     4    5    6   7 8 9

list.Remove(null);
list.RemoveAt(4);
list.RemoveRange(0, 2);

Console.WriteLine(list[0]);
Console.WriteLine(list[1]);
Console.WriteLine(list[2]);
Console.WriteLine(list[3]);
Console.WriteLine(list[4]);
Console.WriteLine(list[5]);

Console.ReadKey();

