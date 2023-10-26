using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace RigoDavidDoga231016
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var motorok = new List<Motor>();
            using StreamReader sr = new StreamReader
                (
                path: @"..\..\..\src\motorok.txt",
                encoding: System.Text.Encoding.UTF8
                ); 
            while (!sr.EndOfStream)
            {
                motorok.Add(new Motor(sr.ReadLine()));
            }
           
            Console.WriteLine($"1: {Atlag(motorok)}");

            Console.WriteLine(nagyobbmintezer(motorok));
            legkisebb(motorok).ToString();

            bmw(motorok).ToString();
            
            using StreamWriter writer = new StreamWriter
                (
                path: @"..\..\..\src\uj.txt",
                append:false
                );

            foreach (var x in motorok)
            {
                writer.WriteLine($"{x.gyarto} {x.modell}{x.gallon}");
            }
            



        }

        static double Atlag(List<Motor>motorok) 
        {
            
            var atlag =  Math.Round(motorok.Average(m => m.fogyasztas)); //NE ERŐLTESD AZ INT-ET
            return atlag;

        }
        static int nagyobbmintezer(List<Motor> motorok)
        {
            int counter = 0;
            
            foreach (var x in motorok)
            {
                
                if (x.urtartalom>1000)
                {
                    
                    Console.WriteLine(x.gyarto);
                    Console.WriteLine(x.modell);
                    Console.WriteLine("\n");

                      
                }
                
            }

            return counter;
            
        }
        static string legkisebb(List<Motor> motorok)
        {
            string legkisebb =(motorok.OrderBy(m => m.fogyasztas).First().gyarto).ToString();
            
            return legkisebb;
        }
        static void ize(List<Motor> motorok)
        {
            var suzuki = (motorok.Select(m => m.gyarto == "Suzuki"));
            
            string bmw = (motorok.Where(m => m.gyarto == "bmw").ToString());

          
        }
        static string bmw(List<Motor> motorok)
        {
            string moto = Convert.ToString(motorok.Select(m => m.gyarto == "BMW"));
            

            var max = (motorok.Where(m => m.maxseb > 300)); 
            foreach (var x in motorok)
            {
                if (x.gyarto == moto)
                {
                    Console.WriteLine($"{x.gyarto} {x.modell}");
                }
            }


            return moto;
        }




      



    }
}
