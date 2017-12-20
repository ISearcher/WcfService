using System.Data.Entity;
using System.Data.Entity.Migrations;
using WcfService.Migrations;

namespace WcfService.Entity
{
    public class ServerInitializer : IDatabaseInitializer<DataContext>
    {
        public void InitializeDatabase(DataContext context)
        {
            var config = new Configuration();
            var migrator = new DbMigrator(config);
            migrator.Update();

            context.SaveChanges();
        }
    }
}