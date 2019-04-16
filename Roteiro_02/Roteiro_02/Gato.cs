using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roteiro_02
{
    class Gato : Mamifero
    {
        public Gato (string nome, int idade) : base (nome, idade, 8, "amarelo") { }

        public override void Comunicar()
        {
            Console.WriteLine("Miau !!!!");
        }
    }
}
