using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio07
{
    public class Aluno
    {
        public string?[] Nome = new string[10];

        public string this[int i]
        {
            get
            {
                if (i >= 0 && i < Nome.Length) return Nome[i];
                return $"Não há a posição {i}\n";
            }
            set 
            {
                if (i >= 0 && i < Nome.Length) Nome[i] = value;
                else Console.WriteLine($"Não há a posição {i}\n");
            }
        }
    }
}
