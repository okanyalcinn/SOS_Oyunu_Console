using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SOS_Oyunu
{    
    partial class GirisKontrolleri : SosAlani
    {
        public void HarfEkleme(ref int kisi, ref bool sosYapti, ref bool oyunBitti)
        {
            for (int str = 0; str < sosAlani.GetLength(0); str++)
            {
                for (int stn = 0; stn < sosAlani.GetLength(1); stn++)
                {
                    if (sosAlani[str, stn] == SayiGiris.ToString())
                    {
                        sosAlani[str, stn] = HarfGiris;
                        sosOlmaKontrolu(HarfGiris, SayiGiris, ref kisi, ref sosYapti);
                        break;
                    }
                }
            }
            if (sosAlani[0, 0] != "1")
                if (sosAlani[0, 1] != "2")
                    if (sosAlani[0, 2] != "3")
                        if (sosAlani[1, 0] != "4")
                            if (sosAlani[1, 1] != "5")
                                if (sosAlani[1, 2] != "6")
                                    if (sosAlani[2, 0] != "7")
                                        if (sosAlani[2, 1] != "8")
                                            if (sosAlani[2, 2] != "9")
                                                oyunBitti = true;
        }
    }
}
