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
                ); //NINCS USING BLOKKOD, NINCS LEZÁRVA A FÁJLOD
            while (!sr.EndOfStream)
            {
                motorok.Add(new Motor(sr.ReadLine()));
            }
            //NINCS KIÍRÁS
            Console.WriteLine($"1: {Atlag(motorok)}");

            Console.WriteLine(nagyobbmintezer(motorok));
            legkisebb(motorok).ToString();

            bmw(motorok).ToString();
            //ITT SINCS LEZÁRVA A FÁJL
            using StreamWriter writer = new StreamWriter
                (
                path: @"..\..\..\src\uj.txt",
                append:false
                );
            writer.WriteLine(utso(motorok));





        }

        static int Atlag(List<Motor>motorok) 
        {
            
            int atlag = (int)Math.Round(motorok.Average(m => m.fogyasztas)); //NE ERŐLTESD AZ INT-ET
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
            var suzuki = (motorok.Select(m => m.gyarto == "Suzuki"));//NE ERŐLTESD A MEGKAPOTT ÉRTÉK FORMÁJÁNAK ÁTALAKÍTÁSÁT
            //VAGY AZ EGÉSZ OBJEKTUMOT KERESSÜK, AKKOR: mOTOR A TÍPUSA;
            //VAGY EGY MEZŐJÉT KERESSÜK, AKKOR A MEZŐ TÍPUSA AZ EREDMÉNY
            //VAGY EGY LISTA JÖN KI, AKKOR A LISTA TÍPUSA MOTOR
            //MÁS ESETRE NINCS SZÜKSÉG SZINTE
            string bmw = (motorok.Where(m => m.gyarto == "bmw").ToString());

          
        }
        static string bmw(List<Motor> motorok)
        {
            string moto = Convert.ToString(motorok.Select(m => m.gyarto == "BMW"));//AZ ILYET LISTÁBA SZOKTUK TENNI, OLYAN, MINT EGY ADATBÁZIS LEKÉRDEZÉS
            //A TOSTRING NEM HASZNOS, NEM IS MŰKÖDIK ITT - ÉS SAJNOS NEM AD SZINTAKTIKAI HIBÁT
            //A SELECT EGYÉBKÉNT IS RITKÁBBAN HASZNOS

            int max = Convert.ToInt32(motorok.Where(m => m.maxseb > 300)); //LINQ-BAN NEMIGEN SZOKTUNK KONVERTÁLNI, MERT NEM KELL;
                                                                           //RÁ KELL JÖNNÖD, HOGY JOBB OLDALON MILYEN TÍPUS JÖN KI
            foreach (var x in motorok)
            {
                if (x.gyarto == moto || x.maxseb == max)
                {
                    Console.WriteLine($"{x.gyarto} {x.modell}");
                }
            }


            return moto;
        }




        static int utso(List<Motor> motorok) //EZT NEM KELLETT VOLNA ALPROGRAMBAN MEGÍRNI
        {
            int cucc = 0;
            foreach (var x in motorok)
            {
               
                    cw.WriteLine($"{x.gyarto} {x.modell}{x.gallon}"); //FÁJLBA KELLETT VOLNA
                
            }

            return cucc;
        }




    }
}
