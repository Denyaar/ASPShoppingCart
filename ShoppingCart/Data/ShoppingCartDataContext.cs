using Microsoft.EntityFrameworkCore;
using ShoppingCart.Models;

namespace ShoppingCart.Data;

public class ShoppingCartDataContext:DbContext
{
    public ShoppingCartDataContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Products>? Products { get; set; }
    public DbSet<Category>? Categories { get; set; }
}