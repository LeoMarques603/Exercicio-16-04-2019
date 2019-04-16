using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roteiro_02
{
    class Leão : Mamifero
    {
        public Leão(string nome, int idade) : base(nome, idade, 6, "marrom") { }

        public override void Comunicar()
        {
            Console.WriteLine("Roaaaaar!!!!!");
        }
    }
}
