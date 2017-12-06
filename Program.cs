using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
                
                    Start:
                    Console.WriteLine("Tere, mida soovite teha: 1 luua konto/2 kontrollida jääki/3 raha väljavõtta/4 raha sissepanna");
                string valik = Console.ReadLine();


                if (valik == "1")
                {
                    while (true)
                    {
                        Uuskonto konto1 = new Uuskonto();
                        Console.WriteLine("Palun sisestage oma uue konto nimi:");
                        konto1.nimi = Console.ReadLine();
                        Console.WriteLine("Palun sisestage oma uus salasõna:");
                        konto1.pin = Console.ReadLine();
                        konto1.vahendid = 0;
                        Console.WriteLine("Teie uue konto jääk on: " + konto1.vahendid);
                        Console.ReadLine();

                    string text = @"c:\Users\Martin Ploompuu\Desktop\Kasutajad\uus.txt";
                    
                    using (StreamWriter sw = File.CreateText(text))

                    {
                        sw.WriteLine(konto1.nimi);
                        sw.WriteLine(konto1.pin);
                        sw.WriteLine(konto1.vahendid);
                    }
                        
                        
                    Console.WriteLine("Kirjutage \"back\", et tagasi minna");
                    string ayy = Console.ReadLine();
                    if (ayy == "back")
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
          else if (valik == "2")
            {
                while (true)
                {
                    string line3 = File.ReadLines("uus.txt").Last();
                    line3 = Console.ReadLine();
                }
                
                

            }







        }
    }
}
