﻿// <auto-generated />
using DataAccess.Concreate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(CirqularDbContext))]
    [Migration("20230203190752_defination")]
    partial class defination
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Entities.Concreate.Definition", b =>
                {
                    b.Property<int>("DefinitionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DefinitionID"), 1L, 1);

                    b.Property<string>("DefinitionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MetarialID")
                        .HasColumnType("int");

                    b.HasKey("DefinitionID");

                    b.HasIndex("MetarialID");

                    b.ToTable("Definition");
                });

            modelBuilder.Entity("Entities.Concreate.Metarial", b =>
                {
                    b.Property<int>("MetarialID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MetarialID"), 1L, 1);

                    b.Property<string>("MetarialName")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.Property<int>("TaxonomyID")
                        .HasColumnType("int");

                    b.HasKey("MetarialID");

                    b.HasIndex("TaxonomyID");

                    b.ToTable("Metarials");

                    b.HasData(
                        new
                        {
                            MetarialID = 31,
                            MetarialName = "Aerogel ",
                            TaxonomyID = 3
                        },
                        new
                        {
                            MetarialID = 32,
                            MetarialName = "Composite Fibers ",
                            TaxonomyID = 3
                        },
                        new
                        {
                            MetarialID = 33,
                            MetarialName = "Additive/Filler for Polymer  ",
                            TaxonomyID = 3
                        },
                        new
                        {
                            MetarialID = 34,
                            MetarialName = "Catalyst/Initiator",
                            TaxonomyID = 3
                        },
                        new
                        {
                            MetarialID = 35,
                            MetarialName = "Composite Core Material ",
                            TaxonomyID = 3
                        },
                        new
                        {
                            MetarialID = 37,
                            MetarialName = "Semiconductor ",
                            TaxonomyID = 3
                        },
                        new
                        {
                            MetarialID = 38,
                            MetarialName = "Metal Foam, Mesh, or Honeycomb  ",
                            TaxonomyID = 3
                        },
                        new
                        {
                            MetarialID = 39,
                            MetarialName = "Metal Matrix Composite ",
                            TaxonomyID = 3
                        });
                });

            modelBuilder.Entity("Entities.Concreate.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductID"), 1L, 1);

                    b.Property<string>("ProductDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("SubCategoryID")
                        .HasColumnType("int");

                    b.HasKey("ProductID");

                    b.HasIndex("SubCategoryID");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("Entitites.Concrete.Taxonomy", b =>
                {
                    b.Property<int>("TaxonomyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TaxonomyID"), 1L, 1);

                    b.Property<string>("TaxonomyName")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.HasKey("TaxonomyID");

                    b.ToTable("Taxonomies");

                    b.HasData(
                        new
                        {
                            TaxonomyID = 1,
                            TaxonomyName = "Carbon"
                        },
                        new
                        {
                            TaxonomyID = 2,
                            TaxonomyName = "Ceramic Replacement"
                        },
                        new
                        {
                            TaxonomyID = 3,
                            TaxonomyName = "Engineering Material"
                        },
                        new
                        {
                            TaxonomyID = 4,
                            TaxonomyName = "Fluid"
                        },
                        new
                        {
                            TaxonomyID = 5,
                            TaxonomyName = "Polymer"
                        });
                });

            modelBuilder.Entity("Entities.Concreate.Definition", b =>
                {
                    b.HasOne("Entities.Concreate.Metarial", "Metarial")
                        .WithMany("Definitions")
                        .HasForeignKey("MetarialID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Metarial");
                });

            modelBuilder.Entity("Entities.Concreate.Metarial", b =>
                {
                    b.HasOne("Entitites.Concrete.Taxonomy", "Taxonomy")
                        .WithMany("Metarial")
                        .HasForeignKey("TaxonomyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Taxonomy");
                });

            modelBuilder.Entity("Entities.Concreate.Product", b =>
                {
                    b.HasOne("Entities.Concreate.Metarial", "SubCategory")
                        .WithMany("Products")
                        .HasForeignKey("SubCategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SubCategory");
                });

            modelBuilder.Entity("Entities.Concreate.Metarial", b =>
                {
                    b.Navigation("Definitions");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("Entitites.Concrete.Taxonomy", b =>
                {
                    b.Navigation("Metarial");
                });
#pragma warning restore 612, 618
        }
    }
}
