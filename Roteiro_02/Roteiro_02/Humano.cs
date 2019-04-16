using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roteiro_02
{
    class Humano : Mamifero
    {
        public Humano(string nome, int idade, string corDosOlhos) : base(nome, idade, 2, "") { }

        public override void Comunicar()
        {
            Console.WriteLine("Olá!");
        }
    }
}
