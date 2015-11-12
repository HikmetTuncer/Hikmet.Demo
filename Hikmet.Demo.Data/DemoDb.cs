using Hikmet.Demo.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Hikmet.Demo.Data
{
    public class DemoDb : DbContext
    {
        public DemoDb()
            : base("DefaultConnection")
        {
            // required to force Azure to run the migration scripts when deploying from Git
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DemoDb, Data.Migrations.Configuration>());
            
        }

        public DbSet<Kebab> Kebabs { get; set; }
        public DbSet<Pizza> Pizzas { get; set; }
    }
}
