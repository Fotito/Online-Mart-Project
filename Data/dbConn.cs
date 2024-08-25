using Microsoft.EntityFrameworkCore;
using itehaProject.Models;

public class dbConn : DbContext {
    

    public DbSet<Products> prods { get; set; }
    public DbSet<Order> orders { get; set; }
    public DbSet<orderItems> orderItems { get; set; }

    public DbSet<Users> users { get; set; }
  public dbConn(DbContextOptions<dbConn> options)
        : base(options) { 


}
}
