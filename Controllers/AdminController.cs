using itehaProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;

namespace itehaProject.Controllers
{
    public class AdminController : Controller
    {
        
        dbConn _context;
        public AdminController(dbConn context)
        {
            _context = context;
        }
        // GET: AdminController
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Add() { return View(); }
        public ActionResult Delete() { return View(); }
        public ActionResult Edit() { return View(); }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductID,ProductName,Manufacturerr,price")] Products products)
        {
            if (ModelState.IsValid)
            {
                _context.Add(products);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(products);
        }
        

        // GET: Products1/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var products = await _context.prods.FindAsync(id);
            if (products == null)
            {
                return NotFound();
            }
            return View(products);
        }

        
        [HttpPost, ActionName("Edit Product")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("ProductID,ProductName,Manufacturerr,price")] Products products)
        {
            if (id != products.ProductID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(products);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductsExists(products.ProductID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(products);
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var products = await _context.prods
                .FirstOrDefaultAsync(m => m.ProductID == id);
            if (products == null)
            {
                return NotFound();
            }

            return View(products);
        }

        // POST: Products1/Delete/5
        [HttpPost, ActionName("Remove Product")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var products = await _context.prods.FindAsync(id);
            if (products != null)
            {
                _context.prods.Remove(products);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        private bool ProductsExists(string id)
        {
            return _context.prods.Any(e => e.ProductID == id);
        }
    }
}
