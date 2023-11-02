using _18_Exercicio_ListT;




Console.WriteLine("Coleção List T");

List<Aluno> alunos = FonteDados.GetAlunos();

ExibirAlunos(alunos);

// 2 - Inclua na lista original os alunos: Bia - 7.75, Mario, 8.95 e exiba novamente a lista de alunos.

Aluno bia = new Aluno() {Nome = "Bia",Nota = 7.75};
Aluno mario = new Aluno() {Nome = "Mario",Nota = 8.95};

alunos.Add(bia); 
alunos.Add(mario);

ExibirAlunos(alunos);

// 3 - Localizar a aluna chamada Amanda, e remover ela da lista, e exibir a lista novamente.

var aluno1 = alunos.Find(x => x.Nome.Equals("Amanda"));
alunos.Remove(aluno1);

ExibirAlunos(alunos);

//4 - Ordene a lista pelo nome do aluno e exiba a lista ordenada.

var listaOrdenada = alunos.OrderBy(n => n.Nome).ToList();

ExibirAlunos(listaOrdenada);

// 5 - Obtenha e exiba no console os alunos com nota maior ou igual a 8

var alunosNotaOito = alunos.FindAll(x => x.Nota >= 8);
Console.WriteLine("\nAlunos com nota maior que 8\n");

foreach (var alunox in alunosNotaOito)
{
    Console.WriteLine($"{alunox.Nome}\t{alunox.Nota}");
}


Console.ReadKey();

// 1 - Crie um método para exibir a lista de alunos com nome, nota e a média aritmética das notas e a
// quantidade de alunos na lista.

static void ExibirAlunos(List<Aluno> alunos)
{
    Console.WriteLine("\nRelação de Alunos\n");
    Console.WriteLine("\nNome\tNota");

    var somaNotas = 0.0;

    foreach (var aluno in alunos)
    {
        Console.WriteLine($"{aluno.Nome}\t{aluno.Nota}");
        somaNotas += aluno.Nota;
    }

    var mediaNotas = somaNotas / alunos.Count();
    Console.WriteLine($"\nMédia das notas: {Math.Round(mediaNotas, 2)}");
    Console.WriteLine($"\nTotal de alunos: {alunos.Count}");
}