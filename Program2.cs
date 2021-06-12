using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread pares = new System.Threading.Thread(new System.Threading.ThreadStart(NumerosPares));
            System.Threading.Thread inpares = new System.Threading.Thread(new System.Threading.ThreadStart(NumerosInpares));
            pares.Start();
            inpares.Start();
            Console.ReadKey();
        }
        static void NumerosPares()
        {           
            for(int i = 1; i <= 100000; i++)
            {
                if ((i % 2) == 0)
                {
                    Console.WriteLine("P "+i);
                }
            }
        }
        static void NumerosInpares()
        {       
            for(int i = 1; i <= 100000; i++)
            {
                if ((i % 2) != 0)
                {
                    Console.WriteLine("I "+i);
                }
            }
        }
    }
}
