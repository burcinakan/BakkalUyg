using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakkalUygulama
{
    class Desktop
    {
        public string Marka;
        public string Model;
        public string KasaTip;
        public double Fiyat;

        public string Yazdir()
        {
            return string.Format("Marka={0}\tModel={1}\tKasa Tip={2}\tFiyat={3} TL", Marka, Model, KasaTip, Fiyat);
        }
    }
}
