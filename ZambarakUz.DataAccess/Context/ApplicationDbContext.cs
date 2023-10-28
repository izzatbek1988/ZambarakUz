using Microsoft.EntityFrameworkCore;
using ZambarakUz.DataAccess.Entites;
using ZambarakUz.DataAccess.Entities;

namespace ZambarakUz.DataAccess.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);
        //    optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DB_POS;Integrated Security=True;");
        //}

        public DbSet<User> USERS { get; set; } // Users tablosu için DbSet tanımlaması
        public DbSet<UserGroup> USERS_GROUPS { get; set; }
        public DbSet<ClientGroup> CLIENTS_GROUPS { get; set; }
        public DbSet<Client> CLIENTS { get; set; }


        // Diğer DbSet tanımlamalarını ekleyin
    }
}
