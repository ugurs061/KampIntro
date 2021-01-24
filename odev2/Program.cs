using System;

namespace Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.UrunAdı = "MSİ bilgisayar";
            product1.Fıyat = 8000;
            product1.StokSayisi = 15;

            Product product2 = new Product();
            product2.UrunAdı = "Lenovo bilgisayar";
            product2.Fıyat = 7000;
            product2.StokSayisi = 10;

            Product[] urunler = new Product[] { product1, product2 };

            //foreach döngüsü ile

            //foreach (var urun in Urunler)
            //{
            //    Console.WriteLine("Ürün İsmi : " + urun.UrunAdı);
            //    Console.WriteLine("Fiyat : " + urun.Fıyat);
            //    Console.WriteLine("Stok Sayısı : " + urun.StokSayisi);
            //}


            // for döngüsü ile
            //for (int i = 0; i < 2 ; i++)
            //{
            //    Console.WriteLine("Ürün İsmi : " + urunler[i].UrunAdı);
            //    Console.WriteLine("Fiyat : " + urunler[i].Fıyat);
            //    Console.WriteLine("Stok Sayısı : " + urunler[i].StokSayisi);
            //}


            // While döngüsü ile 
            int j = 0;
            while (j < urunler.Length)
            {
                Console.WriteLine("Ürün İsmi : " + urunler[j].UrunAdı);
                Console.WriteLine("Fiyat : " + urunler[j].Fıyat);
                Console.WriteLine("Stok Sayısı : " + urunler[j].StokSayisi);
                j++;
            }
        }

    }
    class Product
    {
        public string UrunAdı { get; set; }
        public int Fıyat { get; set; }
        public int StokSayisi { get; set; }
    }
}
