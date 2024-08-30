using System.ComponentModel.DataAnnotations;

namespace itehaProject.Models
{
    public class Products
    {
        [Key]
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public string Manufacturer { get; set; }
        public double Price { get; set; }

        

         public Products(string productid, string name, string manufacturer, double price) {
 this.ProductID = productid;
     this.ProductName = name;
     this.price= price;
     this.Manufacturerr= manufacturer;
 }
        
    }
}
