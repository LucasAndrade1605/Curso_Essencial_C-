//3 - Escreva um programa em C# que solicite ao usuário que informe o valor das notas, do tipo float , para 10
//alunos divididos em 2 grupos de 5 alunos cada. Armazene as informações em um array bidimensional e a
//seguir exiba no console a média aritmética de cada grupo de alunos (grupo1 e grupo2)

float[,] notas = new float[2,5];

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.WriteLine($"Informe a nota do aluno {((i*5)+j)+1}");
        notas[i,j] = Convert.ToSingle(Console.ReadLine());
    }
}

float mediaGrupo01 = 0;
float mediaGrupo02 = 0;

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 5; j++)
    {
        if (i == 0) mediaGrupo01 += notas[i, j];
        else mediaGrupo02 += notas[i, j];

    }
}

Console.WriteLine($"Media gurpo 1 = {mediaGrupo01/5}\nMedia gurpo 2 = {mediaGrupo02/5}");

