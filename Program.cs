using System;
using System.ComponentModel.Design;
using System.Globalization;

namespace Bil_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast Bilmærke");

            String Bilmærke = Console.ReadLine();


            Console.WriteLine("Indtast Bilmodel");

            String Bilmodel = Console.ReadLine();


            Console.WriteLine("Indtast Årgang");

            int Årgang = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Indtast Geartype, A eller M");

            Char GearType = Console.ReadLine()[0];


            Console.WriteLine("Det indtastet Er:");
            Console.WriteLine("Bilmærke" + " " + Bilmærke);
            Console.WriteLine("Bilmærke" + " " + Bilmodel);
            Console.WriteLine("Bilmærke" + " " + Årgang);
            Console.WriteLine("Bilmærke" + " " + GearType);
            Console.WriteLine("Er denne information korrekt? ja eller nej?");

            string input = Console.ReadLine().ToLower();

            bool ja;

            if (input == "ja")
                ja = true;
            else if (input == "nej")
                ja = false;
            else
                ja = false; // default hvis input er forkert


        }
    }
}
