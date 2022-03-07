using System;
using jogoRPG.SRC.Entities;

namespace jogoRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 43, "Knight");
            Wizard jenica = new Wizard("Jenica", 43, "Wizard");
            BlackWizard wedge = new BlackWizard("Wedge", 43, "BlackWizard");
            Ninja topapa = new Ninja("Topapa", 43, "Ninja");

            Console.WriteLine(arus.Attack(2));
            Console.WriteLine(arus.Attack(7));
            Console.WriteLine(jenica.Attack(1));
            Console.WriteLine(jenica.Attack(9));
            Console.WriteLine(wedge.Attack(3));
            Console.WriteLine(wedge.Attack(10));
            Console.WriteLine(topapa.Attack(2));
            Console.WriteLine(topapa.Attack(6));
        }
    } 
}
