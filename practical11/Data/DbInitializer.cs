using practical11.Models;
using System.Linq;

namespace practical11.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any categories.
            if (context.Categories.Any())
            {
                return;   // DB has been seeded
            }

            var categories = new Category[]
            {
                new Category{Name="Electronics"},
                new Category{Name="Clothing"},
                new Category{Name="Groceries"}
            };
            foreach (Category c in categories)
            {
                context.Categories.Add(c);
            }
            context.SaveChanges();

            var suppliers = new Supplier[]
            {
                new Supplier{Name="Supplier1", ContactInfo="supplier1@example.com"},
                new Supplier{Name="Supplier2", ContactInfo="supplier2@example.com"},
                new Supplier{Name="Supplier3", ContactInfo="supplier3@example.com"}
            };
            foreach (Supplier s in suppliers)
            {
                context.Suppliers.Add(s);
            }
            context.SaveChanges();

            var products = new Product[]
            {
                new Product{Name="Laptop", Price=800M, CategoryId=categories[0].Id, SupplierId=suppliers[0].Id},
                new Product{Name="Shirt", Price=20M, CategoryId=categories[1].Id, SupplierId=suppliers[1].Id},
                new Product{Name="Apple", Price=1M, CategoryId=categories[2].Id, SupplierId=suppliers[2].Id}
            };
            foreach (Product p in products)
            {
                context.Products.Add(p);
            }
            context.SaveChanges();
        }
    }
}
