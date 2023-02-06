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
    public class FormMapping : IEntityTypeConfiguration<Form>
    {
        public void Configure(EntityTypeBuilder<Form> builder)
        {
            builder.HasKey(f => f.FormID);
            builder.HasOne(f=>f.Origin).WithMany(O=>O.Forms).HasForeignKey(fk=>fk.OriginID).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
