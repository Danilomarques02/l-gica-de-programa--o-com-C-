using System;
using System.Globalization;

namespace cursoc_007
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string nascimento;
            string nome;
            string endereco;
            string instrucao;
            string sexualidade;


            Console.Write("Digite o seu nome: ");
            nome = Console.ReadLine();
            Console.Write("Digite a data de nascimento: ");
            nascimento = Console.ReadLine();
            Console.Write("Digite o seu endereço: ");
            endereco = Console.ReadLine();
            Console.Write("Digite o seu grau de instrução: ");
            instrucao = Console.ReadLine();
            Console.Write("Digite a sua sexualidade: ");
            sexualidade = Console.ReadLine();
      
            Console.WriteLine("O seu nome é: "+ nome);
            Console.WriteLine("Você nasceu em: " + nascimento);
            Console.WriteLine("O seu endereço é em: " + endereco);
            Console.WriteLine("O seu grau de instrução é: " + instrucao);
            Console.WriteLine("A sua sexualidade é: " + sexualidade);           
                Console.ReadLine();
        }

    }
}