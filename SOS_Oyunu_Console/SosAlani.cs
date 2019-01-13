using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOS_Oyunu
{
    class SosAlani
    {
        public static string[,] sosAlani = new string[3, 3]
        {
            { "1", "2","3" },
            { "4", "5","6" },
            { "7", "8","9" }
        };
        public static void Alan(string birinciOyuncu, int k1skor, string ikinciOyuncu, int k2skor)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n\tOyun durumu\n");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < sosAlani.GetLength(0); i++)//sos alanı ekrana yazdırma
            {
                Console.Write("\t ");
                for (int k = 0; k < sosAlani.GetLength(1); k++)
                {
                    Console.Write(sosAlani[i, k] + "  ");
                }
                Console.WriteLine("\n");
            }//sos Alanı gösterme
            Console.WriteLine("\tSOS skoru");
            Console.WriteLine("   {0}: {1} | {2}: {3}\n", birinciOyuncu.ToUpper(), k1skor, ikinciOyuncu.ToUpper(), k2skor);
        }
    }
}
