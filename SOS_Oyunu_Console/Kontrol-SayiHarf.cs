using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SOS_Oyunu
{
    partial class GirisKontrolleri
    {
        public static int _deneme = 0;
        private int sayi { get; set; }
        private string harf { get; set; }

        // Dışardan gelen sayıyı içeride işlemek için        
        public int SayiGiris
        {
            get
            {
                return sayi;
            }
            set
            {
                if (value >= 1 && value <= 9)
                    sayi = value;
                else
                    sayi = 0;
            }
        }
        // Dışarıdan gelen harfi içeride işlemek için        
        public string HarfGiris
        {
            get
            {
                if (harf == "S" || harf == "O")
                    return harf;
                else
                    return sayi.ToString();
            }
            set
            {
                harf = value;
            }
        }
    }    
}
