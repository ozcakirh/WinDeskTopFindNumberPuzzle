using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinDeskTopFindNumberPuzzle
{
    public partial class UserPredictive : UserControl
    {

        int Tahmin_Son = 0;

        //int Tahmin_BirOnceki = 0;

        int Tahmin_UretilenEnKucuk = 0;

        int Tahmin_UretilenEnBuyuk = 0;

        int DenemeSayim = 0;

        eSonucCevap TahmninSonCevap = eSonucCevap.HataVar;

        Random SayiHafizam = new Random(); 

        public string BenimAdim
        {
            set
            {
                olblAdim.Text = value;
            }

            get
            {
                return olblAdim.Text;
            }
        }

        // public delegate ICevapTrafigiSorana Sorgucu;

        private UserQuestioner oSunucu;

        public UserPredictive()
        {
            InitializeComponent();

            SayiHafizam.NextDouble();

            DenemeSayim = 0;

        }

        public UserQuestioner Sunucun
        {
            set
            {
                oSunucu = value;

                Tahmin_UretilenEnBuyuk = SunucuEnBuyukSayi;
            }
        }

        public UserPredictive(UserQuestioner Sunucu)
        {
            InitializeComponent();

            oSunucu = Sunucu;

            SayiHafizam.NextDouble();

            DenemeSayim = 1;

            Tahmin_UretilenEnBuyuk =  SunucuEnBuyukSayi; // ((ICevapTrafigiSorana)oSunucu).MaxSayim;

        }

        private void MesajTemizle()
        {
            olistboxCevaplar.Items.Clear();
        }

        private string MesajYaz
        {
            set
            {
               olistboxCevaplar.Items.Insert(0, string.Format("{0} : {1}" , DateTime.Now.ToLongTimeString() , value));

                Application.DoEvents();
            }
        }

        private int SunucuEnBuyukSayi
        {
            get
            {
                return ((ICevapTrafigiSorana)oSunucu).MaxSayim;
            }
        }

        private void Cevapla()
        {
            try
            {

                if (oSunucu == null)
                {
                    MesajYaz = "Sunucu Yok";

                    return;
                }

                if (TahmninSonCevap == eSonucCevap.Buldun)
                {
                    MesajYaz = String.Format("Yaw Brader, Zaten Bulmuşum, neden Tahin edeyim ki");

                    return;
                }

                MesajYaz = "Düşünüyorum";

                int TahminSayim = 0;

                

                if (oradio_RastGele.Checked)
                {


                    TahminSayim = SayiHafizam.Next(0, SunucuEnBuyukSayi);


                }
                else
                {
                    if (ochk_A_Modeli.Checked)
                    {
                        TahminSayim = (Tahmin_UretilenEnKucuk + Tahmin_UretilenEnBuyuk) / 2;
                    }
                    else {
                        TahminSayim = SayiHafizam.Next(Tahmin_UretilenEnKucuk, Tahmin_UretilenEnBuyuk);
                    }

                    
                    //if (TahmninSonCevap == eSonucCevap.SayinizKucuk)
                    //{
                    //    TahminSayim = SayiHafizam.Next(Tahmin_UretilenEnKucuk, Tahmin_UretilenEnBuyuk);

                    //    //    switch(TahmninSonCevap)
                    //    //    {
                    //    //        case eSonucCevap.SayinizKucuk: 

                    //    //            if (Tahmin_BirOnceki < Tahmin_Son)
                    //    //            {
                    //    //                TahminSayim = SayiHafizam.Next(Tahmin_Son + 1, Tahmin_UretilenEnBuyuk -1);
                    //    //            }
                    //    //            else
                    //    //            {
                    //    //                TahminSayim = SayiHafizam.Next(Tahmin_Son + 1, Tahmin_BirOnceki - 1);
                    //    //            }

                    //    //            break;
                    //    //    }


                    //    //}
                    //    //else
                    //    //{
                    //    //    if (TahmninSonCevap == eSonucCevap.SayinizBuyuk)
                    //    //    {
                    //    //        TahminSayim = SayiHafizam.Next(0 , Tahmin_Son - 1);
                    //    //    }
                    //    //    else
                    //    //    {
                    //    //        TahminSayim = SayiHafizam.Next(0, EnBuyukSayi);
                    //    //    }
                    //    //}
                    //    // TahminSayim = TahmninSonCevap == eSonucCevap.SayinizKucuk  ? (  SayiHafizam.Next(Tahmin_Son + 1, EnBuyukSayi) )
                    //    //              : ( TahmninSonCevap == eSonucCevap.SayinizBuyuk ? SayiHafizam.Next(0, Tahmin_Son -1) : 0) ;
                    //}
                }
                //Tahmin_BirOnceki = Tahmin_Son;

                Tahmin_Son = TahminSayim;

                MesajYaz = String.Format("Cevap Veriyorum : Bence, {0} ", Tahmin_Son);

                DenemeSayim++;

                CevaplamaMesaji Sonuc =  ((ICevapTrafigiSorana)oSunucu).Cevabim(BenimAdim, DenemeSayim, Tahmin_Son);

                if (Sonuc.VerilenCevap == eSonucCevap.Buldun)
                {
                    MesajYaz = String.Format("Helal bana, Buldum: <{0}>", Sonuc.VerilenMesaj);

                    TahmninSonCevap = Sonuc.VerilenCevap;

                    return;
                }

                if (Sonuc.VerilenCevap == eSonucCevap.HataVar)
                {
                    MesajYaz = Sonuc.VerilenMesaj;

                    return;
                }

                TahmninSonCevap = Sonuc.VerilenCevap;

                MesajYaz = String.Format("<{0}>", Sonuc.VerilenMesaj);

                if (TahmninSonCevap == eSonucCevap.SayinizBuyuk)
                {
                    Tahmin_UretilenEnBuyuk = Tahmin_Son; // - 1;
                }

                if (TahmninSonCevap == eSonucCevap.SayinizKucuk)
                {
                    Tahmin_UretilenEnKucuk = Tahmin_Son; // + 1;
                }


            }
            catch (Exception Ex)
            {

                MesajYaz = Ex.Message;
            }
        }

        private void olblAdim_DoubleClick(object sender, EventArgs e)
        {
            //
            Cevapla();
        }

        private void olblKonusmam_DoubleClick(object sender, EventArgs e)
        {
            TahmninSonCevap = eSonucCevap.HataVar;

            Tahmin_Son = 0;

            DenemeSayim = 0;

            Tahmin_UretilenEnKucuk = 0;

            Tahmin_UretilenEnBuyuk = SunucuEnBuyukSayi;
        }
    }
}
