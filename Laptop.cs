using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakkalUygulama
{
    class Laptop
    {
        public string Marka;
        public string Model;
        public double Agirlik;
        public double Fiyat;

        public string Yazdir()
        {
            return string.Format("Marka={0}\tModel={1}\tAgirlik={2}\tFiyat={3} TL",Marka,Model,Agirlik,Fiyat);
        }

    }
}
