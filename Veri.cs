using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakkalUygulama
{
    class Veri
    {
        Laptop[] laptoplar;
        Desktop[] Desktoplar;
        Tablet[] Tabletler;

        public Veri()
        {
            laptoplar = new Laptop[0];
            Desktoplar = new Desktop[0];
            Tabletler = new Tablet[0];
        }

        public void Ekle(Laptop l)
        {
            Laptop[] gecici = new Laptop[laptoplar.Length + 1];
            for (int i = 0; i < laptoplar.Length; i++)
            {
                gecici[i] = laptoplar[i];
            }
            gecici[gecici.Length - 1] = l;
            laptoplar = gecici;
        }
        public void Ekle(Desktop d)
        {
            Desktop[] gecici = new Desktop[Desktoplar.Length + 1];
            for (int i = 0; i < Desktoplar.Length; i++)
            {
                gecici[i] = Desktoplar[i];
            }
            gecici[gecici.Length - 1] = d;
            Desktoplar = gecici;
        }
        public void Ekle(Tablet t)
        {
            Tablet[] gecici = new Tablet[Tabletler.Length + 1];
            for (int i = 0; i < Tabletler.Length; i++)
            {
                gecici[i] = Tabletler[i];
            }
            gecici[gecici.Length - 1] = t;
            Tabletler = gecici;
        }
        public void Listele()
        {
            for (int i = 0; i < laptoplar.Length; i++)
            {
                Console.WriteLine("100" +i + ") " + laptoplar[i].Yazdir());
            }
            for (int i = 0; i < Desktoplar.Length; i++)
            {
                Console.WriteLine("200" + i + ") " + Desktoplar[i].Yazdir());
            }
            for (int i = 0; i < Tabletler.Length; i++)
            {
                Console.WriteLine("300" + i + ") " + Tabletler[i].Yazdir());
            }
        }
        public double Satis(string urunNo)
        {
            //char ilkKarakter = urunNo[0];
            //string str_katNo = Convert.ToString(ilkKarakter);
            //int KatNo = Convert.ToInt32(str_katNo);

            //int KatNo = int.Parse(urunNo[0].ToString());
            //int.Parse string verileri int türüne döndürmek için kullanılan ayrı bir metotdur

            int KatNo = Convert.ToInt32(urunNo[0].ToString());
            double fiyat = 0;
            switch (KatNo)
            {
                case 1:
                    fiyat = laptoplar[Convert.ToInt32(urunNo) - 1000].Fiyat;
                    break;//her case kullanımının sonunda break kullanmak zorunludur
                case 2:
                    fiyat = Desktoplar[Convert.ToInt32(urunNo) - 2000].Fiyat;
                    break;
                case 3:
                    fiyat = Tabletler[Convert.ToInt32(urunNo) - 3000].Fiyat;
                    break;
                default://else gibi düşünebilirsiniz. Üsttekilerden hiçbiri çalışmaz ise bu çalışır
                    break;
            }
            return fiyat;
        }
    }
}
