using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using TestIdentity2.Models;

namespace TestIdentity2.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
          
    }

    public DbSet<Article> articles { get; set; }
    public DbSet<Food> foods { get; set; }

    /*protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        var admin = new IdentityRole("admin");
        admin.NormalizedName = "admin";

        var client = new IdentityRole("client");
        client.NormalizedName = "client";

        var seller = new IdentityRole("seller");
        seller.NormalizedName = "seller";

        builder.Entity<IdentityRole>().HasData(admin,client,seller);
    }*/
}
