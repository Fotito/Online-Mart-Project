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
List<Products> Products = new List<Products>();
        public ProductController(dbConn context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            foreach (var product in _context.prods) { 
Products.Add(product);
}
return View(Products);
            return View(value);
        }
        
    
    }
}

