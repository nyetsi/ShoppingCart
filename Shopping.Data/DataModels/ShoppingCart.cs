﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Data.DataModels
{
    public class ShoppingCart
    {   
        public int Id { get; set; }
        public List<Product> Products { get; set; }
    }
}
