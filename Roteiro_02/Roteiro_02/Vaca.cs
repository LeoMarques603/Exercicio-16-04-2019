using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roteiro_02
{
    class Vaca : Mamifero
    {
        public Vaca(string nome, int idade) : base(nome, idade, 7, "vermelho") { }

        public override void Comunicar()
        {
            Console.WriteLine("Muuuuuu!");
        }
    }
}
