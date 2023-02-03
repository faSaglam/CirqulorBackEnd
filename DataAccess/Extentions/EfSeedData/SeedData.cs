using Entities.Concreate;
using Entitites.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace DataAccess.Extentions.EfSeedData
{
    //public static class SeedData
    //{
    //    //public static void Seed(this ModelBuilder modelBuilder)
    //    //{
    //    //    modelBuilder.Entity<UserRole>().HasData(
    //    //        new UserRole()
    //    //        {
    //    //            Id = "fab4fac1-c546-41de-aebc-a14da6895711",
    //    //            Name = "Admin",
    //    //            ConcurrencyStamp = "1",
    //    //            NormalizedName = "Admin"
    //    //        },
    //    //         new UserRole()
    //    //         {
    //    //             Id = "c7b013f0-5201-4317-abd8-c211f91b7330",
    //    //             Name = "User",
    //    //             ConcurrencyStamp = "2",
    //    //             NormalizedName = "User"
    //    //         }
    //    //        );

    //    //    modelBuilder.Entity<IdentityUserRole<string>>().HasData(

    //    //        new IdentityUserRole<string>()
    //    //        {
    //    //            RoleId = "fab4fac1-c546-41de-aebc-a14da6895711",
    //    //            UserId = "b74ddd14-6340-4840-95c2-db12554843e5"
    //    //        }

    //    //        );

    //    //    User user = new User()
    //    //    {
    //    //        Id = "b74ddd14-6340-4840-95c2-db12554843e5",
    //    //        UserName = "Admin",
    //    //        NormalizedUserName="ADMIN",
    //    //        FirstName="Admin",
    //    //        LastName="Admin",
    //    //        Email = "omfasaglam@gmail.com",
    //    //        NormalizedEmail="OMFASAGLAM@GMAIL.COM"


    //    //    };
    //    //    PasswordHasher<User> passwordHasher = new PasswordHasher<User>();
    //    //    user.PasswordHash = passwordHasher.HashPassword(user, "Admin*123");


    //    //    modelBuilder.Entity<User>().HasData(user);


    //    //}




    //}
    public static class SeedData
    {

   
        public static void SeedTaxonomy(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Taxonomy>().HasData(
                new Taxonomy()
                {
                TaxonomyID = 1,
                TaxonomyName= "Carbon",
                },
                new Taxonomy()
                {
                    TaxonomyID = 2,
                    TaxonomyName = "Ceramic Replacement",
                },
                    new Taxonomy()
                    {
                        TaxonomyID = 3,
                        TaxonomyName = "Engineering Material",
                    },
                        new Taxonomy()
                        {
                            TaxonomyID = 4,
                            TaxonomyName = "Fluid",
                        },
                             new Taxonomy()
                             {
                                 TaxonomyID = 5,
                                 TaxonomyName = "Polymer",
                             }
               );
           
        }
        public static void SeedMetarial(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Metarial>().HasData(
               new Metarial()
               {
                   MetarialID = 31,
                   MetarialName = "Aerogel ",
                   TaxonomyID = 3,
               },
                     new Metarial()
                     {
                         MetarialID = 32,
                         MetarialName = "Composite Fibers ",
                         TaxonomyID = 3,
                     },
                           new Metarial()
                           {
                               MetarialID = 33,
                               MetarialName = "Additive/Filler for Polymer  ",
                               TaxonomyID = 3,
                           },
                              new Metarial()
                              {
                                  MetarialID = 34,
                                  MetarialName = "Catalyst/Initiator",
                                  TaxonomyID = 3,
                              },
                                 new Metarial()
                                 {
                                     MetarialID = 35,
                                     MetarialName = "Composite Core Material ",
                                     TaxonomyID = 3,
                                 },
                                  new Metarial()
                                  {
                                      MetarialID = 37,
                                      MetarialName = "Semiconductor ",
                                      TaxonomyID = 3,
                                  },
                                     new Metarial()
                                     {
                                         MetarialID = 38,
                                         MetarialName = "Metal Foam, Mesh, or Honeycomb  ",
                                         TaxonomyID = 3,
                                     },
                                        new Metarial()
                                        {
                                            MetarialID = 39,
                                            MetarialName = "Metal Matrix Composite ",
                                            TaxonomyID = 3,
                                        }

               );

        }
        public static void SeedDefinition(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Definition>()
                .HasData
                (
                new Definition()
                {
                    DefinitionID= 331,
                    DefinitionName="Organic",
                    MetarialID= 33,
                },
                  new Definition()
                  {
                      DefinitionID = 332,
                      DefinitionName = "Inorganic",
                      MetarialID = 33,
                  }




                );
        }
        public static void SeedOrigin(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Origin>()
                .HasData
                (
                new Origin()
                {
                    OriginID=3311,
                    OriginName= "Lignocelulosic",
                    DefinationID= 331,

                },
                  new Origin()
                  {
                      OriginID = 3312,
                      OriginName = "Agri-waste",
                      DefinationID = 331,
                  },
                    new Origin()
                    {
                        OriginID = 3313,
                        OriginName = "Other",
                        DefinationID = 331,
                    }




                );
        }




    }


}
