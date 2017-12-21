using Ninject.Modules;
using WcfService.Entity;
using WcfService.Infrastructure;

namespace WcfService.Utility
{
    public class WcfNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IRepository>().To<Repository>();
            Bind<IDbFactory>().To<DbFactory>();
        }
    }
}