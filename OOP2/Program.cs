using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product();
            product1.Id = 2;
            product1.CategoryId = 5;
            product1.ProductName = "kalem";
            product1.UnitPrice = 35;
            product1.UnitsInStock = 5;

            ProductManager productManager = new ProductManager();

            productManager.Add(product1);


        }
    }
}
