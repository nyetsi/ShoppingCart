using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Data.DataModels
{
    public class Product
    {
        public int ProductId { get; set; }
        public int ShoppingCartId { get; set; }
        public string Name { get; set; }
    }
}
