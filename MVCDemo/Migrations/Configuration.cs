namespace MVCDemo.Migrations
{
    using MVCDemo.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVCDemo.DAL.AccountContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MVCDemo.DAL.AccountContext context)
        {
            //  This method will be called after migrating to the latest version.
            context.SysUsers.AddOrUpdate(x =>x.ID,new SysUser { UserName="admin",Password="123456"});
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.SaveChanges();
        }
    }
}
