string[] nomes = new string[5];
double[] notas = new double[5];

for(int cont = 0; cont < 5; cont++)
{
    Console.WriteLine("Informe o nome do aluno:"+(cont+1));
    nomes[cont] = Console.ReadLine();

    Console.WriteLine("Informe a nota do aluno:" + (cont + 1));
    notas[cont] = Convert.ToDouble(Console.ReadLine());
}

Console.Write("Nome dos alunos: ");

foreach (string nome in nomes)
{
    Console.Write(nome+" ");
}

double media = 0;

Console.Write("\nNotas dos alunos: ");

foreach (double nota in notas)
{
    media += nota;

    Console.Write(Convert.ToString(nota)+" ");
}

Console.WriteLine($"Media das notas: {media/5}");