using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Yazım şekli
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoriyId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;
            //2.yazım şekli
            Product product2 = new Product { Id = 2, CategoriyId = 5, 
                UnitsInStock = 5, ProductName = "Kalem", UnitPrice = 35 };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
        
        
        
        }
    }
}
