    using itehaProject.Data;
using itehaProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace itehaProject.Controllers
{
    public class HomeController : Controller
    {
        private  ILogger<HomeController> _logger;
        private readonly itehaProjectContext _context;
        public HomeController(ILogger<HomeController> logger, itehaProjectContext context)
        {
            _logger = logger;
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public async Task<IActionResult> ProductList(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var products = await _context.Products
                .FirstOrDefaultAsync(m => m.ProductID == id);
            if (products == null)
            {
                return NotFound();
            }

            return View(products);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
