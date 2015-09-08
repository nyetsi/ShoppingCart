using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcApplication1.Models;
using ServiceLayer.Interfaces;
using System.Web.Mvc;
using Shopping.Data.DataModels;


namespace MvcApplication1.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IShoppingCartService _shoppingCartService;
        private readonly IMapper _mapper;

        public ShoppingCartController(IShoppingCartService shoppingCartService, IMapper mapper)
        {
            _shoppingCartService = shoppingCartService;
            _mapper = mapper;
        }

        public ActionResult Index()
        {
            var cart = _shoppingCartService.GetShoppingCartContent();
            return View(cart);
        }

        [HttpPost]
        public Action Create(ProductViewModel productViewModel)
        {
            var product = _mapper.Map(productViewModel);
            ShoppingCart cart = _shoppingCartService.AddShoppingCart(product);

            return null;
        }

    }
}

public class Mapper : IMapper
{
    public Product Map(ProductViewModel model)
    {
        return new Product
        {
            Name = model.Name,
        };
    }
}