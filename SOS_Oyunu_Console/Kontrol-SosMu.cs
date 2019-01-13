using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SOS_Oyunu
{
    partial class GirisKontrolleri
    {
        public void sosOlmaKontrolu(string _HarfGiris, int _SayiGiris, ref int kisi, ref bool sosYapti)
        {
            if (_SayiGiris > 0 && _SayiGiris < 10)
            {
                #region "s" harfi kontrolü
                if (_HarfGiris == "S")
                {
                    #region "s" harfi satır kontrolleri
                    if (_SayiGiris == 1 || _SayiGiris == 4 || _SayiGiris == 7)
                    {
                        if (_SayiGiris == 1 && sosAlani[0, 1] == "O" && sosAlani[0, 2] == "S")
                        {
                            sosYaptiArttir(ref sosYapti, ref kisi);
                        }
                        if (_SayiGiris == 4 && sosAlani[1, 1] == "O" && sosAlani[1, 2] == "S")
                        {
                            sosYaptiArttir(ref sosYapti, ref kisi);
                        }
                        if (_SayiGiris == 7 && sosAlani[2, 1] == "O" && sosAlani[2, 2] == "S")
                        {
                            sosYaptiArttir(ref sosYapti, ref kisi);
                        }
                    }
                    if (_SayiGiris == 3 || _SayiGiris == 6 || _SayiGiris == 9)
                    {
                        if (_SayiGiris == 3 && sosAlani[0, 0] == "S" && sosAlani[0, 1] == "O")
                        {
                            sosYaptiArttir(ref sosYapti, ref kisi);
                        }
                        if (_SayiGiris == 6 && sosAlani[1, 0] == "S" && sosAlani[1, 1] == "O")
                        {
                            sosYaptiArttir(ref sosYapti, ref kisi);
                        }
                        if (_SayiGiris == 9 && sosAlani[2, 0] == "S" && sosAlani[2, 1] == "O")
                        {
                            sosYaptiArttir(ref sosYapti, ref kisi);
                        }
                    }
                    #endregion
                    #region "s" harfi sütun kontrolleri
                    if (_SayiGiris == 1 || _SayiGiris == 2 || _SayiGiris == 3)
                    {
                        if (_SayiGiris == 1 && sosAlani[1, 0] == "O" && sosAlani[2, 0] == "S")
                        {
                            sosYaptiArttir(ref sosYapti, ref kisi);
                        }
                        if (_SayiGiris == 2 && sosAlani[1, 1] == "O" && sosAlani[2, 1] == "S")
                        {
                            sosYaptiArttir(ref sosYapti, ref kisi);
                        }
                        if (_SayiGiris == 3 && sosAlani[1, 2] == "O" && sosAlani[2, 2] == "S")
                        {
                            sosYaptiArttir(ref sosYapti, ref kisi);
                        }
                    }
                    if (_SayiGiris == 7 || _SayiGiris == 8 || _SayiGiris == 9)
                    {
                        if (_SayiGiris == 7 && sosAlani[1, 0] == "O" && sosAlani[0, 0] == "S")
                        {
                            sosYaptiArttir(ref sosYapti, ref kisi);
                        }
                        if (_SayiGiris == 8 && sosAlani[1, 1] == "O" && sosAlani[0, 1] == "S")
                        {
                            sosYaptiArttir(ref sosYapti, ref kisi);
                        }
                        if (_SayiGiris == 9 && sosAlani[1, 2] == "O" && sosAlani[0, 2] == "S")
                        {
                            sosYaptiArttir(ref sosYapti, ref kisi);
                        }
                    }
                    #endregion
                    #region çapraz kontroller
                    if (_SayiGiris == 1 && sosAlani[1, 1] == "O" && sosAlani[2, 2] == "S")
                    {
                        sosYaptiArttir(ref sosYapti, ref kisi);
                    }
                    if (_SayiGiris == 9 && sosAlani[1, 1] == "O" && sosAlani[0, 0] == "S")
                    {
                        sosYaptiArttir(ref sosYapti, ref kisi);
                    }
                    if (_SayiGiris == 3 && sosAlani[1, 1] == "O" && sosAlani[2, 0] == "S")
                    {
                        sosYaptiArttir(ref sosYapti, ref kisi);
                    }
                    if (_SayiGiris == 7 && sosAlani[1, 1] == "O" && sosAlani[0, 2] == "S")
                    {
                        sosYaptiArttir(ref sosYapti, ref kisi);
                    }
                    #endregion
                }
                #endregion
                #region "o" harfi kontrolü
                else if (_HarfGiris == "O")
                {
                    #region sütunun 2-5-8 girişini kontrol etme
                    if (_SayiGiris == 2 || _SayiGiris == 5 || _SayiGiris == 8)
                    {
                        if (_SayiGiris == 2 && sosAlani[0, 0] == "S" && sosAlani[0, 2] == "S")
                        {
                            sosYaptiArttir(ref sosYapti, ref kisi);
                        }
                        if (_SayiGiris == 5 && sosAlani[1, 0] == "S" && sosAlani[1, 2] == "S")
                        {
                            sosYaptiArttir(ref sosYapti, ref kisi);
                        }
                        if (_SayiGiris == 8 && sosAlani[2, 0] == "S" && sosAlani[2, 2] == "S")
                        {
                            sosYaptiArttir(ref sosYapti, ref kisi);
                        }
                    }
                    #endregion
                    #region satırın 4-5-6 girişini kontrol etme
                    if (_SayiGiris == 4 || _SayiGiris == 5 || _SayiGiris == 6)
                    {
                        if (_SayiGiris == 4 && sosAlani[0, 0] == "S" && sosAlani[2, 0] == "S")
                        {
                            sosYaptiArttir(ref sosYapti, ref kisi);
                        }
                        if (_SayiGiris == 5 && sosAlani[0, 1] == "S" && sosAlani[2, 1] == "S")
                        {
                            sosYaptiArttir(ref sosYapti, ref kisi);
                        }
                        if (_SayiGiris == 6 && sosAlani[0, 2] == "S" && sosAlani[2, 2] == "S")
                        {
                            sosYaptiArttir(ref sosYapti, ref kisi);
                        }
                    }
                    #endregion
                    #region çapraz kontrol
                    if (_SayiGiris == 5)
                    {
                        if (sosAlani[0, 0] == "S" && sosAlani[2, 2] == "S")
                        {
                            sosYaptiArttir(ref sosYapti, ref kisi);
                        }
                        if (sosAlani[0, 2] == "S" && sosAlani[2, 0] == "S")
                        {
                            sosYaptiArttir(ref sosYapti, ref kisi);
                        }
                    }
                    #endregion
                }
                #endregion
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("**********************");
                Console.WriteLine(" Hatalı rakam girişi!\a");
                Console.WriteLine("**********************");
                Console.ResetColor();
                Thread.Sleep(1200);
            }
        }
        public void sosOlduYazdir(ref bool sosYapti, int kisi, string oyuncu)
        {
            if (sosYapti == true)
            {
                Console.WriteLine("{0} " + kisi + " adet sos oluşturdunuz", oyuncu);
                Thread.Sleep(1500);
                sosYapti = false;
            }
        }
        public void sosYaptiArttir(ref bool sosYapti, ref int kisi)
        {
            kisi++;
            sosYapti = true;
        }        
    }
}
