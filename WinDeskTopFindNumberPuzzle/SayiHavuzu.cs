using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinDeskTopFindNumberPuzzle
{

    public class SayiHavuzu
    {
        public dLCDSayiCekilisGoster lCDSayiCekilisGoster;

        private Random SayiUretici = new Random();

        int jSayiTekrarOyuncu = 65;

        int jSayiTekrar = 60;

        int jSayiTekrarMax = 75;

        int jSayiTekrarMin = 58;


        int jSayiTekrarWaitms = 11;

        int oHaneSayisiMax = 5;

        int oHaneSayisi = 5;

        int[] Haneler;

        public SayiHavuzu(int HaneSayisi)
        {
            SayiUretici.NextDouble();

            oHaneSayisi = HaneSayisi;

            if (HaneSayisi > oHaneSayisiMax) HaneSayisi = oHaneSayisiMax;

            Haneler = new int[HaneSayisi];

        }

        private string SayiGoster
        {
            get
            {
                string SayiTemp = "0";

                for (int i = 0; i < oHaneSayisi; i++)
                {
                    SayiTemp += Haneler[i].ToString();
                }

                return SayiTemp;

            }
        }

        public int SayiVer
        {
            get
            {
                Haneler = new int[oHaneSayisi];

                

                for (int i = 0; i < oHaneSayisi; i++)
                {
                    Haneler[i] = 0;
                }

                double tmpSayi = 0;

                for (int i = oHaneSayisi - 1 ; i >= 0 ; i--)
                {
                    for (int j = 0; j < jSayiTekrar; j++)
                    {
                        tmpSayi = 0;

                        tmpSayi = (int)((SayiUretici.NextDouble() * 10) + 1);

                        System.Threading.Thread.Sleep(50);

                        tmpSayi = tmpSayi > 9 ? 9 : (int)tmpSayi;

                        if (i == 0 && tmpSayi == 0) tmpSayi = 1;

                        Haneler[i] = (int)tmpSayi;

                        if (lCDSayiCekilisGoster != null)
                        {
                            lCDSayiCekilisGoster(SayiGoster);
                        }
                    }

                    jSayiTekrar = jSayiTekrar <= jSayiTekrarOyuncu ? jSayiTekrarMax : jSayiTekrarMin;



                }

                return int.Parse(SayiGoster);

            }
        }
    }

    public delegate void dLCDSayiCekilisGoster(string Sayi);
}
