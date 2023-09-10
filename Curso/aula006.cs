using System;

namespace cursoc_007
{
    internal class Program
    {

        static void Main(string[] args)
        {
            double valorCompa = 5.50;
            double valorVenda;
            double lucro = 0.1;
            string produto = "Paste1";

            valorVenda = valorCompa + (valorCompa * lucro);

            Console.WriteLine("Produto........: {0,15},",produto);
            Console.WriteLine("Val.Compra.....: {0,15:c},", valorCompa);
            Console.WriteLine("Lucro..........: {0,15:p},", lucro);
            Console.WriteLine("Val.Venda......: {0,15:c},", valorVenda);


            Console.ReadLine();
        }

    }
}
