using Microsoft.EntityFrameworkCore;
using ShoppingCart.Models;

namespace ShoppingCart.Data;

public class SeedData
{
    public static void SeedDatabase(ShoppingCartDataContext context)
    {
        context.Database.Migrate();
        if (context.Products.Count() == 0 && context.Categories.Count() == 0)
        {
            Category fruits = new Category { Name = "Fruits", Slug = "fruits"};
            Category shirts = new Category { Name = "Shirts", Slug = "fruits"};
            
            context.Products.AddRange(
                new Products
                {
                    Name = "Apples",
                    Slug = "apples",
                    Description = "Sweet Apples",
                    Price = 1.50M,
                    Category = fruits,
                    Image = "apples.jpg"
                },
                new Products
                {
                    Name = "Bananas",
                    Slug = "bananas",
                    Description = "fresh bananas",
                    Price = 2M,
                    Category = fruits,
                    Image = "bananas.jpg"
                },
                new Products
                {
                    Name = "Watermelon",
                    Slug = "watermelon",
                    Description = "fresh watermelon",
                    Price = 0.5M,
                    Category = fruits,
                    Image = "watermelon.jpg"
                },
                new Products
                {
                    Name = "Grapefruit",
                    Slug = "grapefruit",
                    Description = "red grapefruit",
                    Price = 5.59M,
                    Category = fruits,
                    Image = "grapefruit.jpg"
                },
                new Products
                {
                    Name = "White shirt",
                    Slug = "white-shirt",
                    Description = "White Shirt",
                    Price = 5.59M,
                    Category = shirts,
                    Image = "white-shirt.jpg"
                },
                new Products
                {
                    Name = "Black shirt",
                    Slug = "black-shirt",
                    Description = "Black Shirt",
                    Price = 7.59M,
                    Category = shirts,
                    Image = "black-shirt.jpg"
                },
                new Products
                {
                    Name = "Yellow shirt",
                    Slug = "yellow-shirt",
                    Description = "Yellow Shirt",
                    Price = 11.59M,
                    Category = shirts,
                    Image = "yellow-shirt.jpg"
                },
                new Products
                {
                    Name = "Grey shirt",
                    Slug = "grey-shirt",
                    Description = "grey Shirt",
                    Price = 12.59M,
                    Category = shirts,
                    Image = "grey-shirt.jpg"
                }

            );
            context.SaveChanges();

        }
    }
    
}