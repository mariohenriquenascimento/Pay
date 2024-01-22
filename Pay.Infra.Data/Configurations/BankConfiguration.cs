using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pay.Domain.Moldes;

namespace Pay.Infra.Data.Configurations
{
    public class BankConfiguration : IEntityTypeConfiguration<Bank>
    {
        public void Configure(EntityTypeBuilder<Bank> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.BankName).HasColumnName("BankName").IsRequired();
            builder.Property(b => b.BankCode).HasColumnName("BankCode").IsRequired();
            builder.Property(b => b.InterestPercentage).HasColumnName("InterestPercentage").IsRequired();
            builder.HasMany(b => b.PaymentSlips)
                   .WithOne(bo => bo.Bank)
                   .HasForeignKey(bo => bo.BankId)
                   .OnDelete(DeleteBehavior.Restrict);  
        }
    }
}
