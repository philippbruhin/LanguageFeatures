using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LanguageFeatures.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public ViewResult Index()
        {
            ShoppingCart cart = new ShoppingCart {Products = Product.GetProducts()};
            decimal cartTotal = cart.TotalPrices();
            return View("Index", new string[] {$"Total: {cartTotal:C2}"});
        }
    }
}
