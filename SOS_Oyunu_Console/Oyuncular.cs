using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SOS_Oyunu
{
    class Oyuncular
    {
        public string birinciOyuncu { get; set; }
        public string ikinciOyuncu { get; set; }
        public void KazananKim(string oyuncu, int kazananSkoru, int kaybedenSkoru, string sonuc)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Thread.Sleep(130);
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Thread.Sleep(130);
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            Thread.Sleep(130);
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\n\n\n\tSOS ALANI BİTTİ\n");
            Console.WriteLine("\n\t     "+ kazananSkoru +" "+kaybedenSkoru);
            Console.WriteLine("\n\n\t " + oyuncu.ToUpper() + " " + sonuc.ToUpper() );
        }
    }
}
