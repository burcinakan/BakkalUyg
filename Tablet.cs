using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakkalUygulama
{
    class Tablet
    {
        public string Marka;
        public string Model;
        public double Genislik;
        public double Fiyat;

        public string Yazdir()
        {
            return string.Format("Marka={0}\tModel={1}\tGenislik={2}\tFiyat={3} TL", Marka, Model, Genislik, Fiyat);
        }
    }
}
