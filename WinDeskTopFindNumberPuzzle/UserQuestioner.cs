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
    public partial class UserQuestioner : UserControl , ICevapTrafigiSorana
    {

        private int MaxHaneSayisi = 5;

        private int oTahminEdilecekSayi = 0;

        private int oSayiUret
        {
            set
            {
                if (!otxtIstenenSayi.Enabled) return;

                    otxtIstenenSayi.Text = String.Format("{0}", value);

            }

            get
            {
                return otxtIstenenSayi.Text.Length < 1 ? 0 : int.Parse(otxtIstenenSayi.Text);
            }


        }

        public Color oBackColor
        {
            set
            {
                this.BackColor = value;
            }
            get
            {
                return this.BackColor;
            }
        }

        public int MaxSayim
        {
            get
            {
                string tmpS = "0";

                for (int i = 0; i < MaxHaneSayisi; i++)
                {
                    tmpS += "9";
                }

                return int.Parse(tmpS);
            }
        }

        SayiHavuzu oSayiCek;

        public UserQuestioner()
        {
            InitializeComponent();

            oSayiCek = new SayiHavuzu(MaxHaneSayisi);

            oSayiCek.lCDSayiCekilisGoster += SayiCekilisiGoster;

        }

        private void SayiCekilisiGoster(string CekilenSayi)
        {
            otxtIstenenSayi.Text = CekilenSayi;

            Application.DoEvents();
        }
 
        private void BtnSayiUret_Click(object sender, EventArgs e)
        {
            oSayiUret = oSayiCek.SayiVer;


        }

        private void BtnStartGame_Click(object sender, EventArgs e)
        {
            try
            {
                if (!otxtIstenenSayi.Enabled)
                {
                    BtnStartGame.Text = "Oyunu Başlat";

                    otxtIstenenSayi.Enabled = true;

                    return;
                }

                BtnStartGame.Text = "Oyunu Bitir";

                oTahminEdilecekSayi = oSayiUret;
                
                otxtIstenenSayi.Enabled = false;

                olblMsg.Text = String.Format("Tahmin Edilecek Sayı : {0}", oTahminEdilecekSayi);



            }
            catch (Exception Ex)
            {

                olblMsg.Text = Ex.Message;

            }
        }

        public CevaplamaMesaji Cevabim(string BenimAdim, int DenemeSayim, int CevapSayim)
        {
            try
            {
                if (otxtIstenenSayi.Enabled)
                {
                    return new CevaplamaMesaji()
                    {
                        VerilenCevap = eSonucCevap.Yok,
                        VerilenMesaj = String.Format("Yarışmamız Şu An Kapalı.")
                    };

                }

                if (oTahminEdilecekSayi == CevapSayim)
                {
                    return new CevaplamaMesaji() { VerilenCevap = eSonucCevap.Buldun, 
                                VerilenMesaj = String.Format("Tabrikler {0}, {1} Denemenizde Sayımı Tahmin Ettin.", BenimAdim, DenemeSayim ) };
                }

                return new CevaplamaMesaji()
                {
                    VerilenCevap = oTahminEdilecekSayi < CevapSayim ? eSonucCevap.SayinizBuyuk :  eSonucCevap.SayinizKucuk ,
                    VerilenMesaj = String.Format("Malesef {0}, {1} Denemenizde Sayımı Tahmin Edemedin.", BenimAdim, DenemeSayim)
                };


            }
            catch (Exception Ex)
            {
                olblMsg.Text = "Hata Yaptım : " + Ex.Message;

                return new CevaplamaMesaji() { VerilenCevap = eSonucCevap.HataVar, VerilenMesaj = olblMsg.Text };

               
            }
        }
    }

  
}
