using Exercicio_ListT;

List<Aluno> alunos = new List<Aluno>()
{
    new Aluno{Nome = "Maria", Nota=8.75 },
    new Aluno{Nome = "Manoel", Nota=6.95 },
    new Aluno{Nome = "Amanda", Nota=7.25 },
    new Aluno{Nome = "Carlos", Nota=6.55 },
    new Aluno{Nome = "Jaime", Nota=8.50 },
    new Aluno{Nome = "Debora", Nota=5.95 },
    new Aluno{Nome = "Alicia", Nota=9.25 },
    new Aluno{Nome = "Sandra", Nota=5.55 },
    new Aluno{Nome = "Marta", Nota=7.85 },
    new Aluno{Nome = "Sueli", Nota=9.15 },
};

Console.WriteLine("Lista de alunos e notas:\n");

ExibirNomeNota(alunos);

alunos.Add(new Aluno { Nome = "Bia", Nota = 7.75});
alunos.Add(new Aluno { Nome = "Mario", Nota = 8.95 });

Console.WriteLine("Lista de alunos e notas com Bia e Mario:\n");

ExibirNomeNota(alunos);

Aluno alunoRemove = alunos.Find(x => x.Nome.Equals("Amanda"));
alunos.Remove(alunoRemove);

Console.WriteLine("Lista de alunos e notas sem Amanda:\n");

ExibirNomeNota(alunos);

List<Aluno> listaOrdenada = alunos.OrderBy(x => x.Nome).ToList();

Console.WriteLine("Lista de alunos e notas ordenada:\n");

ExibirNomeNota(listaOrdenada);

var listaAlunosNotaMaiorOito = alunos.FindAll(x => x.Nota >= 8);

Console.WriteLine("Lista de alunos com nota maior que 8:\n");

ExibirNomeNota(listaAlunosNotaMaiorOito);


static void ExibirNomeNota(List<Aluno> alunos)
{
    Double mediaNota = 0.0;
    foreach (Aluno aluno in alunos)
    {
        Console.WriteLine($"Nome: {aluno.Nome} | Nota: {aluno.Nota}");
        mediaNota += aluno.Nota;
    }

    Console.WriteLine($"\nMedia notas: {mediaNota / alunos.Count}");
    Console.WriteLine($"\nQuantidade de alunos: {alunos.Count}\n");
}


