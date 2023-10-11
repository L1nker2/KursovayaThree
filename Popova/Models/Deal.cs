using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Popova.Models
{
    public class Deal
    {
        [Key]
        public int Deal_Id { get; set; }
        public int Manager_Id { get; set; }
        public int Client_Id { get; set; }
        public int Product_Id { get; set; }
        public int Product_Count { get; set; }
        public bool Deal_Is_Finished { get; set; }
    }
    public class DealDbContext : DbContext
    {
        public static string sqlstr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\USER\\Documents\\DataBase3.mdf;Integrated Security=True;Connect Timeout=30";
        public DbSet<Deal> Deals { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(sqlstr);
        }
    }
    public class DealWork
    {
        public static void AddDeal(int ManagerId, int ClientId, int ProductId, int ProductCount, bool DealIsFinished)
        {
            using (var dbContext = new DealDbContext())
            {
                var deal = new Deal()
                {
                    Manager_Id = ManagerId,
                    Client_Id = ClientId,
                    Product_Id = ProductId,
                    Product_Count = ProductCount,
                    Deal_Is_Finished = DealIsFinished
                };
                dbContext.Deals.Add(deal);
                dbContext.SaveChanges();
            }
        }
        public static void DeleteDeal(int DealId)
        {
            using (var dbContext = new DealDbContext())
            {
                var deal = dbContext.Deals.FirstOrDefault(e => e.Deal_Id == DealId);
                if(deal != null)
                {
                    dbContext.Remove(deal);
                    dbContext.SaveChanges();
                }
            }
        }
        public static void EditDeal(int DealId, int ManagerId, int ClientId, int ProductId, int ProductCount, bool DealIsFinished)
        {
            using (var dbContext = new DealDbContext())
            {
                var deal = dbContext.Deals.Find(DealId);
                if (deal != null)
                {
                    deal.Manager_Id = ManagerId;
                    deal.Client_Id = ClientId;
                    deal.Product_Id = ProductId;
                    deal.Product_Count = ProductCount;
                    deal.Deal_Is_Finished = DealIsFinished;
                    dbContext.SaveChanges();
                }
            }
        }
    }
}
