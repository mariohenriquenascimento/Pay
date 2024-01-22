using Microsoft.EntityFrameworkCore;
using Pay.Domain.Moldes;
using Pay.Infra.Data.Configurations;

namespace Pay.Infra.Data.Contexts
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }

        public DbSet<Bank> Bank { get; set; }
        public DbSet<PaymentSlip> PaymentSlip { get; set; }
        public DbSet<User> User { get; set; }
    }
}
