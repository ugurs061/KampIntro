using EntityFrameworkDemo;

GetAll();
//GetProductByCategory(1);

static void GetAll()
{
    NorthwindContext northwindContext = new NorthwindContext();
    foreach (var item in northwindContext.Products)
    {
        Console.WriteLine(item.ProductName);
    }
}

static void GetProductByCategory(int categoryId)
{
    NorthwindContext northwindContext = new NorthwindContext();
    var result = northwindContext.Products.Where(p => p.CategoryId == categoryId);
    foreach (var product in result)
    {
        Console.WriteLine(product.ProductName);
    }

}

