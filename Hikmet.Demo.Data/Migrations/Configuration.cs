namespace Hikmet.Demo.Data.Migrations
{
    using Hikmet.Demo.Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Hikmet.Demo.Data.DemoDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true; 

            //ContextKey = "Hikmet.Demo.Data.DemoDb";
        }

        protected override void Seed(Hikmet.Demo.Data.DemoDb context)
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

            var pizzas = new List<Pizza>()
            {
                    new Pizza() { NameChanged = "Hikker Special", Price = 150 },
                    new Pizza() { NameChanged = "Fred Special", Price = 100 }
            };

            context.Pizzas.RemoveRange(context.Pizzas); 
            context.Pizzas.AddRange(pizzas);
        }
    }
}
