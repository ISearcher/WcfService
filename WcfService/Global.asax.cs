using System.Data.Entity;
using Ninject;
using Ninject.Web.Common.WebHost;
using WcfService.Infrastructure;
using WcfService.Utility;

namespace WcfService
{
    public class Global : NinjectHttpApplication
    {
        protected override IKernel CreateKernel()
        {
            return new StandardKernel(new WcfNinjectModule());
        }

        protected override void OnApplicationStarted()
        {
            base.OnApplicationStarted();

            Database.SetInitializer(new ServerInitializer());
            using (var ctx = new DataContext())
            {
                ctx.Database.CreateIfNotExists();
            }
        }
    }
}