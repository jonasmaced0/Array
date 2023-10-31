Console.WriteLine("\n\n Array Multidimensionais - Exercicio \n\n");


string[,] alunos = new string[2, 5];


for (int i = 0; i < alunos.GetLength(0); i++)
{
    for (int j = 0; j < alunos.GetLength(1); j++)
    {
        Console.Write($"Digite o nome do Aluno da posição [{i},{j}]: ");
        alunos[i, j] = Console.ReadLine();
    }

    Console.WriteLine();
}

for (int k = 0;k < alunos.GetLength(0); k++)
{
    for(int l = 0;l < alunos.GetLength(1); l++)
    {
        Console.Write($"[{k},{l}] = {alunos[k,l]} "); 
    }
    Console.WriteLine("\n");
}

Console.WriteLine("Fim do processamento...");


