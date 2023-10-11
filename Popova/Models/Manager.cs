using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Popova.Models
{
    public class Manager
    {
        [Key]
        public int Manager_Id { get; set; }
        public string Manager_FIO { get; set; }
        public string Manager_Phone { get; set; }
    }
    public class ManagerDbContext : DbContext
    {
        public static string sqlstr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\USER\\Documents\\DataBase3.mdf;Integrated Security=True;Connect Timeout=30";
        public DbSet<Manager> Managers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(sqlstr);
        }
    }
    public class ManagerWork
    {
        public static void AddManager(string ManagerFIO, string ManagerPhone)
        {
            using (var dbContext = new ManagerDbContext())
            {
                var manager = new Manager()
                {
                    Manager_FIO = ManagerFIO,
                    Manager_Phone = ManagerPhone
                };
                dbContext.Managers.Add(manager);
                dbContext.SaveChanges();
            }
        }
        public static void EditManager(int ManagerId, string ManagerFIO, string ManagerPhone)
        {
            using(var dbContext = new ManagerDbContext())
            {
                var manager = dbContext.Managers.Find(ManagerId);
                if (manager != null)
                {
                    manager.Manager_FIO = ManagerFIO;
                    manager.Manager_Phone = ManagerPhone;
                }
                dbContext.SaveChanges();
            }
        }
        public static void DeleteManager(int ManagerId)
        {
            using( var dbContext = new ManagerDbContext())
            {
                var manager = dbContext.Managers.FirstOrDefault(e => e.Manager_Id == ManagerId);
                dbContext.Remove(manager);
                dbContext.SaveChanges();
            }
        }
    }
}
