Console.WriteLine("\n\n Exercicio de Array \n\n");

string[] alunos;
alunos = new string[5];

double[] notas;
notas = new double[5];

double soma = 0, media, dividendo;

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Digite o nome do {i+1}° aluno:");
    alunos[i] = Console.ReadLine();

    Console.WriteLine($"Digite a nota do {i+1}° aluno:");
    notas[i] = Convert.ToDouble(Console.ReadLine());

    soma = soma + notas[i];
}

foreach (string aluno in alunos)
{
    Console.WriteLine($"Aluno: {aluno}");
}

Console.WriteLine("\n");

foreach (double nota in notas)
{
    Console.WriteLine($"Nota: {nota}");
}

dividendo = alunos.Length;
media = soma / dividendo;
Console.WriteLine($"A média dos alunos foi de {media}");


