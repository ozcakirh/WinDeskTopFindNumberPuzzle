using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinDeskTopFindNumberPuzzle
{
    public interface ICevapTrafigiSorana
    {

        int MaxSayim { get;  }

        CevaplamaMesaji Cevabim(string BenimAdi, int DenemeSayim, int CevapSayim);

    }

    public class CevaplamaMesaji
    {
        public eSonucCevap VerilenCevap { set; get; }

        public string VerilenMesaj { set; get; }
    }

    public enum eSonucCevap { SayinizKucuk, SayinizBuyuk, HataVar , Buldun}
}
