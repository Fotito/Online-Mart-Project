using System.ComponentModel.DataAnnotations;

namespace itehaProject.Models
{
    public class Products
    {
        [Key]
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public string Manufacturerr { get; set; }
        public double price { get; set; }

        

        public Products() { }
        
    }
}
