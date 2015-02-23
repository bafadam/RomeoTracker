using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using RomeoTracker.Models.Entities;

namespace RomeoTracker.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<IdentityUserLogin>().HasKey<string>(l => l.UserId);
            //modelBuilder.Entity<IdentityRole>().HasKey<string>(r => r.Id);
            //modelBuilder.Entity<IdentityUserRole>().HasKey(r => new { r.RoleId, r.UserId });
        
        }

        #region EntityModel

        public DbSet<Pet> Pets { get; set; }
        public DbSet<PetImage> PetImages { get; set; }


        #endregion
    }

    /// <summary>
    /// System entity implementation of the database controllers.
    /// </summary>
    public class BAFContext : DbContext
    {
        public BAFContext() : base("DefaultConnection")
        {
            
        }


        #region Configuration

        
        #endregion

        #region EntityModel

        public DbSet<Pet> Pets { get; set; }
        public DbSet<PetImage> PetImages { get; set; }


        #endregion



        #region StaticMethods


        public static BAFContext Create()
        {
            //TODO: Update this in production?
            return new BAFContext();
        }

        #endregion
    }
}