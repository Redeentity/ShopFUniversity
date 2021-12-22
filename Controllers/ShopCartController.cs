using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data.Interfaces;
using WebApplication2.Data.Models;
using WebApplication2.ViewModels;

namespace WebApplication2.Controllers
{
    public class ShopCartController : Controller
    {
        private readonly IAllItems _itemRep;
        private readonly ShopCart _shopCart;
        public ShopCartController(IAllItems itemRep, ShopCart shopCart)
        {
            _itemRep = itemRep;
            _shopCart = shopCart;
        }
        public ViewResult Index()
        {
            var temp = _shopCart.getShopItems();
            _shopCart.listShopItems = temp;
            var obj = new ShopCartViewModel
            {
                shopCart = _shopCart
            };
            return View(obj);
        }

        public RedirectToActionResult addToCart(int id)
        {
            var t = _itemRep.Items.FirstOrDefault(i => i.id == id);
            if(t != null)
            {
                _shopCart.AddToCart(t);
            }
            return RedirectToAction("Index");
        }
    }
}
