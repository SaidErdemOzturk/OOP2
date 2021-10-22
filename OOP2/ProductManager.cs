using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Ekleme işlemi yapıldı"+product.ProductName);
        }

        public void Update(Product product)
        {
            Console.WriteLine("Güncelleme işlemi yapıldı" + product.ProductName);
        }
    }
}
