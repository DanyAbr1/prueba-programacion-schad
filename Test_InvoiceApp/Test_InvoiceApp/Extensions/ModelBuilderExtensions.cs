
namespace Test_InvoiceApp.Extensions;

public static class ModelBuilderExtensions
{
    public static ModelBuilder BuildCustomerTable(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>(etb =>
        {
            etb.ToTable("Customers", "dbo");

            etb.HasKey(e => e.Id);

            etb.HasIndex(e => e.Id);

            etb.Property(e => e.Id);
            
            etb.Property(e => e.CustName)
                .HasColumnType("varchar(50)")
                .IsRequired();

            etb.Property(e => e.Adress)
                .HasColumnType("varchar(200)")
                .IsRequired();

            etb.Property(e => e.Status)
                .HasColumnType("bit")
                .IsRequired();

            etb.HasOne<CustomerType>(s => s.CustomerType)
                .WithMany(g => g.Customers)
                .HasForeignKey(s => s.CustomerTypeId);
        });


        modelBuilder.Entity<CustomerType>(etb =>
        {
            etb.ToTable("CustomerTypes", "dbo");

            etb.HasKey(e => e.Id);

            etb.HasIndex(e => e.Id);

            etb.Property(e => e.Id);

            etb.Property(e => e.Description)
                .HasColumnType("varchar(70)")
                .IsRequired();
        });
        return modelBuilder;
    }
}

