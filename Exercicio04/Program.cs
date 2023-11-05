
/* 
 
 4- Crie um programa C# que usa uma ArrayList para armazenar uma lista de objetos pessoas.
a-) Primeiro crie uma classe chamada Pessoa.cs com duas propriedades (nome e idade) e um método Exibir()
para imprimir o nome e a idade;
b-) A seguir crie uma ArrayList e solicite a informação dos nomes e idades de 3 pessoas via teclado
armazenando as informações na ArrayList.
c-) A seguir exiba no console a lista das pessoas com nome e idade
d-) Inclua mais dois objetos Pessoa na lista e exiba a nova lista de pessoas
e-) Remova o último elemento da coleção e exiba a lista completa
Use seguintes dados iniciais: Ana, 22 - Diná, 21 - Maria, 19
Ao incluir os objetos pessoa use os dados : Jaime,20 - Tânia,18

 
 */

using System.Collections;
using System.ComponentModel;

ArrayList pessoas = new ArrayList();

for (int i = 0; i < 3; i++)
{
    Console.Write($"Digite o nome da {i+1}ª pessoa: ");
    string nome = Console.ReadLine();
    Console.Write($"Digite a idade da {i+1}ª pessoa: ");
    int idade = Convert.ToInt32( Console.ReadLine() );

    pessoas.Add(new Pessoa()
    {
        Nome = nome,
        Idade = idade
    });
}

Console.WriteLine("\n");
Console.WriteLine("Lista de pessoas após a inclusão de 3 pessoas: ");

ListagemDePessoas(pessoas);

Console.WriteLine("\n");

Pessoa pessoa1 = new Pessoa() { Nome = "Jaime", Idade = 20 };
Pessoa pessoa2 = new Pessoa() { Nome = "Tânia", Idade = 18 };

pessoas.Add (pessoa1);
pessoas.Add (pessoa2);

ListagemDePessoas(pessoas);


Console.WriteLine("\n");

pessoas.RemoveAt(4);

ListagemDePessoas(pessoas);

Console.WriteLine("\n");

Console.ReadKey();

static void ListagemDePessoas(ArrayList pessoas)
{
    foreach (Pessoa i in pessoas)
    {
        Console.WriteLine(i.Exibir());
    }
}

public class Pessoa
{
    public string? Nome { get; set; }
    public int Idade { get; set; }

    public string Exibir()
    {
        return ($"{Nome} tem {Idade} anos");
    }

}
