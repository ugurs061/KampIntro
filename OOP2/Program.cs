
using OOP2;

GercekMusteri musteri1 = new GercekMusteri();
musteri1.Id = 1;
musteri1.MusteriNo = "61";
musteri1.Adi = "Uğur";
musteri1.Soyadi = "Sağlam";
musteri1.TcNo = "12345678910";

TuzelMusteri musteri2 = new TuzelMusteri();
musteri2.Id= 2;
musteri2.MusteriNo = "6";
musteri2.SirketAdi = "ArkSoft";
musteri2.VergiNo = "1234567890";

// SOlID

Customer musteri3 = new GercekMusteri();
Customer musteri4 = new TuzelMusteri();

CustomerManager customerManager = new CustomerManager();
customerManager.Add(musteri1);// Customer sınıfı, GercekMusteri ve TuzelMusteri sınıflarının referansını tutabilmektedir.
customerManager.Add(musteri2);

