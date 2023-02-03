
using Entitites.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concreate.Configurations
{
    public class TaxonomyMapping : IEntityTypeConfiguration<Taxonomy>
    {
        public void Configure(EntityTypeBuilder<Taxonomy> builder)
        {
            builder.HasKey(c => c.TaxonomyID);
            builder.Property(c => c.TaxonomyName).IsRequired().HasMaxLength(35);
            
        }
    }
}
