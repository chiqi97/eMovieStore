using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eMovieStore.Models
{
    public class AppDbContext : DbContext//IdentityDbContext<ApplicationUser> - role uzytkownik itd.
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
    : base(options)
        {

        }

        public DbSet<Book> Books { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    //modelBuilder.Seed();
           
        //    //foreach (var foreignKey in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
        //    //{
        //    //    foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
        //    //}
        //}
    }
}
