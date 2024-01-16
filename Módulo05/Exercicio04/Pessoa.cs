using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    internal class Pessoa
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }

        public void Exibir()
        {
            Console.WriteLine($"Nome: {this.Nome}\nIdade: {this.Idade}\n");
        }
    }
}
