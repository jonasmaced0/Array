/*  
 *  
 3-Escreva um programa em C# que solicite ao usuário que informe o valor das notas, do tipo float , para 10
alunos divididos em 2 grupos de 5 alunos cada. Armazene as informações em um array bidimensional e a
seguir exiba no console a média aritmética de cada grupo de alunos (grupo1 e grupo2).

 */

float somaNotaPrimeiroGrupo = 0.0f;
float somaNotaSegundoGrupo = 0.0f;
float mediaPrimeiroGrupo, mediaSegundoGrupo;


float[,] notas = new float[2, 5];

for (int i = 0; i < notas.GetLength(0); i++)
{
    for (int j = 0; j < notas.GetLength(1); j++)
    {
        Console.Write($"Digite a {j+1}ª nota do {i+1}º grupo: ");
        notas[i,j] = Convert.ToSingle(Console.ReadLine());

        if( i == 0)
        {
            somaNotaPrimeiroGrupo += notas[i, j];
        }
        else
        {
            somaNotaSegundoGrupo += notas[i, j];
        }

    }
    Console.WriteLine("\n");
}

mediaPrimeiroGrupo = somaNotaPrimeiroGrupo / notas.GetLength(1);
mediaSegundoGrupo = somaNotaSegundoGrupo / notas.GetLength(1);

Console.WriteLine($"A média de notas do grupo 1 é de {mediaPrimeiroGrupo}");
Console.WriteLine($"A média de notas do grupo 2 é de {mediaSegundoGrupo}");

Console.ReadKey();

