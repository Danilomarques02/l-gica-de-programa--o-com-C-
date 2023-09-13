//Loop FOREACH / Estruturas de iteração

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aulac_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[3] { 11, 22, 33 };

            for (int i = 0; i < num.Length; i++)
            {
                num[i] = 0;


                foreach (int n in num)
                {
                    Console.WriteLine(n);
                    Console.ReadLine();

                }
            }
        }
    }
}
