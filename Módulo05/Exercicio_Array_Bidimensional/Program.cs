string[,] alunos = new string[2,5];

for(int l = 0;  l < alunos.GetLength(0); l++)
{
    for (int c = 0; c < alunos.GetLength(1); c++)
    {
        Console.WriteLine("Informe o nome de um aluno");
        alunos[l, c] = Console.ReadLine();
    }
}
Console.WriteLine("Alunos:\n");
for (int l = 0; l < alunos.GetLength(0); l++)
{
    for (int c = 0; c < alunos.GetLength(1); c++)
    {
        Console.Write($"[{l},{c}] = {alunos[l, c]} ");
    }
    Console.WriteLine();
}
