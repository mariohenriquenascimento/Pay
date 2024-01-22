using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pay.Domain.Moldes;

namespace Pay.Infra.Data.Configurations
{
    public class PaymentSlipConfiguration : IEntityTypeConfiguration<PaymentSlip>
    {
        public void Configure(EntityTypeBuilder<PaymentSlip> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
            builder.Property(b => b.PayerName).HasColumnName("PayerName").IsRequired();
            builder.Property(b => b.PayerDocument).HasColumnName("PayerDocument").IsRequired();
            builder.Property(b => b.BeneficiaryName).HasColumnName("BeneficiaryName").IsRequired();
            builder.Property(b => b.BeneficiaryDocument).HasColumnName("BeneficiaryDocument").IsRequired();
            builder.Property(b => b.Value).HasColumnName("Value").IsRequired();
            builder.Property(b => b.DueDate).HasColumnName("DueDate").IsRequired();
            builder.Property(b => b.Observation).HasColumnName("Observation");
            builder.Property(b => b.BankId).HasColumnName("BankId").IsRequired();
            builder.HasOne(b => b.Bank)
                   .WithMany(b => b.PaymentSlips)
                   .HasForeignKey(b => b.BankId)
                   .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
