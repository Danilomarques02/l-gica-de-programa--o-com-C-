using System;


struct Carro
{
    public string marca;
    public string modelo;
    public string cor;
    public Carro(string marca, string modelo,string cor)
    {
        this.marca = marca;
        this.modelo = modelo;
        this.cor = cor;
    }
    public void info()
    {
        Console.WriteLine("Marca.: {0}", this.marca);
        Console.WriteLine("Modelo: {0}", this.modelo);
        Console.WriteLine("Cor...: {0}", this.cor);
    }
}

namespace aulac_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro c1=new Carro("Honda","HRV","Prata");
            Carro c2 = new Carro("VW", "Gold", "Azul");

            //c1.marca = "VW" ;
            //c1.modelo = "Golf";
            //  c1.cor = "Azul";


            c1.info();
            c2.info();

            Console.ReadLine();
        }

    }
}