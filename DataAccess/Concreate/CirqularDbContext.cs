
using DataAccess.Extentions.EfSeedData;
using Entities.Concreate;
using Entitites.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Configuration;
using System.Reflection;

namespace DataAccess.Concreate
{
    public class CirqularDbContext:DbContext
    {
        //public IConfiguration Configuration { get; private set; }
        public CirqularDbContext()
        {

        }
        public CirqularDbContext(DbContextOptions<CirqularDbContext> options) : base(options)
        {

        }
        
       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //string conString = Microsoft.Extensions.Configuration
            //    .ConfigurationExtensions.GetConnectionString(this.Configuration, "DefaultConnection");
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=CirqulorMSSQL;Trusted_Connection=True");
           


        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.SeedTaxonomy();
            modelBuilder.SeedMetarial();
            modelBuilder.SeedDefinition();
            modelBuilder.SeedOrigin();
            modelBuilder.SeedForm();
            modelBuilder.SeedPlant();
            modelBuilder.SeedMaterialMetric();
            base.OnModelCreating(modelBuilder);
      
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
         
        }


        public virtual DbSet<Taxonomy> Taxonomies { get; set; }
        public virtual DbSet<Metarial> Metarials { get; set; }
        public virtual DbSet<Definition> Definitions { get; set; }

        public virtual DbSet<Origin> Origins { get; set; }

        public virtual DbSet<Form> Forms { get; set; }

        public virtual DbSet<Plant> Plants { get; set; }

        public virtual DbSet<MaterialMetric> MaterialMetrics { get; set; }

        public virtual DbSet<OpticalProperty> OpticalProperties { get; set; }

        public virtual DbSet <ThermalProperty> ThermalProperties { get; set;}

        public virtual DbSet<ElectricalProperty> ElectricalProperties { get; set; }

        public virtual DbSet<MechanicalProperty> MechanicalProperties { get; set; }

        public virtual DbSet<PhysicalProperty> PhysicalProperties { get; set; }
        

        
    }
}
