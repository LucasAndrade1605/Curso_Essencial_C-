//7 - crie um indexador para uma classe aluno para gerenciar uma coleção de nomes de alunos com no máximo
//10 elementos.
//para testar a implementação atribua nomes e obtenha os valores atribuídos usando o indexador criado.

using Exercicio07;

Aluno aluno = new Aluno();

aluno[2] = "Maria";
aluno[3] = "João";

aluno[12] = "Lucas";

Console.WriteLine(aluno[12]);

Console.WriteLine(string.Join(" ",aluno.Nome));