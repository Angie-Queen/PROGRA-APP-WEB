using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PROGRA_APP_WEB.Models;

namespace PROGRA_APP_WEB.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Producto()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Producto(Producto producto)
        {
            if(ModelState.IsValid)
            {
            return RedirectToAction("ProductoConfirmación");
            }
            return View(producto)
        }
        public IActionResult ProductoConfirmación()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
