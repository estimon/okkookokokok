using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
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
                    Console.WriteLine("Bush tegi 911 xddd");
                    Console.ReadLine();
                        Uuskonto konto1 = new Uuskonto();
                        Console.WriteLine("Palun sisestage oma uue konto nimi:");
                        konto1.nimi = Console.ReadLine();
                    Console.WriteLine("OIIIIIIIIIIIIIIIIIIIIIII mittä nüüt");
                    Console.ReadLine();
                        Console.WriteLine("Palun sisestage oma uus salasõna:");
                        konto1.pin = Console.ReadLine();
                        konto1.vahendid = 0;
                        Console.WriteLine("Teie uue konto jääk on: " + konto1.vahendid);
                        Console.ReadLine();

                    string text = @"c:\Users\Opilane\Documents\GitHub\Tunnitöö\ConsoleApp2\ConsoleApp2\Kaust.txt";
                    
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
                        Console.WriteLine("Soovite luue veel ühe konto? (jah/ei)");
                        Console.ReadLine();                          
                        if (valik == "jah")
                        {
                            Uuskonto konto2 = new Uuskonto();
                            Console.WriteLine("Palun sisestage oma uue konto nimi:");
                            konto2.nimi = Console.ReadLine();
                            Console.WriteLine("Palun sisestage oma uus salasõna:");
                            konto2.pin = Console.ReadLine();
                            konto2.vahendid = 0;
                            Console.WriteLine("Teie uue konto jääk on: " + konto2.vahendid);
                            Console.ReadLine();


                            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"c:\Users\Opilane\Documents\GitHub\Tunnitöö\ConsoleApp2\ConsoleApp2\Kaust.txt", true))
                            {

                                file.WriteLine(konto2.nimi);
                                file.WriteLine(konto2.pin);
                                file.WriteLine(konto2.vahendid);
                            }
                            Console.WriteLine("Kirjutage \"start\", et tagasi algusesse minna");
                            string pucc = Console.ReadLine();
                            if (pucc == "start")
                            {
                                goto Start;
                            }


                        }
                        }
                    }

    
                }
          else if (valik == "2")
            {
                while (true)
                {
                   

                }
                
                

            }







        }
    }
}
