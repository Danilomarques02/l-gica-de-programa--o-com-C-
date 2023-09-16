//Sobrecarga de Construtores

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
    public Jogador()
    {
        energia = 100;
        vivo = true;
        nome = "Jogador";

    }
    public Jogador(string n)
    {
        energia = 100;
        vivo = true;
        nome = n;
    }
    public Jogador(string n, int e)
    {
        energia = e;
        vivo = true;
        nome = n;
    }
    public Jogador(string n,int e,bool v)
    {
        energia = e;
        vivo = v;
        nome = n;
    }
    public void  info()
    {
        Console.WriteLine("Nome jogador: {0}", nome);
        Console.WriteLine("Energia jogador:{0}", energia);
        Console.WriteLine("Estado jogador:{0}\n", vivo);
    }
 