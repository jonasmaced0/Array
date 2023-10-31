using System.Net.NetworkInformation;

Console.WriteLine("\n\n Modificador Params \n\n");

// Criar um programa para calcular a soma de um número variável de números inteiros.


Console.WriteLine(Calcular.Soma(1, 2, 3, 4, 5, 6, 7, 8, 9));


Console.ReadKey();

public class Calcular 
{ 
    public static int Soma(params int[] numeros)
    {
        int total = 0;
        foreach (int numero in numeros) 
        {
            total += numero;
            
        }
        return total;
    }
}


