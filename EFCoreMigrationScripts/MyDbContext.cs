using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace EFCoreMigrationScripts
{
    public class MyDbContext : DbContext
    {
        public DbSet<UsersEntity> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=EFCoreMigrationsDemo;Trusted_Connection=True");

            optionsBuilder.ReplaceService<IRelationalCommandBuilderFactory,
                DynamicSqlRelationalCommandBuilderFactory>();

            base.OnConfiguring(optionsBuilder);
        }
    }
}
