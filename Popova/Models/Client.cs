using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
namespace Popova.Models
{
    public class Client
    {
        [Key]
        public int Client_Id { get; set; }
        public string Client_FIO { get; set; }
        public string Client_Address { get; set; }
        public string Client_Contact { get; set; }
    }
    public class ClientDbContext : DbContext
    {
        public static string sqlstr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\USER\\Documents\\DataBase3.mdf;Integrated Security=True;Connect Timeout=30";
        public DbSet<Client> Clients { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(sqlstr);
        }
    }
    public class ClientWork
    {
        public static void AddClient(string ClientFIO, string ClientAddress, string ClientContact)
        {
            using(var dbContext = new  ClientDbContext())
            {
                var client = new Client()
                {
                    Client_FIO = ClientFIO,
                    Client_Address = ClientAddress,
                    Client_Contact = ClientContact
                };
                dbContext.Clients.Add(client);
                dbContext.SaveChanges();
            }
        }
        public static void DeleteClient(int Id)
        {
            using(var dbContext = new ClientDbContext())
            {
                var client = dbContext.Clients.FirstOrDefault(e => e.Client_Id == Id);
                dbContext.Remove(client);
                dbContext.SaveChanges();
            }
        }
        public static void EditClient(int ClientId, string ClientFIO, string ClientAddress, string ClientContact)
        {
            using(var dbContext = new ClientDbContext())
            {
                var client = dbContext.Clients.Find(ClientId);
                if (client != null)
                {
                    client.Client_FIO = ClientFIO;
                    client.Client_Contact = ClientContact;
                    client.Client_Address = ClientAddress;
                }
                dbContext.SaveChanges();
            }
        }
    }
}
