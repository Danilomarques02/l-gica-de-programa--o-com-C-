using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoc_011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tempo = 0;
            char escolha;

        inicio:

            Console.Clear();


            Console.WriteLine("BH Horizonte/MG a Vitória/ES ");
            Console.WriteLine("Escolha o transporte:[a]Avião | [c]Carro | [o]Ônibus");
            escolha = char.Parse(Console.ReadLine()); 

            switch (escolha) {
                case 'a':
                case 'A':
                    tempo = 50;
                    break;
                case 'c':
                case 'C':
                    tempo = 480;
                    break;
                case 'o':
                case 'O':
                    tempo = 660;
                    break;
                default:
                    tempo = -1;
                    break;


            }
            if (tempo < 0)
            {
                Console.WriteLine("Transporte indisponivel");
            }
            else
            {
                Console.WriteLine("Para o  transporte escolhido o tempo é: {0} minutos", tempo);
            }

            Console.WriteLine("Calcular outro transporte?[s/n]");
            escolha = char.Parse(Console.ReadLine());
            if(escolha=='s' || escolha == 'S')
            {
                goto inicio;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Fim do programa");
            }
            escolha = char.Parse(Console.ReadLine());

            Console.ReadLine();



        }
    }
}