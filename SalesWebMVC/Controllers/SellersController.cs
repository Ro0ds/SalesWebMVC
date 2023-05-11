using Microsoft.AspNetCore.Mvc;
using System;

namespace SalesWebMVC.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
