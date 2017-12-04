using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsolePrintNamen
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> namen = new List<string>();
            namen.Add("Dante");
            namen.Add("Nick");
            namen.Add("Thibault");
            namen.Add("Indy");
            PrintNamen(namen);
            Console.ForegroundColor = ConsoleColor.Red;

            List<string> FilterNamen = new List<string>();
            foreach ( string naam in namen)
            {
                if (naam.Length < 5)
                {
                    FilterNamen.Add(naam);
                }
            }

            PrintNamen(FilterNamen);
            Console.ResetColor();

            List<int> getallen = new List<int>() { -3, -5, 8, 13, 35, 67, 4, 6 };
            List<int> geFilterdeGetallen = FilterGetallen(getallen);
            Getallen(geFilterdeGetallen);
            
        }
        static void PrintNamen(List<string> namen)
        {
            foreach (string naam in namen)
            {
                Console.WriteLine(naam);
            }
        }
        static List<int> FilterGetallen(List<int> getallen)
        {
            List<int> geFilterdeGetallen = new List<int>();
            foreach ( var getal in getallen)
            {
                if (getal >= 0 && getal <= 10)
                {
                    geFilterdeGetallen.Add(getal);
                }
               
            }
            return geFilterdeGetallen;  
        }
        static void Getallen(List<int> getallen)
        {
            foreach (int getal in getallen)
            {
                Console.WriteLine(getal);
            }
        }


    }
}
