using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roteiro_02
{
    class Cachorro : Mamifero
    {
        public Cachorro (string nome, int idade) : base (nome, idade, 10, "castanho"){ }

        public override void Comunicar()
        {
            Console.WriteLine("Au Au!!!");
        }
    }
}
