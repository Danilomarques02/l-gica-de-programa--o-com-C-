//Membros Protected 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Veiculo
{//Base

    public int velAtual;
    private int VelMax;
    protected bool ligado;
    public Veiculo(int velMax)
    {
        velAtual = 0;
        this.VelMax = velMax;
        ligado = false;
    }
    public bool getLigado()
    {
        return ligado;
    }

    public int getVelMax()
    {
        return VelMax;
    }
}

class Carro : Veiculo//Derivada de veiculo
{
    public string nome;

    public Carro(string nome, int vm):base(vm)
    {
        this.nome = nome;
        ligado = true;
    }
}
namespace aulac_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro("Bonitão", 120);

            Console.WriteLine("Nome......:{0}", carro.nome);
            Console.WriteLine("Vel.Máxima:{0}", carro.getVelMax());
            Console.WriteLine("Ligado....:{0}", carro.getLigado());


            Console.ReadLine();
        }
    }
}