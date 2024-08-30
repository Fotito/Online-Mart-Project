using itehaProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;


namespace itehaProject.Controllers
{
    public class OrderController : Controller
    { 
    private List<Products> order=new List<Products>();

dbConn con;
public OrderController(dbConn db)
{
    this.con = db;
}
         public IActionResult Index(Products product)
 {
     order.Add(product);
     double orderTotal=0;
     foreach (var item in order)
     {
         ViewData["item"] = item;
         orderTotal = orderTotal + item.price;
     }
     ViewData["count"] = orderTotal;
     return View();
 }
    }
}
