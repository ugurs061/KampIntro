
using System.Security.Cryptography.X509Certificates;

List<Category> categories = new List<Category>
{
   new Category{CategoryId=1, CategoryName="Bilgisayar"},
   new Category{CategoryId=2, CategoryName="Telefon"}
};

List<Product> products = new List<Product>
{
    new Product{CategoryId=1, ProductId=1, ProductName="Acer Laptop", QuantityPerUnit="32 gb ram", UnitPrice=10000, UnitsInStok=5 },
    new Product{CategoryId=1, ProductId=2, ProductName="Asus Laptop", QuantityPerUnit="16 gb ram", UnitPrice=8000, UnitsInStok=3 },
    new Product{CategoryId=1, ProductId=3, ProductName="Hp Laptop", QuantityPerUnit="8 gb ram", UnitPrice=6000, UnitsInStok=2 },
    new Product{CategoryId=2, ProductId=4, ProductName="Samsung Telefon", QuantityPerUnit="4 gb ram", UnitPrice=5000, UnitsInStok=15 },
    new Product{CategoryId=2, ProductId=5, ProductName="Apple Telefon", QuantityPerUnit="4 gb ram", UnitPrice=8000, UnitsInStok=0 }
};


/*
var result = products.Where(x => x.UnitPrice > 5000 && x.UnitsInStok > 3);// Where; koşulda eşleşen verileri liste tipinde tutar.
foreach (var product in result)
{
    Console.WriteLine(product.ProductName);
}

static List<Product> GetProductsLinq(List<Product> products) 
{
    return products.Where(x => x.UnitPrice > 5000 && x.UnitsInStok > 3).ToList();
}
*/

/*
var result = products.Any(x => x.ProductName == "Acer Laptop");// Any; var mı ? sorunu sorar ve true/false olarak geri döndürür.
Console.WriteLine(result);,
*

/*
var result = products.Find(p => p.ProductId == 1); //Find; şarta uyan nesneyi döndürür.
Console.WriteLine(result.ProductName);
*/

/*
var result = products.FindAll(x=> x.ProductName.Contains("top")); // FindAll; o şarta uyan bütün elemanları getir. liste tipinde döner
Console.WriteLine(result);      
*/

// var result = products.Where(x => x.UnitPrice > 5000 && x.UnitsInStok > 3).OrderByDescending(x => x.UnitPrice).ThenByDescending(x=> x.ProductName); // OrderByDes; tersten sırala, ThenByDescending; ondan sonra tersten bunu sırala anlamına gelir.

/*
var result = from p in products
             where p.UnitPrice>6000
             orderby p.UnitPrice descending, p.ProductName ascending
             select new ProductDto {ProductId=p.ProductId,ProductName=p.ProductName,UnitPrice=p.UnitPrice };

foreach (var product in result)
{
    Console.WriteLine(product.ProductName);
}
*/



var result = from p in products
             join c in categories
             on p.CategoryId equals c.CategoryId
             select new ProductDto { ProductId = p.ProductId, CategoryName = c.CategoryName, ProductName = p.ProductName, UnitPrice = p.UnitPrice };

foreach (var productDto in result)
{
    Console.WriteLine(productDto.ProductName + "-" + productDto.CategoryName);
}


class ProductDto
{
    public int ProductId { get; set; }
    public string CategoryName { get; set; }
    public string ProductName { get; set; }
    public decimal UnitPrice { get; set; }
}
class Product
{
    public int ProductId { get; set; }
    public int CategoryId { get; set; }
    public string ProductName { get; set; }
    public string QuantityPerUnit { get; set; }
    public decimal UnitPrice { get; set; }
    public int UnitsInStok { get; set; }
}
class Category
{
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
}