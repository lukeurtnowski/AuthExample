namespace AuthExample.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AuthExample.Data.AuthDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AuthExample.Data.AuthDbContext context)
        {
            if (context.Database.Connection.ConnectionString.Contains("LocalDb"))
                SeedForDev(context);
            else
                SeedForProduction(context);
        }

        private void SeedForProduction(AuthDbContext context)
        {
            Seeder.Seed(context);
        }

        private void SeedForDev(AuthDbContext context)
        {
            Seeder.Seed(context,true);
        }
    }
}
