using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
        Start:
            Console.WriteLine("Tere, mida soovite teha: luua konto/ kontrollida jääki/raha väljavõtta/raha sissepanna");
            string valik = Console.ReadLine();


            if (valik == "luua konto")
            {
                while (true)
                {
                    Uuskonto konto1 = new Uuskonto();
                    Console.WriteLine("Palun sisestage oma uue konto nimi:");
                    konto1.nimi = Console.ReadLine();
                    Console.WriteLine("Palun sisestage oma uus salasõna:");
                    Console.ReadLine();
                    konto1.vahendid = 0;
                    Console.WriteLine("Teie uue konto jääk on: " + konto1.vahendid);
                    Console.ReadLine();
                    Console.WriteLine("Kirjutage \"back\", et tagasi minna ");
                    string text = Console.ReadLine();
                    if (text == "back")
                        Console.WriteLine("Olete kindel?(jah/ei)");
                    string valik2 = Console.ReadLine();
                    if (valik2 == "jah") 
                    {
                        goto Start;
                    }
                    else if (valik2 == "ei")
                    {
                        return;
                    }
                }
            }


            
            
            
        
        }
    }
}
