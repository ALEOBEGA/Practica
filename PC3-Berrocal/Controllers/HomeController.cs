using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PC3_Berrocal.Data;
using PC3_Berrocal.Models;


namespace PC3_Berrocal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly WebAppContext _context;
        public HomeController(ILogger<HomeController> logger, WebAppContext context)
        {
            _logger = logger;
            _context=context;
        }

        public IActionResult Index()
        {
            var productos=_context.productos.ToList();
            return View(productos);
        }
        
        public IActionResult Formulario()
        {
            return View();
        }
        [HttpPost]
         public IActionResult Formulario(Producto P)
        {   
            if(ModelState.IsValid){
                _context.Add(P);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(P);
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
