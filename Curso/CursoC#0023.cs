using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoC_005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 1;
            int n2 = 2;

            bool n1MaiorN2 = n1 > n2; //False
            bool n1MenorN2 = n1 < n2; // True
            bool n1IgualN2 = (n1 == n2);
   

            if(n1MaiorN2)
            {
                Console.WriteLine("N1 é maior do que n2.");
            }
            else if(n1IgualN2)
            {
                Console.WriteLine("N1 é igual a n2.");
            }
            else
            {
                Console.WriteLine("N1 é menor do que n2.");
            }

           //Console.WriteLine(n1MaiorN2);
           //Console.WriteLine(n1MenorN2);
            Console.ReadKey();
        }
    }
}
