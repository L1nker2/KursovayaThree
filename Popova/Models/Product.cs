using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Popova.Models
{
    public class Product
    {
        [Key]
        public int Product_Id { get; set; }
        public string Product_Name { get; set; }
        public string Product_Price { get; set; }
    }
    public class ProductDbContext : DbContext
    {
        public static string sqlstr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\USER\\Documents\\DataBase3.mdf;Integrated Security=True;Connect Timeout=30";
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(sqlstr);
        }
    }
    public class ProductWork
    {
        public static void AddProduct(string ProductName, string ProductPrice)
        {
            using (var dbContext = new ProductDbContext())
            {
                var product = new Product()
                {
                    Product_Name = ProductName,
                    Product_Price = ProductPrice
                };
                dbContext.Products.Add(product);
                dbContext.SaveChanges();
            }
        }
        public static void DeleteProduct(int ProductId)
        {
            using (var dbContext = new ProductDbContext())
            {
                var product = dbContext.Products.FirstOrDefault(e => e.Product_Id == ProductId);
                dbContext.Remove(product);
                dbContext.SaveChanges();
            }
        }
        public static void EditProduct(int ProductId, string ProductName, string ProductPrice)
        {
            using (var dbContext = new ProductDbContext())
            {
                var product = dbContext.Products.Find(ProductId);
                if (product != null)
                {
                    product.Product_Name = ProductName;
                    product.Product_Price = ProductPrice;
                }
                dbContext.SaveChanges();
            }
        }
    }
}