using Microsoft.EntityFrameworkCore;

namespace NursaceMVC.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<OrderString> OrderStrings { get; set; }
        public DbSet<OrderList> OrderLists { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();   // создаем базу данных при первом обращении
        }

    }
}
