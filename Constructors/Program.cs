using System.Security.Cryptography;

Customer customer1 = new Customer {Id=1,FirstName= "Uğur",LastName="Demiroğ", City= "Trabzon"};
Customer customer2 = new Customer(2,"emir","c","Ankara");// normal parantez method mantığı
Console.WriteLine(customer2.FirstName);


class Customer // Class içinde özellik tanımladım.
{
    public Customer()// default constructor
    {

    }
    public Customer(int id, string firstName, string lastName, string city)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        City = city;

    }
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string  City { get; set; }
}