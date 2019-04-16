using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roteiro_02
{
    class Porco : Mamifero
    {
        public Porco(string nome, int idade) : base(nome, idade, 4, "vermelho") { }

        public override void Comunicar()
        {
            Console.WriteLine("Ronc Ronc");
        }
    }
}
