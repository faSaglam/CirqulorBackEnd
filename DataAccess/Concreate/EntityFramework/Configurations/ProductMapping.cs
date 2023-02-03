using Entities.Concreate;
using Entitites.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concreate.EntityFramework.Configurations
{
    public class ProductMapping : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.ProductID);
            builder.Property(p => p.ProductName).IsRequired().HasMaxLength(100);
            builder.HasOne(s=>s.SubCategory).WithMany(p=>p.Products).HasForeignKey(p=>p.SubCategoryID).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
