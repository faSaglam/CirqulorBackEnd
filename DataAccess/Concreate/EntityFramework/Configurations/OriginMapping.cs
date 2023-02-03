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
    public class OriginMapping : IEntityTypeConfiguration<Origin>
    {
        public void Configure(EntityTypeBuilder<Origin> builder)
        {
            builder.HasKey(o => o.OriginID);
            builder.HasOne(o => o.Definition).WithMany(o => o.Origins).HasForeignKey(o => o.DefinationID).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
