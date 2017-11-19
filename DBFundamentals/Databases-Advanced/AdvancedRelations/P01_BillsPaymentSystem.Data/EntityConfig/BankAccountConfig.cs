using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P01_BillsPaymentSystem.Data.Models;

namespace P01_BillsPaymentSystem.Data.EntityConfig
{
    public class BankAccountConfig : IEntityTypeConfiguration<BankAccount>
    {
        public void Configure(EntityTypeBuilder<BankAccount> entity)
        {
            entity.HasKey(e => e.BankAccountId);

            entity.Property(e => e.BankName)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode();

            entity.Property(e => e.SWIFTCode)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Ignore(e => e.PaymentMethodId);
        }
    }
}
