using System;
using System.Globalization;


namespace exercicioc_02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Identação : organizar o código (Ctrl + k + D)
            Console.WriteLine("--------- Compra Online ---------");
            Console.WriteLine();
            Console.WriteLine("--------- Dados Usuário ---------");
            Console.WriteLine("Digite o seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o seu saldo: ");
            double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("--------- Dados Produto ---------");
            Console.WriteLine();
            Console.WriteLine("Digite o nome do produto: ");
            string nomeProduto = Console.ReadLine();
            Console.WriteLine("Digite o valor do produto: ");
            double valorProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double saldoFinal = saldo - valorProduto;
            bool compraRealizada = saldoFinal >= 0;
            Console.WriteLine("---------- Log ----------");
            if (compraRealizada)
            {
                Console.WriteLine("Compra realizada com sucesso.");
            }
            else{
                Console.WriteLine("A compra não foi realizada.");
            }
            Console.ReadLine();
        }

    }
}
