/*
 
2- Crie um programa em C# que sirva para pesquisar um array de valores inteiros. Para fazer isso, siga estas
etapas a seguir

a-) Solicite via teclado o número de valores do array (deve ser um número inteiro)
b-) Declare e inicialize um array de inteiros com a quantidade de números inteiros informados
c-) Solicite ao usuário um valor de um número inteiro a procurar no array
d-) Exiba se o número informado existe no array de inteiros ou não
e-) Repita até que o texto ‘fim’ seja inserido via teclado

 */


Console.Write("Digite um número inteiro para o tamanho do Array: ");
var i = Convert.ToInt32(Console.ReadLine());

int[] array = new int[i];

Console.WriteLine("Digite os valores do Array: \n");

for(int j = 0; j < array.Length; j++)
{
    Console.Write($"Valor da posição {j}: ");
    array[j] = Convert.ToInt32(Console.ReadLine());
}

while (true)
{
    Console.Write("Digite um valor inteiro para ser procurado no Array:");
    var procurar = (Console.ReadLine());

    if (procurar == "fim" || procurar == "FIM") 
    {
        break;
    }
    else
    {
        var numero = Convert.ToInt32(procurar);
        if (array.Contains(numero))
        {
            Console.Write($"O número {procurar} existe no Array!\n");
        }
        else
        {
            Console.WriteLine("Tente novamente!...");
        }
    }

}


Console.WriteLine("Fim do processamento!...");



Console.ReadKey();















Console.ReadKey();
