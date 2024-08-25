using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;
using itehaProject.Data;
using itehaProject.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace itehaProject.Controllers
{
    public class ProductController : Controller
    {
        dbConn _context;

        public ProductController(dbConn context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var value = await _context.prods.ToListAsync();

            return View(value);
        }
        
    
    }
}

