using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shopping.Data.DataModels;

namespace ServiceLayer.Interfaces
{
    public interface IShoppingCartService
    {
        IEnumerable<ShoppingCart> GetShoppingCartContent();
        ShoppingCart GetShoppingCartContentById(int Id);
        ShoppingCart AddShoppingCart(Product product);
    }
}
