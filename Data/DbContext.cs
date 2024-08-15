﻿//using Microsoft.EntityFrameworkCore;
using itehaProject.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

public class dbContext : DbContext {
    public dbContext():base("dbConnections") {
    }

    public DbSet<Products> prods { get; set; }
    public DbSet<Order> orders { get; set; }
    public DbSet<orderItems> orderItems { get; set; }

    public DbSet<Users> users { get; set; }
    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Products>().ToTable("Products");
        modelBuilder.Entity<Order>().ToTable("Order");
        modelBuilder.Entity<orderItems>().ToTable("orderItems");
        modelBuilder.Entity<Users>().ToTable("Users");
        modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        base.OnModelCreating(modelBuilder);
    }

}