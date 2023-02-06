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
    public class PlantMapping : IEntityTypeConfiguration<Plant>
    {
        public void Configure(EntityTypeBuilder<Plant> builder)
        {
            builder.HasKey(p => p.PlantID);
            builder.HasOne(f=>f.Form).WithMany(p=>p.Plants).HasForeignKey(fk=>fk.FormID).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(p=>p.MaterialMetric).WithOne(x=>x.Plant).HasForeignKey<Plant>(x=>x.PlantOfMaterialMetricID).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
