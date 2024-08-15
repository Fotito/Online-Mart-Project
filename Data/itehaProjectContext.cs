using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using itehaProject.Models;

namespace itehaProject.Data
{
    public class itehaProjectContext : DbContext
    {
        public itehaProjectContext (DbContextOptions<itehaProjectContext> options)
            : base(options)
        {
        }

        public DbSet<itehaProject.Models.Products> Products { get; set; } = default!;
    }
}
