//6 - Crie um programa C# e defina um método chamado ProcessaObjetos() que possa receber um número
//variáveis de argumentos e que possa exibir os seus valores e também o tipo do objeto (Use o método
//GetType() herdado de Object) no console.
//Passe os seguintes argumentos ao invocar o método : ProcessaObjetos(1, "Maria", 3.45m, new Teste(), null)

ProcessaObjetos(1, "Maria", 3.45m, new Teste(), null);
void ProcessaObjetos(params object[] valor)
{
    foreach (object obj in valor)
    {
        if (obj != null) Console.WriteLine($"Conteúdo: {obj} | Tipo do objeto: {obj.GetType()}");
        else Console.WriteLine("null");

    }
}

class Teste()
{

}