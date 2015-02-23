using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace RomeoTracker.Models
{
    public class BAFContextConfig : DbMigrationsConfiguration<BAFContext>
    {
        public BAFContextConfig()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;

        }

        protected override void Seed(BAFContext context)
        {
            base.Seed(context);


        }
    }
}