Console.WriteLine("Coleção List T");

// Métodos Find(), FindLast(), FindIndex(), FindLastIndex(), FindAll()


// Utilizando método Find()

List<string> frutas = new() 
{
    "Uva", "Pera", "Banana","Abacate", "Laranja", "Morango"
};


// utilizando Predicado como uma função
var fruta1 = frutas.Find(Procura);
Console.WriteLine($"Predicado: {fruta1}");

// utilizando a expressão lambda
var fruta2 = frutas.Find(i=> i.Contains("n"));
Console.WriteLine($"Find: {fruta2}");

var fruta3 = frutas.FindLast(i=> i.Contains("n"));
Console.WriteLine($"FindLast: {fruta3}");

var fruta4 = frutas.FindIndex(i=> i.Contains("n"));
Console.WriteLine($"FindIndex: {fruta4}");

var fruta5 = frutas.FindLastIndex(i=> i.Contains("n"));
Console.WriteLine($"FindIndex: {fruta5}");

var frutas6 = frutas.FindAll(i=> i.Contains("n"));

foreach(var fruta in frutas6)
{
    Console.Write($"{fruta} ");
}

Console.ReadKey();

static bool Procura(string item)
{
    return item.StartsWith("A");
}