using Boxetheus.Data;
using Microsoft.EntityFrameworkCore;

namespace Boxetheus.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BoxetheusContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<BoxetheusContext>>()))
            {
                // Look for any product.
                if (context.BoxView.Any())
                {
                    return;   // DB has been seeded
                }
                context.BoxView.AddRange(
                    new BoxView
                    {
                        Brand = "Boxify",
                        OrderDate = DateTime.Parse("2024-2-01"),
                        Category = "Cosmetic Box",
                        Design = "Floral Design",
                        Shape = "Oval",
                        Size = "Medium",
                        Quantity = 10,
                        Price = 277.50M
                        //Color = "Pink",
                    },
                    new BoxView
                    {
                        Brand = "CargoCove",
                        OrderDate = DateTime.Parse("2024-2-12"),
                        Category = "Toy Box",
                        Design = "Cartoon Characters",
                        Shape = "Custom Shape",
                        Size = "Large",
                        Quantity = 15,
                        Price = 80.49M
                        //Color = "Gray",
                    },
                    new BoxView
                    {
                        Brand = "FlexiBox",
                        OrderDate = DateTime.Parse("2024-2-14"),
                        Category = "Shipping Box",
                        Design = "Stripes",
                        Shape = "Standard",
                        Size = "Extra Large",
                        Quantity = 100,
                        Price = 259.59M
                        //Color = "Beige"
                    },
                    new BoxView
                    {
                        Brand = "PackMaster",
                        OrderDate = DateTime.Parse("2024-2-15"),
                        Category = "Electronic Product Box",
                        Design = "Geometric Patterns",
                        Shape = "Square",
                        Size = "Extra Large",
                        Quantity = 12,
                        Price = 183.29M
                        //Color = "Brown"
                    },
                    new BoxView
                    {
                        Brand = "CrateCraze",
                        OrderDate = DateTime.Parse("2024-2-15"),
                        Category = "Food Packaging Box",
                        Design = "Stripes",
                        Shape = "Rectangular",
                        Size = "Large",
                        Quantity = 50,
                        Price = 53.97M
                        //Color = "Blue"
                    },
                    new BoxView
                    {
                        Brand = "BoxLuxe",
                        OrderDate = DateTime.Parse("2024-2-15"),
                        Category = "Jewelry Box",
                        Design = "Minimalist Design",
                        Shape = "Square",
                        Size = "Medium",
                        Quantity = 8,
                        Price = 250.39M
                        //Color = "Red Violet"
                    },
                    new BoxView
                    {
                        Brand = "SturdyBox",
                        OrderDate = DateTime.Parse("2024-2-18"),
                        Category = "Gift Box",
                        Design = "Minimalist Design",
                        Shape = "Oval",
                        Size = "Small",
                        Quantity = 2,
                        Price = 105.50M
                        //Color = "Black"
                    },
                    new BoxView
                    {
                        Brand = "SecurePack",
                        OrderDate = DateTime.Parse("2024-2-20"),
                        Category = "Moving Box",
                        Design = "Stripes",
                        Shape = "Square",
                        Size = "Extra Large",
                        Quantity = 6,
                       Price = 103.15M
                        //Color = "Beige"
                    },
                    new BoxView
                    {
                        Brand = "PrimePack",
                        OrderDate = DateTime.Parse("2024-2-22"),
                        Category = "Storage Box",
                        Design = "Polka Dots",
                        Shape = "Square",
                        Size = "Extra Large",
                        Quantity = 4,
                        Price = 83.09M
                        //Color = "Brown"
                    },
                     new BoxView
                     {
                         Brand = "CargoCove2",
                         OrderDate = DateTime.Parse("2024-3-02"),
                         Category = "Toy Box",
                         Design = "Cartoon Characters",
                         Shape = "Custom Shape",
                         Size = "Large",
                         Quantity = 15,
                         Price = 80.49M
                         //Color = "Gray"
                     }
                );
                context.SaveChanges();
            }
        }
    }
}
