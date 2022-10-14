
List<Category> categories = new List<Category>
{
   new Category{CategoryId=1, CategoryName="Bilgisayar"},
   new Category{CategoryId=1, CategoryName="Telefon"}
};

List<Product> products = new List<Product>
{
    new Product{CategoryId=1, ProductId=1, ProductName="Acer Laptop", QuantityPerUnit="32 gb ram", UnitPrice=10000, UnitsInStok=5 },
    new Product{CategoryId=2, ProductId=1, ProductName="Asus Laptop", QuantityPerUnit="16 gb ram", UnitPrice=8000, UnitsInStok=3 },
    new Product{CategoryId=3, ProductId=1, ProductName="Hp Laptop", QuantityPerUnit="8 gb ram", UnitPrice=6000, UnitsInStok=2 },
    new Product{CategoryId=4, ProductId=2, ProductName="Samsung Telefon", QuantityPerUnit="4 gb ram", UnitPrice=5000, UnitsInStok=15 },
    new Product{CategoryId=5, ProductId=2, ProductName="Apple Telefon", QuantityPerUnit="4 gb ram", UnitPrice=8000, UnitsInStok=0 }
};

Console.WriteLine("Hello, World!");

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