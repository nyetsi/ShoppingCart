using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServiceLayer.BusinessLogic;
using ServiceLayer.Interfaces;
using Shopping.Data.DataModels;

namespace Shopping.Test
{
    [TestClass]
    public class ShoppingCartTests
    {
        [TestMethod]
        public void TestGetAllShoppingCartContent()
        {
            IShoppingCartService _shoppingCartService = new ShoppingCartService();

            var result = _shoppingCartService.GetShoppingCartContent();

            Assert.AreEqual(result.Count(), 2);
        }
    }
}
