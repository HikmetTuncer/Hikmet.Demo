using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using Hikmet.Demo.Entities;

namespace Hikmet.Demo.Data
{
    /// <summary>
    ///     This DB initalizer should only be used until the first version of the schema is stable.
    ///     It will delete the entire DB, and then seed it with some data.  
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class DevelopmentModeInitializer<T> : DropCreateDatabaseAlways<DemoDb>
    {
        public override void InitializeDatabase(DemoDb context)
        {
            // THIS DOES NOT WORK ON AZURE! (SINGLE_USER is not allowed)
            //context.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction
            //    , string.Format("ALTER DATABASE [{0}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE", context.Database.Connection.Database));

            base.InitializeDatabase(context);
        }

        protected override void Seed(DemoDb context)
        {

            var pizzas = new List<Pizza>()
            {
                    new Pizza() { NameChanged = "Hikker Special", Price = 150 },
                    new Pizza() { NameChanged = "Fred Special", Price = 100 }
            };

            context.Pizzas.RemoveRange(context.Pizzas);
            context.Pizzas.AddRange(pizzas);
            base.Seed(context);

        }
       
    }
}