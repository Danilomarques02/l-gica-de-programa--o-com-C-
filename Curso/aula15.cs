// Array / Vetor

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aulac_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int n1, n2, n3, n4, n5;
            int[] n = new int[5];//0
            int[] num = new int[4] {55,77,99,88};
            //int[] num = { 55, 77, 99 };
            string[] veiculos = new string[3];

            veiculos[0] = "Carros";
            veiculos[1] = "Avião";
            veiculos[2] = "Navio";


            n[0] = 111;
            n[1] = 222;
            n[2] = 333;
            n[3] = 444;
            n[4] = 555;

            Console.WriteLine(num[2]);
            Console.ReadLine();
        }
    }
}
