using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shopping.Data.DataModels;

namespace Shopping.Data
{
    public class DataContext
    {
        public IEnumerable<ShoppingCart> GetAllShoppingCartContent()
        {
            return new List<ShoppingCart>
            {
                new ShoppingCart()
                {
                    Id = 1,
                    Products =
                        new List<Product>()
                        {
                            new Product() {ProductId = 1, Name = "Bread"},
                            new Product() {ProductId = 2, Name = "Milk"}
                        }
                },
                new ShoppingCart()
                {
                    Id = 2,
                    Products =
                        new List<Product>()
                        {
                            new Product() {ProductId = 1, Name = "Towel"},
                            new Product() {ProductId = 2, Name = "Soap"}
                        }
                }
            };
        }

        public ShoppingCart FindShoppingCartContentById(int Id)
        {
            return new ShoppingCart()
            {
                Id = 1,
                Products =
                    new List<Product>()
                    {
                        new Product() {ProductId = 1, Name = "Bread"},
                        new Product() {ProductId = 2, Name = "Milk"}
                    }
            };
        }

        public ShoppingCart AddShoppingCartContent(Product product)
        {
            return new ShoppingCart()
            {
                Id = 3,
                Products =
                    new List<Product>()
                    {
                        new Product() {ProductId = 3, Name = "Meat"}
                    }
            };
        }
    }
}
