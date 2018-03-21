namespace BrnoMvc1.Web.Migrations
{
    using BrnoMvc1.Web.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BrnoMvc1.Web.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "BrnoMvc1.Web.Models.ApplicationDbContext";
        }

        protected override void Seed(BrnoMvc1.Web.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Movies.AddOrUpdate(
              p => p.Id,
              new Movie { Id = 1, Title = "Homer" },
              new Movie { Id = 2, Title = "Pelisky" }
            );
            //
        }
    }
}
