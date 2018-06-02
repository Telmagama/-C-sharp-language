using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LacoDeRepeticaoFor1
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int multiplicador = 1; multiplicador <= 10; multiplicador++)
            {
                for(int contador = 0; contador <= 10; contador++)
                {
                    Console.Write(multiplicador * contador);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
