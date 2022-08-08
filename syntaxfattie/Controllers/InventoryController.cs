using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace syntaxfattie.Controllers
{
    public class InventoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult OrderManagement()
        {
            return View();
        }

        public IActionResult MainInventory()
        {
            return View();
        }
    }
}
