//Argumento params

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursosC_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            soma(19,5,2,4,6,3);

        }
 
        static void soma(params int[]n)
        {
            int res = 0;

            if(n.Length < 1)
            {
                Console.WriteLine("Não existem valores a serem somados");
            }else if(n.Length < 2)
            {
                Console.WriteLine("Valores insuficientes para soma: {0}", n[0]);
            }
            else
            {
                for(int i=0;i<n.Length; i++)
                {
                    res += n[i];
                }
            }
            Console.WriteLine("A soma dos valores é: {0}", res);
            Console.ReadLine();
        }
    }
}