using System;
using System.Globalization;

namespace cursoc_007
{
    internal class Program
    {

        enum DiasSemana {Domingo, Segunda,Terça, Quarta, Quinta, Sexta, Sábado };
        static void Main(string[] args)
        {

            int ds = (int)DiasSemana.Sexta;

            Console.WriteLine(ds);
            Console.ReadLine();
        }

    }
}
