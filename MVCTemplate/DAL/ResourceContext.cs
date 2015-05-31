using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCTemplate.Models;

namespace MVCTemplate.DAL
{
    public class ResourceContext : DbContext
    {
        public ResourceContext() : base("ResourceContext")
        {
        }

        //TODO DELETE OR REPLACE Template

        public DbSet<Template> Templates { get; set; }

        //TODO DELETE Database and re generate with update-database in the Package Manager Console
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
