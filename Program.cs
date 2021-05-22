using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakkalUygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            Veri v = new Veri();
            double toplam = 0;
            #region Ürün Oluşturma

            Laptop l1 = new Laptop()
            {
                Marka = "Lenovo",
                Model = "LV1500",
                Agirlik = 3.2,
                Fiyat = 5890
            };
            v.Ekle(l1);
            Laptop l2 = new Laptop()
            {
                Marka = "Casper",
                Model = "Excalibur",
                Agirlik = 7.9,
                Fiyat = 6000
            };
            v.Ekle(l2);
            Desktop d1 = new Desktop();
            d1.Marka = "HP";
            d1.Model = "HP159";
            d1.KasaTip = "ATX";
            d1.Fiyat = 4815;
            v.Ekle(d1);

            v.Ekle(new Tablet() { Marka = "Samgung", Model = "Tab10.1", Genislik = 10.1, Fiyat = 1200 });
            v.Ekle(new Laptop() { Marka = "HP", Model = "Omen7", Agirlik = 3.8, Fiyat = 9000 });

            #endregion

            Console.WriteLine("Merhaba Hoş geldiniz");

            while(true)
            {
                Console.WriteLine("-----Ürünler------");
                v.Listele();
                Console.WriteLine("Lütfen almak istediğiniz ürünün numarasını yazınız");
                string UrunNo = Console.ReadLine();
                toplam += v.Satis(UrunNo);

                Console.WriteLine("Alışverişe devam edilsin mi? e/h");
                string secenek = Console.ReadLine();
                if(secenek == "e")
                {
                    Console.Clear();
                }
                else
                {
                    break;
                }
            }
           


            Console.WriteLine("Ara Toplam = {0} TL", (toplam *0.82) );
            Console.WriteLine("KDV = {0} TL" , (toplam * 0.18));
            Console.WriteLine("Genel Toplam = {0} TL" , toplam);
        }
    }
}
