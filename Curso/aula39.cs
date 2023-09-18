//Interfaces

using System;
using System.Diagnostics.Eventing.Reader;

public interface Veiculo {

    void ligar();
    void desligar();
    void info();
}
public interface Combate
{
    void disparar();
}

class Carro:Veiculo,Combate
{
    public bool ligado;
    private int municao;
   public Carro()
    {
        setMunicao(100);
    }

    public void setMunicao(int qtde)
    {
        this.municao = qtde;
    }
    public void ligar()
    {
        this.ligado = true;
    }
    public void desligar()
    {
        this.ligado = false;
    }

    public void disparar()
    {

    }
    public void info()
    {

    }
}

namespace aulac_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro c1 = new Carro();
            Console.ReadLine();
        }
       
    }
}