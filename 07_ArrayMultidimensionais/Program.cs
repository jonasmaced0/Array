Console.WriteLine("\n\n Array Multidimensionais \n\n");

int[,] a;
a = new int [2,2];

a[0,0] = 1;
a[0,1] = 2;
a[1,0] = 5;
a[1,1] = 4;

Console.WriteLine(a[0, 0]);
Console.WriteLine(a[0, 1]);
Console.WriteLine(a[1, 0]);
Console.WriteLine(a[1, 1]);

// int[,] b = new int[2, 2] { { 10, 20 }, { 20, 30 } };

int[,] b = { { 1, 2 }, { 3, 4 } };


Console.WriteLine(b[0, 0]);
Console.WriteLine(b[0, 1]);
Console.WriteLine(b[1, 0]);
Console.WriteLine(b[1, 1]);


Console.ReadKey();
