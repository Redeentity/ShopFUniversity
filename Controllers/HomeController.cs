using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data.Interfaces;
using WebApplication2.ViewModels;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAllItems _itemRep;
        public HomeController(IAllItems itemRep)
        {
            _itemRep = itemRep;
        }
        public ViewResult Index()
        {
            var homeItems = new HomeViewModel
            {
                favItems = _itemRep.getFavItems
            };
            return View(homeItems);
        }
    }
}