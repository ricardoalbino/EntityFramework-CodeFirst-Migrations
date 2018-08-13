namespace EntityFramework_CodeFirst_Migrations.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EntityFramework_CodeFirst_Migrations.EF_DBContext.DBProduto>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "EntityFramework_CodeFirst_Migrations.EF_DBContext.DBProduto";
        }

        protected override void Seed(EntityFramework_CodeFirst_Migrations.EF_DBContext.DBProduto context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
