using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiCore.Models
{
    public class WebApiCoreDBContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public WebApiCoreDBContext(DbContextOptions<WebApiCoreDBContext> options) : base(options){
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().ToTable("Movie");
        }
    }
}
