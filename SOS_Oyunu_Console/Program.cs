using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SOS_Oyunu
{
    class Program : SosAlani
    {
        static void Main(string[] args)
        {
            Console.Title = "SOS Oyunu | Yazan: Okan YALÇIN";
            Console.SetWindowSize(35, 18);
            Oyuncular oyuncular = new Oyuncular();
            GirisKontrolleri gk = new GirisKontrolleri();
            int k1skor = 0;
            int k2skor = 0;
            bool sosYapti = false;
            bool oyunBitti = false;
            #region Oyuncu isim girişleri
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n Birinci oyuncu ismini gir");
            oyuncular.birinciOyuncu = Console.ReadLine().ToString();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n İkinci oyuncu ismini gir");
            oyuncular.ikinciOyuncu = Console.ReadLine().ToString();
            #endregion            
            do
            {
                #region birinci oyuncu
                Console.Clear();
                Alan(oyuncular.birinciOyuncu, k1skor, oyuncular.ikinciOyuncu, k2skor); //ekrana sos alanı yazdırma
                #region Oyuncu klavye girişi
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(" {0} bir sayı gir", oyuncular.birinciOyuncu);
                gk.SayiGiris = int.Parse(Console.ReadLine());
                Console.WriteLine(" bir harf gir");
                gk.HarfGiris = Console.ReadLine().ToString().ToUpper();
                #endregion
                gk.HarfEkleme(ref k1skor, ref sosYapti, ref oyunBitti); //sos alanı harf ekleme ve sos olma kontrolü
                gk.sosOlduYazdir(ref sosYapti, k1skor, oyuncular.birinciOyuncu); //sos olduğunda yazdırma
                #endregion
                if (oyunBitti == true)
                {
                    Console.WriteLine("Oyun bitti");
                    break;
                }
                #region ikinci oyuncu
                Console.Clear();
                Alan(oyuncular.birinciOyuncu, k1skor, oyuncular.ikinciOyuncu, k2skor); //ekrana sos alanı yazdırma                
                #region Oyuncu klavye girişi
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(" {0} bir sayı gir", oyuncular.ikinciOyuncu);
                gk.SayiGiris = int.Parse(Console.ReadLine());
                Console.WriteLine(" bir harf gir");
                gk.HarfGiris = Console.ReadLine().ToString().ToUpper();
                #endregion
                gk.HarfEkleme(ref k2skor, ref sosYapti, ref oyunBitti); //sos alanı harf ekleme ve sos olma kontrolü    
                gk.sosOlduYazdir(ref sosYapti, k2skor, oyuncular.ikinciOyuncu); //sos olduğunda yazdırma
                #endregion
                if (oyunBitti == true)
                {
                    Console.WriteLine("Oyun bitti");
                    break;
                }
            } while (oyunBitti == false);
            if (k1skor > k2skor)
            {
                oyuncular.KazananKim(oyuncular.birinciOyuncu, k1skor, k2skor, "kazandı");
            }
            else if (k1skor < k2skor)
            {
                oyuncular.KazananKim(oyuncular.ikinciOyuncu, k2skor, k1skor, "kazandı");
            }
            else if (k1skor == k2skor)
            {
                oyuncular.KazananKim("", k1skor, k2skor, "berabere");
            }
            Console.ReadKey();
        }
    }
}
