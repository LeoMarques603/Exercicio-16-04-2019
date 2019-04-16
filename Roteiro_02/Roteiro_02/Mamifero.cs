using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roteiro_02
{
   public abstract class Mamifero
    {
        private string _nome;
        private int _idade;
        private int _mamas;
        private string _corDosOlhos;

        public Mamifero(string nome, int idade, int mamas, string corDosOlhos)
        {
            _nome = nome;
            _idade = idade;
            _mamas = mamas;
            _corDosOlhos = corDosOlhos;
        }

        public virtual void Aleitar()
        {
            Console.WriteLine("Amamentado com {0} mamas", _mamas);
        }

        public abstract void Comunicar();
    }
}
