using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_6_Joisah_Sarles.Models
{
    public class FamazonDbContext : DbContext
    {
        public FamazonDbContext (DbContextOptions<FamazonDbContext> options) : base (options)
        {
            
        }
        public DbSet<Book> books { get; set; }
    }
}
