//2 - Crie um programa em C# que sirva para pesquisar um array de valores inteiros. Para fazer isso, siga estas
//etapas a seguir
//a-) Solicite via teclado o número de valores do array (deve ser um número inteiro)
//b-) Declare e inicialize um array de inteiros com a quantidade de números inteiros informados
//c-) Solicite ao usuário um valor de um número inteiro a procurar no array
//d-) Exiba se o número informado existe no array de inteiros ou não
//e-) Repita até que o texto ‘fim’ seja inserido via teclado

Console.WriteLine("Informe um número para o tamaho do array: ");
int numero = Convert.ToInt32(Console.ReadLine());

int[] array = new int[numero];

for (int i = 0; i < numero; i++)
{
    Console.WriteLine("Informe um número: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

string continua = null;

do
{
    Console.WriteLine("\nInforme um número para ser procurado no array: ");
    int procura = Convert.ToInt32(Console.ReadLine());

    if (ProcuraNumero(procura, array)) Console.WriteLine("Número encontrado");
    else Console.WriteLine("Número não encontrado");

    Console.WriteLine("Deseja continuar?");
    continua = Console.ReadLine();
} while (!continua.Equals("fim"));

static bool ProcuraNumero(int numero, int[] listaNumero)
{
    if (listaNumero.Contains(numero)) return true;
    else return false;
}

