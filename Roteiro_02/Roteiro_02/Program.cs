using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roteiro_02
{
    class Program
    {
        static void Main(string[] args)
        {

            Gato gato = new Gato("Garfield", 8);
            gato.Comunicar();

            Humano humano = new Humano("Jõao", 33, "verde");
            humano.Comunicar();

            Mamifero mamal = new Vaca("Mimosa", 4);
            mamal.Comunicar();

            mamal = new Leão("Simba", 5);
            mamal.Comunicar();

            Console.ReadKey();
        }

        /*
         Questão 01 -> B) 1

         Questão 02 -> D) Forma

         Questão 03 -> A) Quando objetos possuem várias formas

         Questão 04 -> C) O código 2 cria 3 triângulos de tamanho de lados diferentes e os passa onde é
         esperado um vetor de polígonos. Esse código gerará um erro quando o programa for
         executado.

         Questão 05 -> B) Overload

         Gabarito =>
         1. B (Certo)
         2. D (Certo) 
         3. C (?)
         4. C (Certo)
         5. B (Certo)

         */
    }
}
