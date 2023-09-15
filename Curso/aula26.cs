using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Jogador
{
    public int energia;
    public bool vivo;
    public string nome;
    public Jogador(string n)
    {
        energia = 100;
        vivo = true;
        nome = n;
    }
    ~Jogador()
    {
        Console.WriteLine("Jogador {0} foi destruido", nome);
    }
} 
namespace cursosC_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome1;
            Console.WriteLine("Digite o nome do jogador 1: ");
            nome1 = Console.ReadLine();
            Jogador j1 = new Jogador(nome1);
            Jogador j2 = new Jogador("Breno");




            Console.WriteLine("Nome do jogador 1: {0}", j1.nome);
            Console.WriteLine("Nome do jogador 2: {0}", j2.nome);
            Console.ReadLine();
        }
 
       
    }
}
