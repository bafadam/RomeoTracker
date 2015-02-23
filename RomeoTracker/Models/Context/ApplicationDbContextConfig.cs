using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace RomeoTracker.Models
{
    public class ApplicationDbContextConfig : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public ApplicationDbContextConfig()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            base.Seed(context);
        }
    }
}