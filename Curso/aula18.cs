//Loop WHILE / Estruturas de iteraão

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aulaC_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];

            int i =num.Length-1;

            while (i>0)
            {
                    num[i] = 0;
                    Console.WriteLine(num[i]);
                    i--;

                
            }

            Console.WriteLine("Fim do loop");
            Console.ReadLine();
        }
    }
}