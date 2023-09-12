//Loop FOR / Estruturas de iteração

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

            for (int i=0;i<10;i++){

                num[i] = 0;

             
            }
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine("Valor de num na pos{0}: {1}", i, num[1]);
            }
            Console.ReadLine();
        }
    }
}
