using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            // ürün tanımlama 1.yol
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;

            // ürün tanımlama 2.yol

            Product product2 = new Product { Id = 2, CategoryId = 5, UnitInStock = 5, ProductName = "Kalem", UnitPrice = 35 };

            ProductManager produtManager= new ProductManager();

            produtManager.Add(product1);
            Console.WriteLine(product1.ProductName);//kamera

           
            //int,double,bool... değer tip
            // diziler, class, bastract class, interface ... referans tip



        }
    }
}
