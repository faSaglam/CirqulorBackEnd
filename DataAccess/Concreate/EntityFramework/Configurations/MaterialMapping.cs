using Entities.Concreate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concreate.EntityFramework.Configurations
{
    public class MaterialMapping:IEntityTypeConfiguration<Metarial>
    {
        public void Configure(EntityTypeBuilder<Metarial> builder)
        {
            builder.HasKey(s=>s.MetarialID);
            builder.Property(s => s.MetarialName).IsRequired().HasMaxLength(120);
            builder.HasOne(s=>s.Taxonomy).WithMany(c=>c.Metarial).HasForeignKey(fk=>fk.TaxonomyID).OnDelete(DeleteBehavior.Cascade);

        }

    
    }
}
