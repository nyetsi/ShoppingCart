using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLayer.Interfaces;
using Shopping.Data;
using Shopping.Data.DataModels;

namespace ServiceLayer.BusinessLogic
{
    public class ShoppingCartService : IShoppingCartService
    {
        private readonly DataContext _context = new DataContext();
        public IEnumerable<ShoppingCart> GetShoppingCartContent()
        {
            return _context.GetAllShoppingCartContent();
        }

        public ShoppingCart GetShoppingCartContentById(int Id)
        {
            return _context.FindShoppingCartContentById(Id);
        }

        public ShoppingCart AddShoppingCart(Product product)
        {
            return _context.AddShoppingCartContent(product);
        }
    }
}
