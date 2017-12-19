using Ninject.Modules;
using WcfService.Entity;

namespace WcfService.Utility
{
    public class WcfNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IRepository>().To<Repository>();
        }
    }
}