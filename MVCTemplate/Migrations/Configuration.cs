using System.Collections.Generic;
using MVCTemplate.Models;

namespace MVCTemplate.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVCTemplate.DAL.ResourceContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MVCTemplate.DAL.ResourceContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            //TODO DELETE OR REPLACE Template Initializer
            var templates = new List<Template>
            {
                new Template { Temp="String1"},
                new Template { Temp="String2"},
                new Template { Temp="String3"}

            };

            templates.ForEach(s => s.CreatedBy = "System");
            templates.ForEach(s => s.CreatedOn = DateTime.Now);
            templates.ForEach(s => s.UpdatedBy = "System");
            templates.ForEach(s => s.UpdatedOn = DateTime.Now);

            templates.ForEach(s => context.Templates.AddOrUpdate(p => p.Temp, s));
            context.SaveChanges();
        }
    }
}
