using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Context.EntityFramework
{
    public class SimpleContextDb : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //MSİ - EV
            optionsBuilder.UseSqlServer("Server=DESKTOP-4V1JSR7\\SQLEXPRESS;Database=EnvanterProjesiDb;Integrated Security=true;");
            //MONSTER //base yapı 
            //optionsBuilder.UseSqlServer("Server=DESKTOP-BVJGQT1\\SQLEXPRESS;Database=EnvanterProjesiDb;Integrated Security=true;");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<EmailParameter> EmailParameters { get; set; }
    }
}
