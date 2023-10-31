Console.WriteLine("\n\n Array Multidimensionais \n\n");

int[,] n = { 
             { 11, 22, 33 },
             { 44, 55, 66 }, 
             { 77, 88, 99 }
           };


// percorrendo o array multidimenisonal com for.

for (int i = 0; i < n.GetLength(0); i++)
{
    for (int j = 0; j < n.GetLength(1); j++)
    {
        Console.Write($"{n[i,j]} ");
    }
    Console.WriteLine();
}

Console.WriteLine("\n");

// percorrendo o array multidimenisonal com foreach.

foreach (int i in n)
{
    Console.Write($"{i} " );
}

Console.ReadKey();
