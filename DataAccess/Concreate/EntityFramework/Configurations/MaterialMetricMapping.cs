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
    public class MaterialMetricMapping : IEntityTypeConfiguration<MaterialMetric>
    {
        public void Configure(EntityTypeBuilder<MaterialMetric> builder)
        {
            builder.HasKey(mm => mm.MaterialMetricID);
            //builder.HasOne(p => p.Plant).WithOne(m => m.MaterialMetric).HasForeignKey<Plant>(fk => fk.PlantID);
            builder.HasOne(mp => mp.MechanicalProperty).WithOne(mm => mm.MaterialMetric).HasForeignKey<MechanicalProperty>(fk => fk.MechanicalPropertyID);
            builder.HasOne(pp => pp.PhysicalProperty).WithOne(mm => mm.MaterialMetric).HasForeignKey<PhysicalProperty>(fk => fk.PhysicalPropertyID);
            builder.HasOne(ep => ep.ElectricalProperty).WithOne(mm => mm.MaterialMetric).HasForeignKey<ElectricalProperty>(fk => fk.ElectricalPropertyID);
            builder.HasOne(tp => tp.ThermalProperty).WithOne(mm => mm.MaterialMetric).HasForeignKey<ThermalProperty>(fk => fk.ThermalPropertyID);
            builder.HasOne(op => op.OpticalProperty).WithOne(mm => mm.MaterialMetric).HasForeignKey<OpticalProperty>(fk => fk.OpticalPropertyID);
        }
    }
}
