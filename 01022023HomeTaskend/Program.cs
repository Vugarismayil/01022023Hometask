using System;

namespace _01022023HomeTaskend
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();

            Product laptop = new Product
            {
                Category = "Laptop",
                Price = 2000,
                ProductNumber = "L01"
            };

            Product phone = new Product
            {
                Category = "Phone",
                Price = 900,
                ProductNumber = "P01"
            };

            try
            {
                store.AddProduct(laptop);
                store.AddProduct(phone);
                
                
            }
            catch (Exception)
            {
                Console.WriteLine("Eyni nomreli mehsul artiq movcuddur.");
            }
        }
    }
}
