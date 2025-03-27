using Microsoft.EntityFrameworkCore;
using SMS.Domain;

namespace SMS.Infrastructure.Data 
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=db_students;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            base.OnConfiguring(optionsBuilder);


        }

        public DbSet <Student> Students { get; set; }
        public DbSet <Programs> Programs { get; set; }
    }
}
