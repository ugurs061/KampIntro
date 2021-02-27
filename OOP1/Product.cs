using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        //ürün fiyatı
        public double UnitPrice { get; set; }
        // ürün stok adeti
        public int UnitsInStock { get; set; }


    }
}
