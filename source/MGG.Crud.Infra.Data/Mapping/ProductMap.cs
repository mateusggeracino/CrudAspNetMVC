using System.Data.Entity.ModelConfiguration;
using MGG.Crud.Domain.Models;

namespace MGG.Crud.Infra.Data.Mapping
{
    public class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            HasKey(x => x.Id);

            Property(x => x.Name)
                .HasMaxLength(120)
                .IsRequired();

            Property(x => x.Description)
                .HasMaxLength(500);

            Ignore(x => x.ValidationResult);
            Ignore(x => x.CascadeMode);

            ToTable("Product");
        }
    }
}